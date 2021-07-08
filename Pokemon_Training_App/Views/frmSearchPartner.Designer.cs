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
            this.slblToLevel = new System.Windows.Forms.Label();
            this.slblEvTotal = new System.Windows.Forms.Label();
            this.slblNickname = new System.Windows.Forms.Label();
            this.slblToEV = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.ttpPokerus = new System.Windows.Forms.ToolTip(this.components);
            this.slblPokerus = new System.Windows.Forms.Label();
            this.chkHasPokerus = new System.Windows.Forms.CheckBox();
            this.numNumber = new System.Windows.Forms.NumericUpDown();
            this.numMinLevel = new System.Windows.Forms.NumericUpDown();
            this.numMaxLevel = new System.Windows.Forms.NumericUpDown();
            this.numMaxEV = new System.Windows.Forms.NumericUpDown();
            this.numMinEV = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinEV)).BeginInit();
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
            this.btnSearch.Location = new System.Drawing.Point(335, 142);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 32);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(426, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 10;
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
            // slblToLevel
            // 
            this.slblToLevel.AutoSize = true;
            this.slblToLevel.Location = new System.Drawing.Point(164, 105);
            this.slblToLevel.Name = "slblToLevel";
            this.slblToLevel.Size = new System.Drawing.Size(26, 22);
            this.slblToLevel.TabIndex = 9;
            this.slblToLevel.Text = "to";
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
            // slblToEV
            // 
            this.slblToEV.AutoSize = true;
            this.slblToEV.Location = new System.Drawing.Point(423, 57);
            this.slblToEV.Name = "slblToEV";
            this.slblToEV.Size = new System.Drawing.Size(26, 22);
            this.slblToEV.TabIndex = 18;
            this.slblToEV.Text = "to";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(382, 6);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(129, 30);
            this.txtNickname.TabIndex = 2;
            // 
            // ttpPokerus
            // 
            this.ttpPokerus.ToolTipTitle = "Pokerus";
            // 
            // slblPokerus
            // 
            this.slblPokerus.AutoSize = true;
            this.slblPokerus.Location = new System.Drawing.Point(275, 105);
            this.slblPokerus.Name = "slblPokerus";
            this.slblPokerus.Size = new System.Drawing.Size(116, 22);
            this.slblPokerus.TabIndex = 19;
            this.slblPokerus.Text = "Has Pokerus:";
            // 
            // chkHasPokerus
            // 
            this.chkHasPokerus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chkHasPokerus.Image = global::Pokemon_Training_App.Properties.Resources.PokérusIC_infected;
            this.chkHasPokerus.Location = new System.Drawing.Point(410, 92);
            this.chkHasPokerus.Name = "chkHasPokerus";
            this.chkHasPokerus.Size = new System.Drawing.Size(73, 51);
            this.chkHasPokerus.TabIndex = 8;
            this.ttpPokerus.SetToolTip(this.chkHasPokerus, "Check if pokemon has (or had) Pokerus.");
            this.chkHasPokerus.UseVisualStyleBackColor = true;
            // 
            // numNumber
            // 
            this.numNumber.Location = new System.Drawing.Point(196, 7);
            this.numNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNumber.Name = "numNumber";
            this.numNumber.Size = new System.Drawing.Size(56, 30);
            this.numNumber.TabIndex = 1;
            // 
            // numMinLevel
            // 
            this.numMinLevel.Location = new System.Drawing.Point(102, 103);
            this.numMinLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinLevel.Name = "numMinLevel";
            this.numMinLevel.Size = new System.Drawing.Size(56, 30);
            this.numMinLevel.TabIndex = 6;
            this.numMinLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numMaxLevel
            // 
            this.numMaxLevel.Location = new System.Drawing.Point(196, 103);
            this.numMaxLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxLevel.Name = "numMaxLevel";
            this.numMaxLevel.Size = new System.Drawing.Size(56, 30);
            this.numMaxLevel.TabIndex = 7;
            this.numMaxLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numMaxEV
            // 
            this.numMaxEV.Location = new System.Drawing.Point(455, 54);
            this.numMaxEV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numMaxEV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxEV.Name = "numMaxEV";
            this.numMaxEV.Size = new System.Drawing.Size(56, 30);
            this.numMaxEV.TabIndex = 5;
            this.numMaxEV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numMinEV
            // 
            this.numMinEV.Location = new System.Drawing.Point(361, 54);
            this.numMinEV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numMinEV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinEV.Name = "numMinEV";
            this.numMinEV.Size = new System.Drawing.Size(56, 30);
            this.numMinEV.TabIndex = 4;
            this.numMinEV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmSearchPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 181);
            this.Controls.Add(this.numMinEV);
            this.Controls.Add(this.numMaxEV);
            this.Controls.Add(this.numMaxLevel);
            this.Controls.Add(this.numMinLevel);
            this.Controls.Add(this.numNumber);
            this.Controls.Add(this.slblPokerus);
            this.Controls.Add(this.chkHasPokerus);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.slblToEV);
            this.Controls.Add(this.slblEvTotal);
            this.Controls.Add(this.slblNickname);
            this.Controls.Add(this.slblToLevel);
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
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinEV)).EndInit();
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
        private System.Windows.Forms.Label slblToLevel;
        private System.Windows.Forms.Label slblEvTotal;
        private System.Windows.Forms.Label slblNickname;
        private System.Windows.Forms.Label slblToEV;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.CheckBox chkHasPokerus;
        private System.Windows.Forms.ToolTip ttpPokerus;
        private System.Windows.Forms.Label slblPokerus;
        private System.Windows.Forms.NumericUpDown numNumber;
        private System.Windows.Forms.NumericUpDown numMinLevel;
        private System.Windows.Forms.NumericUpDown numMaxLevel;
        private System.Windows.Forms.NumericUpDown numMaxEV;
        private System.Windows.Forms.NumericUpDown numMinEV;
    }
}