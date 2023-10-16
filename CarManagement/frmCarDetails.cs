namespace CarManagement
{
    public partial class frmCarDetails : Form
    {
        public frmCarDetails()
        {
            InitializeComponent();
        }
        public bool InsertOrUpdate { get; set; }
        public Car CarInfo { get; set; }
        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedIndex = 0;
            txtCarID.Enabled = InsertOrUpdate;
            if (!InsertOrUpdate)
            {
                imgCar.Image = new Bitmap(Image.FromFile(CarInfo.CarImg.ToString()));
                txtDescrible.Text = CarInfo.CarDescription;
                txtCarID.Text = CarInfo.CarID.ToString();
                txtCarName.Text = CarInfo.CarName;
                txtPrice.Text = CarInfo.Price.ToString();
                txtReleaseYear.Text = CarInfo.ReleaseYear.ToString();
                cboManufacturer.Text = CarInfo.Manufacturer.Trim();
                txtImgName.Text = CarInfo.CarImg.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = new Car
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = cboManufacturer.Text,
                    CarDescription = txtDescrible.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtReleaseYear.Text),
                    CarImg = string.Concat("images/", Path.GetFileName(txtImgName.Text))
                };
                string path = Path.Combine(@"C:\Users\Raiku\source\repos\CarManagement\CarManagement\bin\Debug\net6.0-windows\images", Path.GetFileName(txtImgName.Text));
                if (!File.Exists(path))
                {
                    File.Copy(txtImgName.Text, path, true);
                }
                MessageBox.Show(car.CarImg);
                if (InsertOrUpdate)
                {
                    new CarRepository().InsertCar(car);
                    MessageBox.Show("Insert new car successful!!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    new CarRepository().UpdateCar(car);
                    MessageBox.Show("Update car successful!!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.png; *.jpeg; *.jpg; *.gif;)|*.png; *.jpeg; *.jpg; *.gif;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtImgName.Text = openFileDialog.FileName;
                imgCar.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}