namespace Pokemon_Training_App.Views
{
    partial class frmSearchPartner
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
            this.components = new System.ComponentModel.Container();
            this.slblPokemonNum = new System.Windows.Forms.Label();
            this.slblNature = new System.Windows.Forms.Label();
            this.slblLevel = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbNature = new System.Windows.Forms.ComboBox();
            this.txtPokemonNum = new System.Windows.Forms.TextBox();
            this.txtLevelMin = new System.Windows.Forms.TextBox();
            this.txtLevelMax = new System.Windows.Forms.TextBox();
            this.slblToLevel = new System.Windows.Forms.Label();
            this.slblIVTotal = new System.Windows.Forms.Label();
            this.slblEvTotal = new System.Windows.Forms.Label();
            this.slblNickname = new System.Windows.Forms.Label();
            this.slblToIV = new System.Windows.Forms.Label();
            this.txtIVMax = new System.Windows.Forms.TextBox();
            this.txtIVMin = new System.Windows.Forms.TextBox();
            this.slblToEV = new System.Windows.Forms.Label();
            this.txtEVMax = new System.Windows.Forms.TextBox();
            this.txtEVMin = new System.Windows.Forms.TextBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.chkHasPokerus = new System.Windows.Forms.CheckBox();
            this.ttpPokerus = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // slblPokemonNum
            // 
            this.slblPokemonNum.AutoSize = true;
            this.slblPokemonNum.Location = new System.Drawing.Point(12, 9);
            this.slblPokemonNum.Name = "slblPokemonNum";
            this.slblPokemonNum.Size = new System.Drawing.Size(163, 22);
            this.slblPokemonNum.TabIndex = 0;
            this.slblPokemonNum.Text = "Pokemon Number:";
            // 
            // slblNature
            // 
            this.slblNature.AutoSize = true;
            this.slblNature.Location = new System.Drawing.Point(12, 57);
            this.slblNature.Name = "slblNature";
            this.slblNature.Size = new System.Drawing.Size(71, 22);
            this.slblNature.TabIndex = 1;
            this.slblNature.Text = "Nature:";
            // 
            // slblLevel
            // 
            this.slblLevel.AutoSize = true;
            this.slblLevel.Location = new System.Drawing.Point(12, 105);
            this.slblLevel.Name = "slblLevel";
            this.slblLevel.Size = new System.Drawing.Size(58, 22);
            this.slblLevel.TabIndex = 2;
            this.slblLevel.Text = "Level:";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(315, 157);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 32);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(421, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbNature
            // 
            this.cmbNature.FormattingEnabled = true;
            this.cmbNature.Items.AddRange(new object[] {
            "Calm",
            "Bold",
            "Hardy",
            "Bashful",
            "Relaxed",
            "TEMPORARY"});
            this.cmbNature.Location = new System.Drawing.Point(131, 54);
            this.cmbNature.Name = "cmbNature";
            this.cmbNature.Size = new System.Drawing.Size(121, 30);
            this.cmbNature.TabIndex = 3;
            this.cmbNature.Text = "Hardy";
            // 
            // txtPokemonNum
            // 
            this.txtPokemonNum.Location = new System.Drawing.Point(181, 6);
            this.txtPokemonNum.Name = "txtPokemonNum";
            this.txtPokemonNum.Size = new System.Drawing.Size(71, 30);
            this.txtPokemonNum.TabIndex = 1;
            // 
            // txtLevelMin
            // 
            this.txtLevelMin.Location = new System.Drawing.Point(131, 102);
            this.txtLevelMin.Name = "txtLevelMin";
            this.txtLevelMin.Size = new System.Drawing.Size(44, 30);
            this.txtLevelMin.TabIndex = 6;
            // 
            // txtLevelMax
            // 
            this.txtLevelMax.Location = new System.Drawing.Point(208, 102);
            this.txtLevelMax.Name = "txtLevelMax";
            this.txtLevelMax.Size = new System.Drawing.Size(44, 30);
            this.txtLevelMax.TabIndex = 7;
            // 
            // slblToLevel
            // 
            this.slblToLevel.AutoSize = true;
            this.slblToLevel.Location = new System.Drawing.Point(177, 105);
            this.slblToLevel.Name = "slblToLevel";
            this.slblToLevel.Size = new System.Drawing.Size(26, 22);
            this.slblToLevel.TabIndex = 9;
            this.slblToLevel.Text = "to";
            // 
            // slblIVTotal
            // 
            this.slblIVTotal.AutoSize = true;
            this.slblIVTotal.Location = new System.Drawing.Point(275, 105);
            this.slblIVTotal.Name = "slblIVTotal";
            this.slblIVTotal.Size = new System.Drawing.Size(75, 22);
            this.slblIVTotal.TabIndex = 12;
            this.slblIVTotal.Text = "IV Total:";
            // 
            // slblEvTotal
            // 
            this.slblEvTotal.AutoSize = true;
            this.slblEvTotal.Location = new System.Drawing.Point(275, 57);
            this.slblEvTotal.Name = "slblEvTotal";
            this.slblEvTotal.Size = new System.Drawing.Size(80, 22);
            this.slblEvTotal.TabIndex = 11;
            this.slblEvTotal.Text = "EV Total:";
            // 
            // slblNickname
            // 
            this.slblNickname.AutoSize = true;
            this.slblNickname.Location = new System.Drawing.Point(275, 9);
            this.slblNickname.Name = "slblNickname";
            this.slblNickname.Size = new System.Drawing.Size(96, 22);
            this.slblNickname.TabIndex = 10;
            this.slblNickname.Text = "Nickname:";
            // 
            // slblToIV
            // 
            this.slblToIV.AutoSize = true;
            this.slblToIV.Location = new System.Drawing.Point(431, 108);
            this.slblToIV.Name = "slblToIV";
            this.slblToIV.Size = new System.Drawing.Size(26, 22);
            this.slblToIV.TabIndex = 15;
            this.slblToIV.Text = "to";
            // 
            // txtIVMax
            // 
            this.txtIVMax.Location = new System.Drawing.Point(462, 105);
            this.txtIVMax.Name = "txtIVMax";
            this.txtIVMax.Size = new System.Drawing.Size(44, 30);
            this.txtIVMax.TabIndex = 9;
            // 
            // txtIVMin
            // 
            this.txtIVMin.Location = new System.Drawing.Point(385, 105);
            this.txtIVMin.Name = "txtIVMin";
            this.txtIVMin.Size = new System.Drawing.Size(44, 30);
            this.txtIVMin.TabIndex = 8;
            // 
            // slblToEV
            // 
            this.slblToEV.AutoSize = true;
            this.slblToEV.Location = new System.Drawing.Point(431, 57);
            this.slblToEV.Name = "slblToEV";
            this.slblToEV.Size = new System.Drawing.Size(26, 22);
            this.slblToEV.TabIndex = 18;
            this.slblToEV.Text = "to";
            // 
            // txtEVMax
            // 
            this.txtEVMax.Location = new System.Drawing.Point(462, 54);
            this.txtEVMax.Name = "txtEVMax";
            this.txtEVMax.Size = new System.Drawing.Size(44, 30);
            this.txtEVMax.TabIndex = 5;
            // 
            // txtEVMin
            // 
            this.txtEVMin.Location = new System.Drawing.Point(385, 54);
            this.txtEVMin.Name = "txtEVMin";
            this.txtEVMin.Size = new System.Drawing.Size(44, 30);
            this.txtEVMin.TabIndex = 4;
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(377, 9);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(129, 30);
            this.txtNickname.TabIndex = 2;
            // 
            // chkHasPokerus
            // 
            this.chkHasPokerus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chkHasPokerus.Image = global::Pokemon_Training_App.Properties.Resources.PokérusIC_infected;
            this.chkHasPokerus.Location = new System.Drawing.Point(102, 149);
            this.chkHasPokerus.Name = "chkHasPokerus";
            this.chkHasPokerus.Size = new System.Drawing.Size(73, 51);
            this.chkHasPokerus.TabIndex = 10;
            this.ttpPokerus.SetToolTip(this.chkHasPokerus, "Check if pokemon has (or had) Pokerus.");
            this.chkHasPokerus.UseVisualStyleBackColor = true;
            // 
            // ttpPokerus
            // 
            this.ttpPokerus.ToolTipTitle = "Pokerus";
            // 
            // frmSearchPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 201);
            this.Controls.Add(this.chkHasPokerus);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.slblToEV);
            this.Controls.Add(this.txtEVMax);
            this.Controls.Add(this.txtEVMin);
            this.Controls.Add(this.slblToIV);
            this.Controls.Add(this.txtIVMax);
            this.Controls.Add(this.txtIVMin);
            this.Controls.Add(this.slblIVTotal);
            this.Controls.Add(this.slblEvTotal);
            this.Controls.Add(this.slblNickname);
            this.Controls.Add(this.slblToLevel);
            this.Controls.Add(this.txtLevelMax);
            this.Controls.Add(this.txtLevelMin);
            this.Controls.Add(this.txtPokemonNum);
            this.Controls.Add(this.cmbNature);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.slblLevel);
            this.Controls.Add(this.slblNature);
            this.Controls.Add(this.slblPokemonNum);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSearchPartner";
            this.Text = "Find Partner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label slblPokemonNum;
        private System.Windows.Forms.Label slblNature;
        private System.Windows.Forms.Label slblLevel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbNature;
        private System.Windows.Forms.TextBox txtPokemonNum;
        private System.Windows.Forms.TextBox txtLevelMin;
        private System.Windows.Forms.TextBox txtLevelMax;
        private System.Windows.Forms.Label slblToLevel;
        private System.Windows.Forms.Label slblIVTotal;
        private System.Windows.Forms.Label slblEvTotal;
        private System.Windows.Forms.Label slblNickname;
        private System.Windows.Forms.Label slblToIV;
        private System.Windows.Forms.TextBox txtIVMax;
        private System.Windows.Forms.TextBox txtIVMin;
        private System.Windows.Forms.Label slblToEV;
        private System.Windows.Forms.TextBox txtEVMax;
        private System.Windows.Forms.TextBox txtEVMin;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.CheckBox chkHasPokerus;
        private System.Windows.Forms.ToolTip ttpPokerus;
    }
}