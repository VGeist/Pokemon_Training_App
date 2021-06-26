namespace Pokemon_Training_App.Views
{
    partial class frmChangeForm
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
            this.cmbForm = new System.Windows.Forms.ComboBox();
            this.slblForm = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNewForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbForm
            // 
            this.cmbForm.FormattingEnabled = true;
            this.cmbForm.ItemHeight = 22;
            this.cmbForm.Items.AddRange(new object[] {
            "Default",
            "Calm",
            "Bold",
            "Hardy",
            "Bashful",
            "Relaxed",
            "TEMPORARY"});
            this.cmbForm.Location = new System.Drawing.Point(136, 6);
            this.cmbForm.MaxDropDownItems = 32;
            this.cmbForm.Name = "cmbForm";
            this.cmbForm.Size = new System.Drawing.Size(193, 30);
            this.cmbForm.TabIndex = 0;
            this.cmbForm.Text = "Default";
            // 
            // slblForm
            // 
            this.slblForm.AutoSize = true;
            this.slblForm.Location = new System.Drawing.Point(10, 9);
            this.slblForm.Name = "slblForm";
            this.slblForm.Size = new System.Drawing.Size(120, 22);
            this.slblForm.TabIndex = 31;
            this.slblForm.Text = "Select a Form.";
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.Location = new System.Drawing.Point(135, 55);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(87, 32);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(228, 55);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnNewForm
            // 
            this.btnNewForm.AutoSize = true;
            this.btnNewForm.Location = new System.Drawing.Point(25, 55);
            this.btnNewForm.Name = "btnNewForm";
            this.btnNewForm.Size = new System.Drawing.Size(104, 32);
            this.btnNewForm.TabIndex = 1;
            this.btnNewForm.Text = "New Form";
            this.btnNewForm.UseVisualStyleBackColor = true;
            // 
            // frmChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 96);
            this.Controls.Add(this.btnNewForm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cmbForm);
            this.Controls.Add(this.slblForm);
            this.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmChangeForm";
            this.Text = "Change Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbForm;
        private System.Windows.Forms.Label slblForm;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewForm;
    }
}