namespace CarManagement
{
    partial class ConfirmForm
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
        private void InitializeComponent()
        {
            messageConfirm = new Label();
            OK = new Button();
            Cancel = new Button();
            SuspendLayout();
            // 
            // messageConfirm
            // 
            messageConfirm.AutoSize = true;
            messageConfirm.Location = new Point(30, 25);
            messageConfirm.Name = "messageConfirm";
            messageConfirm.Size = new Size(0, 20);
            messageConfirm.TabIndex = 0;
            // 
            // OK
            // 
            OK.DialogResult = DialogResult.OK;
            OK.Location = new Point(79, 127);
            OK.Name = "OK";
            OK.Size = new Size(94, 29);
            OK.TabIndex = 1;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            Cancel.DialogResult = DialogResult.Cancel;
            Cancel.Location = new Point(288, 127);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(94, 29);
            Cancel.TabIndex = 2;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            // 
            // ConfirmForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Cancel;
            ClientSize = new Size(454, 188);
            Controls.Add(Cancel);
            Controls.Add(OK);
            Controls.Add(messageConfirm);
            KeyPreview = true;
            Name = "ConfirmForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Confirm";
            Load += ConfirmForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label messageConfirm;
        private Button OK;
        private Button Cancel;
    }
}