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
            this.pokemonDataSet = new Pokemon_Training_App.Data.PokemonDataSet();
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
            this.chkFilterNature = new System.Windows.Forms.CheckBox();
            this.chkFilterLevel = new System.Windows.Forms.CheckBox();
            this.chkFilterNickname = new System.Windows.Forms.CheckBox();
            this.chkFilterEV = new System.Windows.Forms.CheckBox();
            this.naturesTableAdapter = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.NaturesTableAdapter();
            this.pokemonTableAdapter = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.PokemonTableAdapter();
            this.numPokeNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPokeNum)).BeginInit();
            this.SuspendLayout();
            // 
            // slblPokemonNum
            // 
            this.slblPokemonNum.AutoSize = true;
            this.slblPokemonNum.Location = new System.Drawing.Point(76, 38);
            this.slblPokemonNum.Name = "slblPokemonNum";
            this.slblPokemonNum.Size = new System.Drawing.Size(103, 22);
            this.slblPokemonNum.TabIndex = 0;
            this.slblPokemonNum.Text = "Pokemon #";
            // 
            // slblNature
            // 
            this.slblNature.AutoSize = true;
            this.slblNature.Location = new System.Drawing.Point(76, 135);
            this.slblNature.Name = "slblNature";
            this.slblNature.Size = new System.Drawing.Size(71, 22);
            this.slblNature.TabIndex = 1;
            this.slblNature.Text = "Nature:";
            // 
            // slblLevel
            // 
            this.slblLevel.AutoSize = true;
            this.slblLevel.Location = new System.Drawing.Point(76, 183);
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
            this.btnSearch.TabIndex = 8;
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
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbNature
            // 
            this.cmbNature.DataSource = this.pokemonDataSet;
            this.cmbNature.DisplayMember = "Natures.Name";
            this.cmbNature.FormattingEnabled = true;
            this.cmbNature.Location = new System.Drawing.Point(195, 131);
            this.cmbNature.Name = "cmbNature";
            this.cmbNature.Size = new System.Drawing.Size(121, 30);
            this.cmbNature.TabIndex = 3;
            this.cmbNature.ValueMember = "Natures.NatureID";
            // 
            // pokemonDataSet
            // 
            this.pokemonDataSet.DataSetName = "PokemonDataSet";
            this.pokemonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // slblToLevel
            // 
            this.slblToLevel.AutoSize = true;
            this.slblToLevel.Location = new System.Drawing.Point(228, 183);
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
            this.slblNickname.Location = new System.Drawing.Point(76, 87);
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
            this.txtNickname.Location = new System.Drawing.Point(187, 83);
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
            this.numMinLevel.Location = new System.Drawing.Point(166, 179);
            this.numMinLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinLevel.Name = "numMinLevel";
            this.numMinLevel.Size = new System.Drawing.Size(56, 30);
            this.numMinLevel.TabIndex = 4;
            this.numMinLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinLevel.ValueChanged += new System.EventHandler(this.numMinLevel_ValueChanged);
            // 
            // numMaxLevel
            // 
            this.numMaxLevel.Location = new System.Drawing.Point(260, 179);
            this.numMaxLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxLevel.Name = "numMaxLevel";
            this.numMaxLevel.Size = new System.Drawing.Size(56, 30);
            this.numMaxLevel.TabIndex = 5;
            this.numMaxLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxLevel.ValueChanged += new System.EventHandler(this.numMaxLevel_ValueChanged);
            // 
            // numMaxEV
            // 
            this.numMaxEV.Location = new System.Drawing.Point(260, 228);
            this.numMaxEV.Maximum = new decimal(new int[] {
            510,
            0,
            0,
            0});
            this.numMaxEV.Name = "numMaxEV";
            this.numMaxEV.Size = new System.Drawing.Size(56, 30);
            this.numMaxEV.TabIndex = 7;
            this.numMaxEV.ValueChanged += new System.EventHandler(this.numMaxEV_ValueChanged);
            // 
            // numMinEV
            // 
            this.numMinEV.Location = new System.Drawing.Point(166, 228);
            this.numMinEV.Maximum = new decimal(new int[] {
            510,
            0,
            0,
            0});
            this.numMinEV.Name = "numMinEV";
            this.numMinEV.Size = new System.Drawing.Size(56, 30);
            this.numMinEV.TabIndex = 6;
            this.numMinEV.ValueChanged += new System.EventHandler(this.numMinEV_ValueChanged);
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
            this.chkFilterNumber.TabStop = false;
            this.chkFilterNumber.UseVisualStyleBackColor = true;
            // 
            // chkFilterNature
            // 
            this.chkFilterNature.AutoSize = true;
            this.chkFilterNature.Location = new System.Drawing.Point(31, 139);
            this.chkFilterNature.Name = "chkFilterNature";
            this.chkFilterNature.Size = new System.Drawing.Size(15, 14);
            this.chkFilterNature.TabIndex = 21;
            this.chkFilterNature.TabStop = false;
            this.chkFilterNature.UseVisualStyleBackColor = true;
            // 
            // chkFilterLevel
            // 
            this.chkFilterLevel.AutoSize = true;
            this.chkFilterLevel.Location = new System.Drawing.Point(31, 187);
            this.chkFilterLevel.Name = "chkFilterLevel";
            this.chkFilterLevel.Size = new System.Drawing.Size(15, 14);
            this.chkFilterLevel.TabIndex = 22;
            this.chkFilterLevel.TabStop = false;
            this.chkFilterLevel.UseVisualStyleBackColor = true;
            // 
            // chkFilterNickname
            // 
            this.chkFilterNickname.AutoSize = true;
            this.chkFilterNickname.Location = new System.Drawing.Point(31, 91);
            this.chkFilterNickname.Name = "chkFilterNickname";
            this.chkFilterNickname.Size = new System.Drawing.Size(15, 14);
            this.chkFilterNickname.TabIndex = 23;
            this.chkFilterNickname.TabStop = false;
            this.chkFilterNickname.UseVisualStyleBackColor = true;
            // 
            // chkFilterEV
            // 
            this.chkFilterEV.AutoSize = true;
            this.chkFilterEV.Location = new System.Drawing.Point(31, 235);
            this.chkFilterEV.Name = "chkFilterEV";
            this.chkFilterEV.Size = new System.Drawing.Size(15, 14);
            this.chkFilterEV.TabIndex = 24;
            this.chkFilterEV.TabStop = false;
            this.chkFilterEV.UseVisualStyleBackColor = true;
            // 
            // naturesTableAdapter
            // 
            this.naturesTableAdapter.ClearBeforeFill = true;
            // 
            // pokemonTableAdapter
            // 
            this.pokemonTableAdapter.ClearBeforeFill = true;
            // 
            // numPokeNum
            // 
            this.numPokeNum.Location = new System.Drawing.Point(231, 36);
            this.numPokeNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPokeNum.Name = "numPokeNum";
            this.numPokeNum.Size = new System.Drawing.Size(85, 30);
            this.numPokeNum.TabIndex = 25;
            // 
            // frmSearchPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 319);
            this.Controls.Add(this.numPokeNum);
            this.Controls.Add(this.chkFilterEV);
            this.Controls.Add(this.chkFilterNickname);
            this.Controls.Add(this.chkFilterLevel);
            this.Controls.Add(this.chkFilterNature);
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
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPokeNum)).EndInit();
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
        private System.Windows.Forms.CheckBox chkFilterNature;
        private System.Windows.Forms.CheckBox chkFilterLevel;
        private System.Windows.Forms.CheckBox chkFilterNickname;
        private System.Windows.Forms.CheckBox chkFilterEV;
        private Data.PokemonDataSet pokemonDataSet;
        private Data.PokemonDataSetTableAdapters.NaturesTableAdapter naturesTableAdapter;
        private Data.PokemonDataSetTableAdapters.PokemonTableAdapter pokemonTableAdapter;
        private System.Windows.Forms.NumericUpDown numPokeNum;
    }
}