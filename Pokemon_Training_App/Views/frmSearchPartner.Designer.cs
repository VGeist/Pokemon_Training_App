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
            this.numMinLevel = new System.Windows.Forms.NumericUpDown();
            this.numMaxLevel = new System.Windows.Forms.NumericUpDown();
            this.numMaxEV = new System.Windows.Forms.NumericUpDown();
            this.numMinEV = new System.Windows.Forms.NumericUpDown();
            this.slblFilter = new System.Windows.Forms.Label();
            this.chkFilterNumber = new System.Windows.Forms.CheckBox();
            this.chkNatureFilter = new System.Windows.Forms.CheckBox();
            this.chkLevelFilter = new System.Windows.Forms.CheckBox();
            this.chkNicknameFilter = new System.Windows.Forms.CheckBox();
            this.chkEVFilter = new System.Windows.Forms.CheckBox();
            this.pokemonDataSet = new Pokemon_Training_App.Data.PokemonDataSet();
            this.naturesTableAdapter = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.NaturesTableAdapter();
            this.pokemonTableAdapter = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.PokemonTableAdapter();
            this.cmbNumber = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numMinLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // slblPokemonNum
            // 
            this.slblPokemonNum.AutoSize = true;
            this.slblPokemonNum.Location = new System.Drawing.Point(76, 38);
            this.slblPokemonNum.Name = "slblPokemonNum";
            this.slblPokemonNum.Size = new System.Drawing.Size(163, 22);
            this.slblPokemonNum.TabIndex = 0;
            this.slblPokemonNum.Text = "Pokemon Number:";
            // 
            // slblNature
            // 
            this.slblNature.AutoSize = true;
            this.slblNature.Location = new System.Drawing.Point(76, 86);
            this.slblNature.Name = "slblNature";
            this.slblNature.Size = new System.Drawing.Size(71, 22);
            this.slblNature.TabIndex = 1;
            this.slblNature.Text = "Nature:";
            // 
            // slblLevel
            // 
            this.slblLevel.AutoSize = true;
            this.slblLevel.Location = new System.Drawing.Point(76, 134);
            this.slblLevel.Name = "slblLevel";
            this.slblLevel.Size = new System.Drawing.Size(58, 22);
            this.slblLevel.TabIndex = 2;
            this.slblLevel.Text = "Level:";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(140, 273);
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
            this.btnCancel.Location = new System.Drawing.Point(231, 273);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbNature
            // 
            this.cmbNature.DataSource = this.pokemonDataSet;
            this.cmbNature.DisplayMember = "Natures.Name";
            this.cmbNature.FormattingEnabled = true;
            this.cmbNature.Location = new System.Drawing.Point(195, 83);
            this.cmbNature.Name = "cmbNature";
            this.cmbNature.Size = new System.Drawing.Size(121, 30);
            this.cmbNature.TabIndex = 3;
            this.cmbNature.ValueMember = "Natures.NatureID";
            // 
            // slblToLevel
            // 
            this.slblToLevel.AutoSize = true;
            this.slblToLevel.Location = new System.Drawing.Point(228, 134);
            this.slblToLevel.Name = "slblToLevel";
            this.slblToLevel.Size = new System.Drawing.Size(26, 22);
            this.slblToLevel.TabIndex = 9;
            this.slblToLevel.Text = "to";
            // 
            // slblEvTotal
            // 
            this.slblEvTotal.AutoSize = true;
            this.slblEvTotal.Location = new System.Drawing.Point(76, 230);
            this.slblEvTotal.Name = "slblEvTotal";
            this.slblEvTotal.Size = new System.Drawing.Size(80, 22);
            this.slblEvTotal.TabIndex = 11;
            this.slblEvTotal.Text = "EV Total:";
            // 
            // slblNickname
            // 
            this.slblNickname.AutoSize = true;
            this.slblNickname.Location = new System.Drawing.Point(76, 182);
            this.slblNickname.Name = "slblNickname";
            this.slblNickname.Size = new System.Drawing.Size(96, 22);
            this.slblNickname.TabIndex = 10;
            this.slblNickname.Text = "Nickname:";
            // 
            // slblToEV
            // 
            this.slblToEV.AutoSize = true;
            this.slblToEV.Location = new System.Drawing.Point(228, 231);
            this.slblToEV.Name = "slblToEV";
            this.slblToEV.Size = new System.Drawing.Size(26, 22);
            this.slblToEV.TabIndex = 18;
            this.slblToEV.Text = "to";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(187, 179);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(129, 30);
            this.txtNickname.TabIndex = 2;
            // 
            // ttpPokerus
            // 
            this.ttpPokerus.ToolTipTitle = "Pokerus";
            // 
            // numMinLevel
            // 
            this.numMinLevel.Location = new System.Drawing.Point(166, 132);
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
            this.numMaxLevel.Location = new System.Drawing.Point(260, 132);
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
            this.numMaxEV.Location = new System.Drawing.Point(260, 228);
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
            this.numMinEV.Location = new System.Drawing.Point(166, 228);
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
            // slblFilter
            // 
            this.slblFilter.AutoSize = true;
            this.slblFilter.Location = new System.Drawing.Point(12, 9);
            this.slblFilter.Name = "slblFilter";
            this.slblFilter.Size = new System.Drawing.Size(53, 22);
            this.slblFilter.TabIndex = 19;
            this.slblFilter.Text = "Filter";
            // 
            // chkFilterNumber
            // 
            this.chkFilterNumber.AutoSize = true;
            this.chkFilterNumber.Location = new System.Drawing.Point(31, 42);
            this.chkFilterNumber.Name = "chkFilterNumber";
            this.chkFilterNumber.Size = new System.Drawing.Size(15, 14);
            this.chkFilterNumber.TabIndex = 20;
            this.chkFilterNumber.UseVisualStyleBackColor = true;
            // 
            // chkNatureFilter
            // 
            this.chkNatureFilter.AutoSize = true;
            this.chkNatureFilter.Location = new System.Drawing.Point(31, 91);
            this.chkNatureFilter.Name = "chkNatureFilter";
            this.chkNatureFilter.Size = new System.Drawing.Size(15, 14);
            this.chkNatureFilter.TabIndex = 21;
            this.chkNatureFilter.UseVisualStyleBackColor = true;
            // 
            // chkLevelFilter
            // 
            this.chkLevelFilter.AutoSize = true;
            this.chkLevelFilter.Location = new System.Drawing.Point(31, 139);
            this.chkLevelFilter.Name = "chkLevelFilter";
            this.chkLevelFilter.Size = new System.Drawing.Size(15, 14);
            this.chkLevelFilter.TabIndex = 22;
            this.chkLevelFilter.UseVisualStyleBackColor = true;
            // 
            // chkNicknameFilter
            // 
            this.chkNicknameFilter.AutoSize = true;
            this.chkNicknameFilter.Location = new System.Drawing.Point(31, 187);
            this.chkNicknameFilter.Name = "chkNicknameFilter";
            this.chkNicknameFilter.Size = new System.Drawing.Size(15, 14);
            this.chkNicknameFilter.TabIndex = 23;
            this.chkNicknameFilter.UseVisualStyleBackColor = true;
            // 
            // chkEVFilter
            // 
            this.chkEVFilter.AutoSize = true;
            this.chkEVFilter.Location = new System.Drawing.Point(31, 235);
            this.chkEVFilter.Name = "chkEVFilter";
            this.chkEVFilter.Size = new System.Drawing.Size(15, 14);
            this.chkEVFilter.TabIndex = 24;
            this.chkEVFilter.UseVisualStyleBackColor = true;
            // 
            // pokemonDataSet
            // 
            this.pokemonDataSet.DataSetName = "PokemonDataSet";
            this.pokemonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // naturesTableAdapter
            // 
            this.naturesTableAdapter.ClearBeforeFill = true;
            // 
            // pokemonTableAdapter
            // 
            this.pokemonTableAdapter.ClearBeforeFill = true;
            // 
            // cmbNumber
            // 
            this.cmbNumber.DataSource = this.pokemonDataSet;
            this.cmbNumber.DisplayMember = "Pokemon.PokeNum";
            this.cmbNumber.FormattingEnabled = true;
            this.cmbNumber.Location = new System.Drawing.Point(260, 36);
            this.cmbNumber.Name = "cmbNumber";
            this.cmbNumber.Size = new System.Drawing.Size(56, 30);
            this.cmbNumber.TabIndex = 25;
            this.cmbNumber.ValueMember = "Pokemon.PokeNum";
            // 
            // frmSearchPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 319);
            this.Controls.Add(this.cmbNumber);
            this.Controls.Add(this.chkEVFilter);
            this.Controls.Add(this.chkNicknameFilter);
            this.Controls.Add(this.chkLevelFilter);
            this.Controls.Add(this.chkNatureFilter);
            this.Controls.Add(this.chkFilterNumber);
            this.Controls.Add(this.slblFilter);
            this.Controls.Add(this.numMinEV);
            this.Controls.Add(this.numMaxEV);
            this.Controls.Add(this.numMaxLevel);
            this.Controls.Add(this.numMinLevel);
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
            this.Load += new System.EventHandler(this.frmSearchPartner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMinLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).EndInit();
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
        private System.Windows.Forms.ToolTip ttpPokerus;
        private System.Windows.Forms.NumericUpDown numMinLevel;
        private System.Windows.Forms.NumericUpDown numMaxLevel;
        private System.Windows.Forms.NumericUpDown numMaxEV;
        private System.Windows.Forms.NumericUpDown numMinEV;
        private System.Windows.Forms.Label slblFilter;
        private System.Windows.Forms.CheckBox chkFilterNumber;
        private System.Windows.Forms.CheckBox chkNatureFilter;
        private System.Windows.Forms.CheckBox chkLevelFilter;
        private System.Windows.Forms.CheckBox chkNicknameFilter;
        private System.Windows.Forms.CheckBox chkEVFilter;
        private Data.PokemonDataSet pokemonDataSet;
        private Data.PokemonDataSetTableAdapters.NaturesTableAdapter naturesTableAdapter;
        private Data.PokemonDataSetTableAdapters.PokemonTableAdapter pokemonTableAdapter;
        private System.Windows.Forms.ComboBox cmbNumber;
    }
}