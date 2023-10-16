namespace CarManagement
{
    partial class CarManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtCarName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnNew = new Button();
            Delete = new Button();
            listCarGridForm = new DataGridView();
            Edit = new Button();
            txtManufacturer = new ComboBox();
            txtReleaseYear = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            txtCarId = new MaskedTextBox();
            txtPrice = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)listCarGridForm).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 38);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Car ID";
            label1.Click += label1_Click;
            // 
            // txtCarName
            // 
            txtCarName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCarName.Location = new Point(152, 90);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(211, 27);
            txtCarName.TabIndex = 3;
            txtCarName.KeyDown += load_KeyDown;
            txtCarName.Leave += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 93);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Car Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 157);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 4;
            label3.Text = "Manufacturer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 41);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 6;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 96);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 8;
            label5.Text = "Released Year";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(660, 207);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 11;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(448, 409);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 12;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // listCarGridForm
            // 
            listCarGridForm.AllowUserToDeleteRows = false;
            listCarGridForm.AllowUserToOrderColumns = true;
            listCarGridForm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listCarGridForm.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            listCarGridForm.ColumnHeadersHeight = 29;
            listCarGridForm.Location = new Point(49, 254);
            listCarGridForm.MultiSelect = false;
            listCarGridForm.Name = "listCarGridForm";
            listCarGridForm.RowHeadersWidth = 51;
            listCarGridForm.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            listCarGridForm.RowTemplate.Height = 29;
            listCarGridForm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listCarGridForm.Size = new Size(705, 149);
            listCarGridForm.TabIndex = 14;
            listCarGridForm.CellDoubleClick += Edit_Click;
            listCarGridForm.Sorted += listCarGridForm_Sorted;
            // 
            // Edit
            // 
            Edit.Location = new Point(230, 409);
            Edit.Name = "Edit";
            Edit.Size = new Size(94, 29);
            Edit.TabIndex = 15;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // txtManufacturer
            // 
            txtManufacturer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtManufacturer.FormattingEnabled = true;
            txtManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            txtManufacturer.Location = new Point(152, 153);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(211, 28);
            txtManufacturer.TabIndex = 16;
            txtManufacturer.KeyDown += load_KeyDown;
            txtManufacturer.Leave += button1_Click;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtReleaseYear.FormattingEnabled = true;
            txtReleaseYear.Items.AddRange(new object[] { "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010" });
            txtReleaseYear.Location = new Point(517, 90);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(211, 28);
            txtReleaseYear.TabIndex = 17;
            txtReleaseYear.KeyDown += load_KeyDown;
            txtReleaseYear.Leave += button1_Click;
            // 
            // txtCarId
            // 
            txtCarId.Location = new Point(152, 34);
            txtCarId.Mask = "00000";
            txtCarId.Name = "txtCarId";
            txtCarId.Size = new Size(211, 27);
            txtCarId.TabIndex = 18;
            txtCarId.ValidatingType = typeof(int);
            txtCarId.KeyDown += load_KeyDown;
            txtCarId.Leave += button1_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(517, 35);
            txtPrice.Mask = "0000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(211, 27);
            txtPrice.TabIndex = 19;
            txtPrice.KeyDown += load_KeyDown;
            txtPrice.Leave += button1_Click;
            // 
            // CarManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPrice);
            Controls.Add(txtCarId);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtManufacturer);
            Controls.Add(Edit);
            Controls.Add(listCarGridForm);
            Controls.Add(Delete);
            Controls.Add(btnNew);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCarName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CarManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += CarManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)listCarGridForm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCarName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnNew;
        private Button Delete;
        private DataGridView listCarGridForm;
        private Button Edit;
        private ComboBox txtManufacturer;
        private ComboBox txtReleaseYear;
        private NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timer1;
        private MaskedTextBox txtCarId;
        private MaskedTextBox txtPrice;
    }
}