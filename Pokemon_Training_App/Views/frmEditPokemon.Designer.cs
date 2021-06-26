namespace Pokemon_Training_App.Views
{
    partial class frmEditPokemon
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
            this.slblPokemonName = new System.Windows.Forms.Label();
            this.slblPokemonNumber = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPokemonName = new System.Windows.Forms.TextBox();
            this.txtPokemonNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // slblPokemonName
            // 
            this.slblPokemonName.AutoSize = true;
            this.slblPokemonName.Location = new System.Drawing.Point(12, 61);
            this.slblPokemonName.Name = "slblPokemonName";
            this.slblPokemonName.Size = new System.Drawing.Size(138, 22);
            this.slblPokemonName.TabIndex = 28;
            this.slblPokemonName.Text = "Pokemon Name";
            // 
            // slblPokemonNumber
            // 
            this.slblPokemonNumber.AutoSize = true;
            this.slblPokemonNumber.Location = new System.Drawing.Point(12, 15);
            this.slblPokemonNumber.Name = "slblPokemonNumber";
            this.slblPokemonNumber.Size = new System.Drawing.Size(158, 22);
            this.slblPokemonNumber.TabIndex = 27;
            this.slblPokemonNumber.Text = "Pokemon Number";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(180, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Entry";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(85, 100);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(89, 30);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(305, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtPokemonName
            // 
            this.txtPokemonName.Location = new System.Drawing.Point(190, 58);
            this.txtPokemonName.Name = "txtPokemonName";
            this.txtPokemonName.Size = new System.Drawing.Size(185, 30);
            this.txtPokemonName.TabIndex = 2;
            // 
            // txtPokemonNum
            // 
            this.txtPokemonNum.Location = new System.Drawing.Point(190, 12);
            this.txtPokemonNum.Name = "txtPokemonNum";
            this.txtPokemonNum.Size = new System.Drawing.Size(185, 30);
            this.txtPokemonNum.TabIndex = 1;
            // 
            // frmEditPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 138);
            this.Controls.Add(this.slblPokemonName);
            this.Controls.Add(this.slblPokemonNumber);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPokemonName);
            this.Controls.Add(this.txtPokemonNum);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEditPokemon";
            this.Text = "Edit Pokemon Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label slblPokemonName;
        private System.Windows.Forms.Label slblPokemonNumber;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPokemonName;
        private System.Windows.Forms.TextBox txtPokemonNum;
    }
}