namespace Pokemon_Training_App.Views
{
    partial class frmEditPartner
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
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokemonDataSet = new Pokemon_Training_App.Data.PokemonDataSet();
            this.slblLevel = new System.Windows.Forms.Label();
            this.slblNickname = new System.Windows.Forms.Label();
            this.slblPokemonNum = new System.Windows.Forms.Label();
            this.btnAddForm = new System.Windows.Forms.Button();
            this.cmbForm = new System.Windows.Forms.ComboBox();
            this.formsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokemonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slblForm = new System.Windows.Forms.Label();
            this.cmbNature = new System.Windows.Forms.ComboBox();
            this.naturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slblNature = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.ttpPokerus = new System.Windows.Forms.ToolTip(this.components);
            this.chkHasPokerus = new System.Windows.Forms.CheckBox();
            this.numLevel = new System.Windows.Forms.NumericUpDown();
            this.numSpeedStat = new System.Windows.Forms.NumericUpDown();
            this.numSpDefenseStat = new System.Windows.Forms.NumericUpDown();
            this.numSpAttackStat = new System.Windows.Forms.NumericUpDown();
            this.numDefenseStat = new System.Windows.Forms.NumericUpDown();
            this.numAttackStat = new System.Windows.Forms.NumericUpDown();
            this.numHealthStat = new System.Windows.Forms.NumericUpDown();
            this.tabStats = new System.Windows.Forms.TabControl();
            this.tpgStats = new System.Windows.Forms.TabPage();
            this.slblHealthStat = new System.Windows.Forms.Label();
            this.slblSpeedStat = new System.Windows.Forms.Label();
            this.slblSpDefenseStat = new System.Windows.Forms.Label();
            this.slblSpAttackStat = new System.Windows.Forms.Label();
            this.slblDefenseStat = new System.Windows.Forms.Label();
            this.slblAttackStat = new System.Windows.Forms.Label();
            this.tpgEV = new System.Windows.Forms.TabPage();
            this.numSpeedEV = new System.Windows.Forms.NumericUpDown();
            this.numSpDefenseEV = new System.Windows.Forms.NumericUpDown();
            this.numSpAttackEV = new System.Windows.Forms.NumericUpDown();
            this.numDefenseEV = new System.Windows.Forms.NumericUpDown();
            this.numAttackEV = new System.Windows.Forms.NumericUpDown();
            this.numHealthEV = new System.Windows.Forms.NumericUpDown();
            this.slblHealthEV = new System.Windows.Forms.Label();
            this.slblSpeedEV = new System.Windows.Forms.Label();
            this.slblSpDefenseEV = new System.Windows.Forms.Label();
            this.slblSpAttackEV = new System.Windows.Forms.Label();
            this.slblDefenseEV = new System.Windows.Forms.Label();
            this.slblAttackEV = new System.Windows.Forms.Label();
            this.cmbPokeNum = new System.Windows.Forms.ComboBox();
            this.partnersTableAdapter = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.PartnersTableAdapter();
            this.tableAdapterManager = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.TableAdapterManager();
            this.pokemonTableAdapter = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.PokemonTableAdapter();
            this.formsTableAdapter = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.FormsTableAdapter();
            this.naturesTableAdapter = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.NaturesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpDefenseStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpAttackStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefenseStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHealthStat)).BeginInit();
            this.tabStats.SuspendLayout();
            this.tpgStats.SuspendLayout();
            this.tpgEV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpDefenseEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpAttackEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefenseEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHealthEV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNickname
            // 
            this.txtNickname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnersBindingSource, "Nickname", true));
            this.txtNickname.Location = new System.Drawing.Point(185, 53);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(180, 30);
            this.txtNickname.TabIndex = 2;
            // 
            // partnersBindingSource
            // 
            this.partnersBindingSource.DataMember = "Partners";
            this.partnersBindingSource.DataSource = this.pokemonDataSet;
            // 
            // pokemonDataSet
            // 
            this.pokemonDataSet.DataSetName = "PokemonDataSet";
            this.pokemonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // slblLevel
            // 
            this.slblLevel.AutoSize = true;
            this.slblLevel.Location = new System.Drawing.Point(266, 95);
            this.slblLevel.Name = "slblLevel";
            this.slblLevel.Size = new System.Drawing.Size(53, 22);
            this.slblLevel.TabIndex = 19;
            this.slblLevel.Text = "Level";
            // 
            // slblNickname
            // 
            this.slblNickname.AutoSize = true;
            this.slblNickname.Location = new System.Drawing.Point(12, 53);
            this.slblNickname.Name = "slblNickname";
            this.slblNickname.Size = new System.Drawing.Size(91, 22);
            this.slblNickname.TabIndex = 17;
            this.slblNickname.Text = "Nickname";
            // 
            // slblPokemonNum
            // 
            this.slblPokemonNum.AutoSize = true;
            this.slblPokemonNum.Location = new System.Drawing.Point(12, 15);
            this.slblPokemonNum.Name = "slblPokemonNum";
            this.slblPokemonNum.Size = new System.Drawing.Size(158, 22);
            this.slblPokemonNum.TabIndex = 16;
            this.slblPokemonNum.Text = "Pokemon Number";
            // 
            // btnAddForm
            // 
            this.btnAddForm.AutoSize = true;
            this.btnAddForm.Location = new System.Drawing.Point(264, 135);
            this.btnAddForm.Name = "btnAddForm";
            this.btnAddForm.Size = new System.Drawing.Size(101, 32);
            this.btnAddForm.TabIndex = 6;
            this.btnAddForm.Text = "Add Form";
            this.btnAddForm.UseVisualStyleBackColor = true;
            // 
            // cmbForm
            // 
            this.cmbForm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formsBindingSource, "Name", true));
            this.cmbForm.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partnersBindingSource, "FormID", true));
            this.cmbForm.DataSource = this.pokemonDataSet;
            this.cmbForm.DisplayMember = "Pokemon.FK__Forms__PokeNum__300424B4.Name";
            this.cmbForm.FormattingEnabled = true;
            this.cmbForm.ItemHeight = 22;
            this.cmbForm.Location = new System.Drawing.Point(84, 136);
            this.cmbForm.MaxDropDownItems = 32;
            this.cmbForm.Name = "cmbForm";
            this.cmbForm.Size = new System.Drawing.Size(159, 30);
            this.cmbForm.TabIndex = 5;
            this.cmbForm.ValueMember = "Forms.FormID";
            // 
            // formsBindingSource
            // 
            this.formsBindingSource.DataMember = "FK__Forms__PokeNum__300424B4";
            this.formsBindingSource.DataSource = this.pokemonBindingSource;
            // 
            // pokemonBindingSource
            // 
            this.pokemonBindingSource.DataMember = "Pokemon";
            this.pokemonBindingSource.DataSource = this.pokemonDataSet;
            // 
            // slblForm
            // 
            this.slblForm.AutoSize = true;
            this.slblForm.Location = new System.Drawing.Point(12, 139);
            this.slblForm.Name = "slblForm";
            this.slblForm.Size = new System.Drawing.Size(53, 22);
            this.slblForm.TabIndex = 29;
            this.slblForm.Text = "Form";
            // 
            // cmbNature
            // 
            this.cmbNature.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.naturesBindingSource, "Name", true));
            this.cmbNature.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partnersBindingSource, "NatureID", true));
            this.cmbNature.DataSource = this.pokemonDataSet;
            this.cmbNature.DisplayMember = "Natures.Name";
            this.cmbNature.FormattingEnabled = true;
            this.cmbNature.Location = new System.Drawing.Point(84, 93);
            this.cmbNature.MaxDropDownItems = 32;
            this.cmbNature.Name = "cmbNature";
            this.cmbNature.Size = new System.Drawing.Size(159, 30);
            this.cmbNature.TabIndex = 3;
            this.cmbNature.ValueMember = "Natures.NatureID";
            // 
            // naturesBindingSource
            // 
            this.naturesBindingSource.DataMember = "Natures";
            this.naturesBindingSource.DataSource = this.pokemonDataSet;
            // 
            // slblNature
            // 
            this.slblNature.AutoSize = true;
            this.slblNature.Location = new System.Drawing.Point(12, 96);
            this.slblNature.Name = "slblNature";
            this.slblNature.Size = new System.Drawing.Size(66, 22);
            this.slblNature.TabIndex = 26;
            this.slblNature.Text = "Nature";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(292, 387);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 32);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Location = new System.Drawing.Point(292, 349);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 32);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.Location = new System.Drawing.Point(292, 311);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(91, 32);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ttpPokerus
            // 
            this.ttpPokerus.ToolTipTitle = "Pokerus";
            // 
            // chkHasPokerus
            // 
            this.chkHasPokerus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chkHasPokerus.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.partnersBindingSource, "HasPokerus", true));
            this.chkHasPokerus.Image = global::Pokemon_Training_App.Properties.Resources.PokérusIC_infected;
            this.chkHasPokerus.Location = new System.Drawing.Point(301, 204);
            this.chkHasPokerus.Name = "chkHasPokerus";
            this.chkHasPokerus.Size = new System.Drawing.Size(73, 51);
            this.chkHasPokerus.TabIndex = 13;
            this.ttpPokerus.SetToolTip(this.chkHasPokerus, "Check if pokemon has (or had) Pokerus.");
            this.chkHasPokerus.UseVisualStyleBackColor = true;
            // 
            // numLevel
            // 
            this.numLevel.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partnersBindingSource, "Level", true));
            this.numLevel.Location = new System.Drawing.Point(325, 94);
            this.numLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLevel.Name = "numLevel";
            this.numLevel.Size = new System.Drawing.Size(58, 30);
            this.numLevel.TabIndex = 4;
            this.numLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numSpeedStat
            // 
            this.numSpeedStat.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partnersBindingSource, "Speed", true));
            this.numSpeedStat.Location = new System.Drawing.Point(142, 175);
            this.numSpeedStat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSpeedStat.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numSpeedStat.Name = "numSpeedStat";
            this.numSpeedStat.Size = new System.Drawing.Size(100, 30);
            this.numSpeedStat.TabIndex = 12;
            this.numSpeedStat.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numSpDefenseStat
            // 
            this.numSpDefenseStat.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partnersBindingSource, "SpDefense", true));
            this.numSpDefenseStat.Location = new System.Drawing.Point(142, 142);
            this.numSpDefenseStat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSpDefenseStat.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numSpDefenseStat.Name = "numSpDefenseStat";
            this.numSpDefenseStat.Size = new System.Drawing.Size(100, 30);
            this.numSpDefenseStat.TabIndex = 11;
            this.numSpDefenseStat.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numSpAttackStat
            // 
            this.numSpAttackStat.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partnersBindingSource, "SpAttack", true));
            this.numSpAttackStat.Location = new System.Drawing.Point(142, 109);
            this.numSpAttackStat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSpAttackStat.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numSpAttackStat.Name = "numSpAttackStat";
            this.numSpAttackStat.Size = new System.Drawing.Size(100, 30);
            this.numSpAttackStat.TabIndex = 10;
            this.numSpAttackStat.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numDefenseStat
            // 
            this.numDefenseStat.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partnersBindingSource, "Defense", true));
            this.numDefenseStat.Location = new System.Drawing.Point(142, 76);
            this.numDefenseStat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDefenseStat.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numDefenseStat.Name = "numDefenseStat";
            this.numDefenseStat.Size = new System.Drawing.Size(100, 30);
            this.numDefenseStat.TabIndex = 9;
            this.numDefenseStat.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numAttackStat
            // 
            this.numAttackStat.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partnersBindingSource, "Attack", true));
            this.numAttackStat.Location = new System.Drawing.Point(142, 43);
            this.numAttackStat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAttackStat.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numAttackStat.Name = "numAttackStat";
            this.numAttackStat.Size = new System.Drawing.Size(100, 30);
            this.numAttackStat.TabIndex = 8;
            this.numAttackStat.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numHealthStat
            // 
            this.numHealthStat.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partnersBindingSource, "Health", true));
            this.numHealthStat.Location = new System.Drawing.Point(142, 10);
            this.numHealthStat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHealthStat.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numHealthStat.Name = "numHealthStat";
            this.numHealthStat.Size = new System.Drawing.Size(100, 30);
            this.numHealthStat.TabIndex = 7;
            this.numHealthStat.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // tabStats
            // 
            this.tabStats.Controls.Add(this.tpgStats);
            this.tabStats.Controls.Add(this.tpgEV);
            this.tabStats.Location = new System.Drawing.Point(16, 175);
            this.tabStats.Name = "tabStats";
            this.tabStats.SelectedIndex = 0;
            this.tabStats.Size = new System.Drawing.Size(258, 248);
            this.tabStats.TabIndex = 31;
            this.tabStats.TabStop = false;
            // 
            // tpgStats
            // 
            this.tpgStats.Controls.Add(this.numSpeedStat);
            this.tpgStats.Controls.Add(this.numSpDefenseStat);
            this.tpgStats.Controls.Add(this.numSpAttackStat);
            this.tpgStats.Controls.Add(this.numDefenseStat);
            this.tpgStats.Controls.Add(this.numAttackStat);
            this.tpgStats.Controls.Add(this.numHealthStat);
            this.tpgStats.Controls.Add(this.slblHealthStat);
            this.tpgStats.Controls.Add(this.slblSpeedStat);
            this.tpgStats.Controls.Add(this.slblSpDefenseStat);
            this.tpgStats.Controls.Add(this.slblSpAttackStat);
            this.tpgStats.Controls.Add(this.slblDefenseStat);
            this.tpgStats.Controls.Add(this.slblAttackStat);
            this.tpgStats.Location = new System.Drawing.Point(4, 31);
            this.tpgStats.Name = "tpgStats";
            this.tpgStats.Padding = new System.Windows.Forms.Padding(3);
            this.tpgStats.Size = new System.Drawing.Size(250, 213);
            this.tpgStats.TabIndex = 0;
            this.tpgStats.Text = "Stats";
            this.tpgStats.UseVisualStyleBackColor = true;
            // 
            // slblHealthStat
            // 
            this.slblHealthStat.AutoSize = true;
            this.slblHealthStat.Location = new System.Drawing.Point(8, 12);
            this.slblHealthStat.Name = "slblHealthStat";
            this.slblHealthStat.Size = new System.Drawing.Size(62, 22);
            this.slblHealthStat.TabIndex = 10;
            this.slblHealthStat.Text = "Health";
            // 
            // slblSpeedStat
            // 
            this.slblSpeedStat.AutoSize = true;
            this.slblSpeedStat.Location = new System.Drawing.Point(8, 177);
            this.slblSpeedStat.Name = "slblSpeedStat";
            this.slblSpeedStat.Size = new System.Drawing.Size(59, 22);
            this.slblSpeedStat.TabIndex = 4;
            this.slblSpeedStat.Text = "Speed";
            // 
            // slblSpDefenseStat
            // 
            this.slblSpDefenseStat.AutoSize = true;
            this.slblSpDefenseStat.Location = new System.Drawing.Point(8, 144);
            this.slblSpDefenseStat.Name = "slblSpDefenseStat";
            this.slblSpDefenseStat.Size = new System.Drawing.Size(95, 22);
            this.slblSpDefenseStat.TabIndex = 3;
            this.slblSpDefenseStat.Text = "SpDefense";
            // 
            // slblSpAttackStat
            // 
            this.slblSpAttackStat.AutoSize = true;
            this.slblSpAttackStat.Location = new System.Drawing.Point(8, 111);
            this.slblSpAttackStat.Name = "slblSpAttackStat";
            this.slblSpAttackStat.Size = new System.Drawing.Size(81, 22);
            this.slblSpAttackStat.TabIndex = 2;
            this.slblSpAttackStat.Text = "SpAttack";
            // 
            // slblDefenseStat
            // 
            this.slblDefenseStat.AutoSize = true;
            this.slblDefenseStat.Location = new System.Drawing.Point(8, 78);
            this.slblDefenseStat.Name = "slblDefenseStat";
            this.slblDefenseStat.Size = new System.Drawing.Size(75, 22);
            this.slblDefenseStat.TabIndex = 1;
            this.slblDefenseStat.Text = "Defense";
            // 
            // slblAttackStat
            // 
            this.slblAttackStat.AutoSize = true;
            this.slblAttackStat.Location = new System.Drawing.Point(8, 45);
            this.slblAttackStat.Name = "slblAttackStat";
            this.slblAttackStat.Size = new System.Drawing.Size(61, 22);
            this.slblAttackStat.TabIndex = 0;
            this.slblAttackStat.Text = "Attack";
            // 
            // tpgEV
            // 
            this.tpgEV.Controls.Add(this.numSpeedEV);
            this.tpgEV.Controls.Add(this.numSpDefenseEV);
            this.tpgEV.Controls.Add(this.numSpAttackEV);
            this.tpgEV.Controls.Add(this.numDefenseEV);
            this.tpgEV.Controls.Add(this.numAttackEV);
            this.tpgEV.Controls.Add(this.numHealthEV);
            this.tpgEV.Controls.Add(this.slblHealthEV);
            this.tpgEV.Controls.Add(this.slblSpeedEV);
            this.tpgEV.Controls.Add(this.slblSpDefenseEV);
            this.tpgEV.Controls.Add(this.slblSpAttackEV);
            this.tpgEV.Controls.Add(this.slblDefenseEV);
            this.tpgEV.Controls.Add(this.slblAttackEV);
            this.tpgEV.Location = new System.Drawing.Point(4, 31);
            this.tpgEV.Name = "tpgEV";
            this.tpgEV.Padding = new System.Windows.Forms.Padding(3);
            this.tpgEV.Size = new System.Drawing.Size(250, 213);
            this.tpgEV.TabIndex = 1;
            this.tpgEV.Text = "EVs";
            this.tpgEV.UseVisualStyleBackColor = true;
            // 
            // numSpeedEV
            // 
            this.numSpeedEV.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partnersBindingSource, "EVSpeed", true));
            this.numSpeedEV.Location = new System.Drawing.Point(142, 175);
            this.numSpeedEV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSpeedEV.Name = "numSpeedEV";
            this.numSpeedEV.Size = new System.Drawing.Size(100, 30);
            this.numSpeedEV.TabIndex = 27;
            // 
            // numSpDefenseEV
            // 
            this.numSpDefenseEV.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partnersBindingSource, "EVSpDefense", true));
            this.numSpDefenseEV.Location = new System.Drawing.Point(142, 142);
            this.numSpDefenseEV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSpDefenseEV.Name = "numSpDefenseEV";
            this.numSpDefenseEV.Size = new System.Drawing.Size(100, 30);
            this.numSpDefenseEV.TabIndex = 26;
            // 
            // numSpAttackEV
            // 
            this.numSpAttackEV.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partnersBindingSource, "EVSpAttack", true));
            this.numSpAttackEV.Location = new System.Drawing.Point(142, 109);
            this.numSpAttackEV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSpAttackEV.Name = "numSpAttackEV";
            this.numSpAttackEV.Size = new System.Drawing.Size(100, 30);
            this.numSpAttackEV.TabIndex = 25;
            // 
            // numDefenseEV
            // 
            this.numDefenseEV.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partnersBindingSource, "EVDefense", true));
            this.numDefenseEV.Location = new System.Drawing.Point(142, 76);
            this.numDefenseEV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numDefenseEV.Name = "numDefenseEV";
            this.numDefenseEV.Size = new System.Drawing.Size(100, 30);
            this.numDefenseEV.TabIndex = 24;
            // 
            // numAttackEV
            // 
            this.numAttackEV.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partnersBindingSource, "EVAttack", true));
            this.numAttackEV.Location = new System.Drawing.Point(142, 43);
            this.numAttackEV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numAttackEV.Name = "numAttackEV";
            this.numAttackEV.Size = new System.Drawing.Size(100, 30);
            this.numAttackEV.TabIndex = 23;
            // 
            // numHealthEV
            // 
            this.numHealthEV.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partnersBindingSource, "EVHealth", true));
            this.numHealthEV.Location = new System.Drawing.Point(142, 10);
            this.numHealthEV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numHealthEV.Name = "numHealthEV";
            this.numHealthEV.Size = new System.Drawing.Size(100, 30);
            this.numHealthEV.TabIndex = 22;
            // 
            // slblHealthEV
            // 
            this.slblHealthEV.AutoSize = true;
            this.slblHealthEV.Location = new System.Drawing.Point(8, 12);
            this.slblHealthEV.Name = "slblHealthEV";
            this.slblHealthEV.Size = new System.Drawing.Size(62, 22);
            this.slblHealthEV.TabIndex = 22;
            this.slblHealthEV.Text = "Health";
            // 
            // slblSpeedEV
            // 
            this.slblSpeedEV.AutoSize = true;
            this.slblSpeedEV.Location = new System.Drawing.Point(8, 177);
            this.slblSpeedEV.Name = "slblSpeedEV";
            this.slblSpeedEV.Size = new System.Drawing.Size(59, 22);
            this.slblSpeedEV.TabIndex = 16;
            this.slblSpeedEV.Text = "Speed";
            // 
            // slblSpDefenseEV
            // 
            this.slblSpDefenseEV.AutoSize = true;
            this.slblSpDefenseEV.Location = new System.Drawing.Point(8, 144);
            this.slblSpDefenseEV.Name = "slblSpDefenseEV";
            this.slblSpDefenseEV.Size = new System.Drawing.Size(95, 22);
            this.slblSpDefenseEV.TabIndex = 15;
            this.slblSpDefenseEV.Text = "SpDefense";
            // 
            // slblSpAttackEV
            // 
            this.slblSpAttackEV.AutoSize = true;
            this.slblSpAttackEV.Location = new System.Drawing.Point(8, 111);
            this.slblSpAttackEV.Name = "slblSpAttackEV";
            this.slblSpAttackEV.Size = new System.Drawing.Size(81, 22);
            this.slblSpAttackEV.TabIndex = 14;
            this.slblSpAttackEV.Text = "SpAttack";
            // 
            // slblDefenseEV
            // 
            this.slblDefenseEV.AutoSize = true;
            this.slblDefenseEV.Location = new System.Drawing.Point(8, 78);
            this.slblDefenseEV.Name = "slblDefenseEV";
            this.slblDefenseEV.Size = new System.Drawing.Size(75, 22);
            this.slblDefenseEV.TabIndex = 13;
            this.slblDefenseEV.Text = "Defense";
            // 
            // slblAttackEV
            // 
            this.slblAttackEV.AutoSize = true;
            this.slblAttackEV.Location = new System.Drawing.Point(8, 45);
            this.slblAttackEV.Name = "slblAttackEV";
            this.slblAttackEV.Size = new System.Drawing.Size(61, 22);
            this.slblAttackEV.TabIndex = 12;
            this.slblAttackEV.Text = "Attack";
            // 
            // cmbPokeNum
            // 
            this.cmbPokeNum.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partnersBindingSource, "PokeNum", true));
            this.cmbPokeNum.DataSource = this.pokemonDataSet;
            this.cmbPokeNum.DisplayMember = "Pokemon.PokeNum";
            this.cmbPokeNum.FormattingEnabled = true;
            this.cmbPokeNum.Location = new System.Drawing.Point(185, 12);
            this.cmbPokeNum.Name = "cmbPokeNum";
            this.cmbPokeNum.Size = new System.Drawing.Size(180, 30);
            this.cmbPokeNum.TabIndex = 32;
            this.cmbPokeNum.ValueMember = "Pokemon.PokeNum";
            // 
            // partnersTableAdapter
            // 
            this.partnersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FormsTableAdapter = null;
            this.tableAdapterManager.NaturesTableAdapter = null;
            this.tableAdapterManager.PokemonTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Pokemon_Training_App.Data.PokemonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pokemonTableAdapter
            // 
            this.pokemonTableAdapter.ClearBeforeFill = true;
            // 
            // formsTableAdapter
            // 
            this.formsTableAdapter.ClearBeforeFill = true;
            // 
            // naturesTableAdapter
            // 
            this.naturesTableAdapter.ClearBeforeFill = true;
            // 
            // frmEditPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 428);
            this.Controls.Add(this.cmbPokeNum);
            this.Controls.Add(this.tabStats);
            this.Controls.Add(this.numLevel);
            this.Controls.Add(this.chkHasPokerus);
            this.Controls.Add(this.btnAddForm);
            this.Controls.Add(this.cmbForm);
            this.Controls.Add(this.slblForm);
            this.Controls.Add(this.cmbNature);
            this.Controls.Add(this.slblNature);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.slblLevel);
            this.Controls.Add(this.slblNickname);
            this.Controls.Add(this.slblPokemonNum);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmEditPartner";
            this.Text = "Edit Partner Entry";
            this.Load += new System.EventHandler(this.frmEditPartner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpDefenseStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpAttackStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefenseStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHealthStat)).EndInit();
            this.tabStats.ResumeLayout(false);
            this.tpgStats.ResumeLayout(false);
            this.tpgStats.PerformLayout();
            this.tpgEV.ResumeLayout(false);
            this.tpgEV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpDefenseEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpAttackEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefenseEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHealthEV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label slblLevel;
        private System.Windows.Forms.Label slblNickname;
        private System.Windows.Forms.Label slblPokemonNum;
        private System.Windows.Forms.Button btnAddForm;
        private System.Windows.Forms.ComboBox cmbForm;
        private System.Windows.Forms.Label slblForm;
        private System.Windows.Forms.ComboBox cmbNature;
        private System.Windows.Forms.Label slblNature;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.CheckBox chkHasPokerus;
        private System.Windows.Forms.ToolTip ttpPokerus;
        private System.Windows.Forms.NumericUpDown numLevel;
        private System.Windows.Forms.NumericUpDown numSpeedStat;
        private System.Windows.Forms.NumericUpDown numSpDefenseStat;
        private System.Windows.Forms.NumericUpDown numSpAttackStat;
        private System.Windows.Forms.NumericUpDown numDefenseStat;
        private System.Windows.Forms.NumericUpDown numAttackStat;
        private System.Windows.Forms.NumericUpDown numHealthStat;
        private System.Windows.Forms.TabControl tabStats;
        private System.Windows.Forms.TabPage tpgStats;
        private System.Windows.Forms.Label slblHealthStat;
        private System.Windows.Forms.Label slblSpeedStat;
        private System.Windows.Forms.Label slblSpDefenseStat;
        private System.Windows.Forms.Label slblSpAttackStat;
        private System.Windows.Forms.Label slblDefenseStat;
        private System.Windows.Forms.Label slblAttackStat;
        private System.Windows.Forms.TabPage tpgEV;
        private System.Windows.Forms.NumericUpDown numSpeedEV;
        private System.Windows.Forms.NumericUpDown numSpDefenseEV;
        private System.Windows.Forms.NumericUpDown numSpAttackEV;
        private System.Windows.Forms.NumericUpDown numDefenseEV;
        private System.Windows.Forms.NumericUpDown numAttackEV;
        private System.Windows.Forms.NumericUpDown numHealthEV;
        private System.Windows.Forms.Label slblHealthEV;
        private System.Windows.Forms.Label slblSpeedEV;
        private System.Windows.Forms.Label slblSpDefenseEV;
        private System.Windows.Forms.Label slblSpAttackEV;
        private System.Windows.Forms.Label slblDefenseEV;
        private System.Windows.Forms.Label slblAttackEV;
        private System.Windows.Forms.ComboBox cmbPokeNum;
        private Data.PokemonDataSet pokemonDataSet;
        private System.Windows.Forms.BindingSource partnersBindingSource;
        private Data.PokemonDataSetTableAdapters.PartnersTableAdapter partnersTableAdapter;
        private Data.PokemonDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource pokemonBindingSource;
        private Data.PokemonDataSetTableAdapters.PokemonTableAdapter pokemonTableAdapter;
        private System.Windows.Forms.BindingSource formsBindingSource;
        private Data.PokemonDataSetTableAdapters.FormsTableAdapter formsTableAdapter;
        private System.Windows.Forms.BindingSource naturesBindingSource;
        private Data.PokemonDataSetTableAdapters.NaturesTableAdapter naturesTableAdapter;
    }
}