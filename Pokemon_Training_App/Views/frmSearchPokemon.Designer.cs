﻿namespace Pokemon_Training_App.Views
{
    partial class frmSearchPokemon
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
            this.slblPokemonNum = new System.Windows.Forms.Label();
            this.txtPokemonNum = new System.Windows.Forms.TextBox();
            this.txtPokemonName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.radName = new System.Windows.Forms.RadioButton();
            this.radNumber = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // slblPokemonName
            // 
            this.slblPokemonName.AutoSize = true;
            this.slblPokemonName.Enabled = false;
            this.slblPokemonName.Location = new System.Drawing.Point(47, 75);
            this.slblPokemonName.Name = "slblPokemonName";
            this.slblPokemonName.Size = new System.Drawing.Size(143, 22);
            this.slblPokemonName.TabIndex = 0;
            this.slblPokemonName.Text = "Pokemon Name:";
            // 
            // slblPokemonNum
            // 
            this.slblPokemonNum.AutoSize = true;
            this.slblPokemonNum.Location = new System.Drawing.Point(47, 22);
            this.slblPokemonNum.Name = "slblPokemonNum";
            this.slblPokemonNum.Size = new System.Drawing.Size(163, 22);
            this.slblPokemonNum.TabIndex = 1;
            this.slblPokemonNum.Text = "Pokemon Number:";
            // 
            // txtPokemonNum
            // 
            this.txtPokemonNum.Location = new System.Drawing.Point(213, 19);
            this.txtPokemonNum.Name = "txtPokemonNum";
            this.txtPokemonNum.Size = new System.Drawing.Size(85, 30);
            this.txtPokemonNum.TabIndex = 1;
            // 
            // txtPokemonName
            // 
            this.txtPokemonName.Enabled = false;
            this.txtPokemonName.Location = new System.Drawing.Point(213, 72);
            this.txtPokemonName.Name = "txtPokemonName";
            this.txtPokemonName.Size = new System.Drawing.Size(201, 30);
            this.txtPokemonName.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(118, 126);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(228, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // radName
            // 
            this.radName.AutoSize = true;
            this.radName.Location = new System.Drawing.Point(17, 80);
            this.radName.Name = "radName";
            this.radName.Size = new System.Drawing.Size(14, 13);
            this.radName.TabIndex = 10;
            this.radName.UseVisualStyleBackColor = true;
            this.radName.CheckedChanged += new System.EventHandler(this.radName_CheckedChanged);
            // 
            // radNumber
            // 
            this.radNumber.AutoSize = true;
            this.radNumber.Checked = true;
            this.radNumber.Location = new System.Drawing.Point(17, 27);
            this.radNumber.Name = "radNumber";
            this.radNumber.Size = new System.Drawing.Size(14, 13);
            this.radNumber.TabIndex = 10;
            this.radNumber.UseVisualStyleBackColor = true;
            this.radNumber.CheckedChanged += new System.EventHandler(this.radNumber_CheckedChanged);
            // 
            // frmSearchPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 176);
            this.Controls.Add(this.radNumber);
            this.Controls.Add(this.radName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPokemonName);
            this.Controls.Add(this.txtPokemonNum);
            this.Controls.Add(this.slblPokemonNum);
            this.Controls.Add(this.slblPokemonName);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSearchPokemon";
            this.Text = "Find Pokemon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label slblPokemonName;
        private System.Windows.Forms.Label slblPokemonNum;
        private System.Windows.Forms.TextBox txtPokemonNum;
        private System.Windows.Forms.TextBox txtPokemonName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton radName;
        private System.Windows.Forms.RadioButton radNumber;
    }
}