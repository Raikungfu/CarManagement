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
    public partial class ConfirmForm : Form
    {
        public string message;
        public bool ErrorOrConfirm;
        public ConfirmForm()
        {
            InitializeComponent();
        }

        private void ConfirmForm_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            messageConfirm.Text = message;
            OK.Visible = !ErrorOrConfirm;
        }

    }
}
