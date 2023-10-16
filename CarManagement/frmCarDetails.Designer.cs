namespace CarManagement
{
    partial class frmCarDetails
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbCarID = new Label();
            lbCarName = new Label();
            lbManufacturer = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            txtPrice = new MaskedTextBox();
            txtReleaseYear = new MaskedTextBox();
            cboManufacturer = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            imgCar = new PictureBox();
            label1 = new Label();
            txtDescrible = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            btnChooseImg = new Button();
            txtImgName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)imgCar).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(27, 33);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(24, 20);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(26, 76);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(49, 20);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(26, 125);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(97, 20);
            lbManufacturer.TabIndex = 2;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(26, 171);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(25, 217);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(88, 20);
            lbReleaseYear.TabIndex = 4;
            lbReleaseYear.Text = "ReleaseYear";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(129, 30);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(211, 27);
            txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(128, 76);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(211, 27);
            txtCarName.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(128, 168);
            txtPrice.Mask = "00000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(211, 27);
            txtPrice.TabIndex = 7;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(128, 214);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.MinimumSize = new Size(4, 4);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(211, 27);
            txtReleaseYear.TabIndex = 8;
            txtReleaseYear.TextMaskFormat = MaskFormat.IncludePrompt;
            txtReleaseYear.ValidatingType = typeof(DateTime);
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new Point(129, 122);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(211, 28);
            cboManufacturer.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(376, 330);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(493, 330);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // imgCar
            // 
            imgCar.Location = new Point(367, 30);
            imgCar.Name = "imgCar";
            imgCar.Size = new Size(239, 181);
            imgCar.SizeMode = PictureBoxSizeMode.StretchImage;
            imgCar.TabIndex = 12;
            imgCar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 265);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 14;
            label1.Text = "Describle";
            // 
            // txtDescrible
            // 
            txtDescrible.Location = new Point(128, 265);
            txtDescrible.Name = "txtDescrible";
            txtDescrible.Size = new Size(212, 113);
            txtDescrible.TabIndex = 15;
            txtDescrible.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnChooseImg
            // 
            btnChooseImg.Location = new Point(493, 265);
            btnChooseImg.Name = "btnChooseImg";
            btnChooseImg.Size = new Size(113, 29);
            btnChooseImg.TabIndex = 16;
            btnChooseImg.Text = "Choose Image";
            btnChooseImg.UseVisualStyleBackColor = true;
            btnChooseImg.Click += button1_Click;
            // 
            // txtImgName
            // 
            txtImgName.Location = new Point(365, 228);
            txtImgName.Name = "txtImgName";
            txtImgName.Size = new Size(241, 27);
            txtImgName.TabIndex = 17;
            // 
            // frmCarDetails
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(628, 399);
            Controls.Add(txtImgName);
            Controls.Add(btnChooseImg);
            Controls.Add(txtDescrible);
            Controls.Add(label1);
            Controls.Add(imgCar);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboManufacturer);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarDetails";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ((System.ComponentModel.ISupportInitialize)imgCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private Label lbCarName;
        private Label lbManufacturer;
        private Label lbPrice;
        private Label lbReleaseYear;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private MaskedTextBox txtPrice;
        private MaskedTextBox txtReleaseYear;
        private ComboBox cboManufacturer;
        private Button btnSave;
        private Button btnCancel;
        private PictureBox imgCar;
        private Label label1;
        private RichTextBox txtDescrible;
        private OpenFileDialog openFileDialog1;
        private Button btnChooseImg;
        private TextBox txtImgName;
    }
}