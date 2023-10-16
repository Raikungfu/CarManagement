using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagement
{
    public partial class CarManagementForm : Form
    {
        CarRepository carRes = new CarRepository();
        BindingSource source;
        public CarManagementForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCarDetails addNewCarForm = new frmCarDetails
            {
                Text = "Add New Car",
                InsertOrUpdate = true
            };
            var result = addNewCarForm.ShowDialog();

            while (true)
            {
                if (result == DialogResult.OK)
                {
                    LoadListCar();
                    result = new frmCarDetails
                    {
                        Text = "Add New Car",
                        InsertOrUpdate = true
                    }.ShowDialog();
                }
                else if (result == DialogResult.Cancel)
                {
                    break;
                }
            }

        }

        private void CarManagementForm_Load(object sender, EventArgs e)
        {
            LoadListCar();
        }

        public void LoadListCar()
        {
            source = new BindingSource();
            source.DataSource = carRes.GetCars().ToList<Car>();
            listCarGridForm.DataSource = source;
            this.listCarGridForm.Columns["CarImg"].Visible = false;
            this.listCarGridForm.Columns["CarDescription"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Load_Search();
        }

        private void Load_Search()
        {
            Car car = new Car
            {
                CarID = int.TryParse(txtCarId.Text, out int carId) ? carId : 0,
                CarName = string.IsNullOrEmpty(txtCarName.Text) ? "" : txtCarName.Text,
                Manufacturer = string.IsNullOrEmpty(txtManufacturer.Text) ? "" : txtManufacturer.Text,
                Price = decimal.TryParse(txtPrice.Text, out decimal price) ? price : 0,
                ReleaseYear = int.TryParse(txtReleaseYear.Text, out int releaseYear) ? releaseYear : 0
            };
            try
            {
                source.DataSource = carRes.SearchCar(car);
                listCarGridForm.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (listCarGridForm.SelectedCells.Count > 0)
            {
                ConfirmForm confirmForm = new ConfirmForm
                {
                    Text = "Confirm",
                    message = "Accept delete this car?"
                };
                if (confirmForm.ShowDialog() == DialogResult.OK)
                {
                    carRes.DeleteCar(int.Parse(listCarGridForm.SelectedRows[0].Cells[1].Value.ToString()));
                    listCarGridForm.Rows.RemoveAt(listCarGridForm.SelectedRows[0].Index);
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {

            frmCarDetails frmCarUpdate = new frmCarDetails
            {
                Text = "Update car",
                InsertOrUpdate = false,
                CarInfo = carRes.SearchCar((Car)listCarGridForm.SelectedRows[0].DataBoundItem).First<Car>()
            };
            var tf = frmCarUpdate.ShowDialog(this);
            while (true)
            {
                if (tf == DialogResult.OK)
                {
                    LoadListCar();
                    tf = frmCarUpdate.ShowDialog(this);
                }
                else if (tf == DialogResult.Cancel)
                {
                    break;
                }
            }
        }

        private void listCarGridForm_Sorted(object sender, EventArgs e)
        {

        }

        private void load_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Load_Search();
            }
        }
    }
}
