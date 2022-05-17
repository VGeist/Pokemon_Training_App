namespace Pokemon_Training_App.Views
{
    partial class frmEvolveAndLevel
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.slblNumber = new System.Windows.Forms.Label();
            this.slblHealthStat = new System.Windows.Forms.Label();
            this.slblSpeedStat = new System.Windows.Forms.Label();
            this.slblSpDefenseStat = new System.Windows.Forms.Label();
            this.slblSpAttackStat = new System.Windows.Forms.Label();
            this.slblDefenseStat = new System.Windows.Forms.Label();
            this.slblAttackStat = new System.Windows.Forms.Label();
            this.numHealth = new System.Windows.Forms.NumericUpDown();
            this.numAttack = new System.Windows.Forms.NumericUpDown();
            this.numDefense = new System.Windows.Forms.NumericUpDown();
            this.numSpAttack = new System.Windows.Forms.NumericUpDown();
            this.numSpDefense = new System.Windows.Forms.NumericUpDown();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.cmbPokeNum = new System.Windows.Forms.ComboBox();
            this.pokemonDataSet = new Pokemon_Training_App.Data.PokemonDataSet();
            this.pokemonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokemonTableAdapter = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.PokemonTableAdapter();
            this.pokemonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbForm = new System.Windows.Forms.ComboBox();
            this.slblForm = new System.Windows.Forms.Label();
            this.formsTableAdapter = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.FormsTableAdapter();
            this.btnReset = new System.Windows.Forms.Button();
            this.numLevel = new System.Windows.Forms.NumericUpDown();
            this.slblLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(226, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.Location = new System.Drawing.Point(18, 355);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(87, 32);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // slblNumber
            // 
            this.slblNumber.AutoSize = true;
            this.slblNumber.Location = new System.Drawing.Point(12, 10);
            this.slblNumber.Name = "slblNumber";
            this.slblNumber.Size = new System.Drawing.Size(103, 22);
            this.slblNumber.TabIndex = 42;
            this.slblNumber.Text = "Pokemon #";
            // 
            // slblHealthStat
            // 
            this.slblHealthStat.AutoSize = true;
            this.slblHealthStat.Location = new System.Drawing.Point(12, 124);
            this.slblHealthStat.Name = "slblHealthStat";
            this.slblHealthStat.Size = new System.Drawing.Size(62, 22);
            this.slblHealthStat.TabIndex = 41;
            this.slblHealthStat.Text = "Health";
            // 
            // slblSpeedStat
            // 
            this.slblSpeedStat.AutoSize = true;
            this.slblSpeedStat.Location = new System.Drawing.Point(12, 314);
            this.slblSpeedStat.Name = "slblSpeedStat";
            this.slblSpeedStat.Size = new System.Drawing.Size(59, 22);
            this.slblSpeedStat.TabIndex = 40;
            this.slblSpeedStat.Text = "Speed";
            // 
            // slblSpDefenseStat
            // 
            this.slblSpDefenseStat.AutoSize = true;
            this.slblSpDefenseStat.Location = new System.Drawing.Point(12, 276);
            this.slblSpDefenseStat.Name = "slblSpDefenseStat";
            this.slblSpDefenseStat.Size = new System.Drawing.Size(95, 22);
            this.slblSpDefenseStat.TabIndex = 39;
            this.slblSpDefenseStat.Text = "SpDefense";
            // 
            // slblSpAttackStat
            // 
            this.slblSpAttackStat.AutoSize = true;
            this.slblSpAttackStat.Location = new System.Drawing.Point(12, 238);
            this.slblSpAttackStat.Name = "slblSpAttackStat";
            this.slblSpAttackStat.Size = new System.Drawing.Size(81, 22);
            this.slblSpAttackStat.TabIndex = 38;
            this.slblSpAttackStat.Text = "SpAttack";
            // 
            // slblDefenseStat
            // 
            this.slblDefenseStat.AutoSize = true;
            this.slblDefenseStat.Location = new System.Drawing.Point(12, 200);
            this.slblDefenseStat.Name = "slblDefenseStat";
            this.slblDefenseStat.Size = new System.Drawing.Size(75, 22);
            this.slblDefenseStat.TabIndex = 37;
            this.slblDefenseStat.Text = "Defense";
            // 
            // slblAttackStat
            // 
            this.slblAttackStat.AutoSize = true;
            this.slblAttackStat.Location = new System.Drawing.Point(12, 162);
            this.slblAttackStat.Name = "slblAttackStat";
            this.slblAttackStat.Size = new System.Drawing.Size(61, 22);
            this.slblAttackStat.TabIndex = 36;
            this.slblAttackStat.Text = "Attack";
            // 
            // numHealth
            // 
            this.numHealth.Location = new System.Drawing.Point(177, 122);
            this.numHealth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHealth.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numHealth.Name = "numHealth";
            this.numHealth.Size = new System.Drawing.Size(139, 30);
            this.numHealth.TabIndex = 2;
            this.numHealth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numAttack
            // 
            this.numAttack.Location = new System.Drawing.Point(177, 160);
            this.numAttack.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAttack.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numAttack.Name = "numAttack";
            this.numAttack.Size = new System.Drawing.Size(139, 30);
            this.numAttack.TabIndex = 3;
            this.numAttack.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numDefense
            // 
            this.numDefense.Location = new System.Drawing.Point(177, 198);
            this.numDefense.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDefense.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numDefense.Name = "numDefense";
            this.numDefense.Size = new System.Drawing.Size(139, 30);
            this.numDefense.TabIndex = 4;
            this.numDefense.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numSpAttack
            // 
            this.numSpAttack.Location = new System.Drawing.Point(177, 236);
            this.numSpAttack.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSpAttack.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numSpAttack.Name = "numSpAttack";
            this.numSpAttack.Size = new System.Drawing.Size(139, 30);
            this.numSpAttack.TabIndex = 5;
            this.numSpAttack.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numSpDefense
            // 
            this.numSpDefense.Location = new System.Drawing.Point(177, 274);
            this.numSpDefense.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSpDefense.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numSpDefense.Name = "numSpDefense";
            this.numSpDefense.Size = new System.Drawing.Size(139, 30);
            this.numSpDefense.TabIndex = 6;
            this.numSpDefense.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numSpeed
            // 
            this.numSpeed.Location = new System.Drawing.Point(177, 312);
            this.numSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSpeed.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(139, 30);
            this.numSpeed.TabIndex = 7;
            this.numSpeed.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // cmbPokeNum
            // 
            this.cmbPokeNum.BackColor = System.Drawing.SystemColors.Window;
            this.cmbPokeNum.DataSource = this.pokemonDataSet;
            this.cmbPokeNum.DisplayMember = "Pokemon.PokeNum";
            this.cmbPokeNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPokeNum.FormattingEnabled = true;
            this.cmbPokeNum.Location = new System.Drawing.Point(177, 7);
            this.cmbPokeNum.MaxDropDownItems = 32;
            this.cmbPokeNum.Name = "cmbPokeNum";
            this.cmbPokeNum.Size = new System.Drawing.Size(139, 30);
            this.cmbPokeNum.TabIndex = 43;
            this.cmbPokeNum.ValueMember = "Pokemon.PokeNum";
            // 
            // pokemonDataSet
            // 
            this.pokemonDataSet.DataSetName = "PokemonDataSet";
            this.pokemonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pokemonDataSetBindingSource
            // 
            this.pokemonDataSetBindingSource.DataSource = this.pokemonDataSet;
            this.pokemonDataSetBindingSource.Position = 0;
            // 
            // pokemonTableAdapter
            // 
            this.pokemonTableAdapter.ClearBeforeFill = true;
            // 
            // pokemonBindingSource
            // 
            this.pokemonBindingSource.DataMember = "Pokemon";
            this.pokemonBindingSource.DataSource = this.pokemonDataSet;
            // 
            // cmbForm
            // 
            this.cmbForm.BackColor = System.Drawing.SystemColors.Window;
            this.cmbForm.DataSource = this.pokemonDataSet;
            this.cmbForm.DisplayMember = "Pokemon.FK__Forms__PokeNum__300424B4.Name";
            this.cmbForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForm.FormattingEnabled = true;
            this.cmbForm.Location = new System.Drawing.Point(177, 45);
            this.cmbForm.MaxDropDownItems = 32;
            this.cmbForm.Name = "cmbForm";
            this.cmbForm.Size = new System.Drawing.Size(139, 30);
            this.cmbForm.TabIndex = 45;
            this.cmbForm.ValueMember = "Forms.FormID";
            // 
            // slblForm
            // 
            this.slblForm.AutoSize = true;
            this.slblForm.Location = new System.Drawing.Point(12, 48);
            this.slblForm.Name = "slblForm";
            this.slblForm.Size = new System.Drawing.Size(53, 22);
            this.slblForm.TabIndex = 44;
            this.slblForm.Text = "Form";
            // 
            // formsTableAdapter
            // 
            this.formsTableAdapter.ClearBeforeFill = true;
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Location = new System.Drawing.Point(122, 355);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 32);
            this.btnReset.TabIndex = 46;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // numLevel
            // 
            this.numLevel.Location = new System.Drawing.Point(177, 84);
            this.numLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLevel.Name = "numLevel";
            this.numLevel.Size = new System.Drawing.Size(139, 30);
            this.numLevel.TabIndex = 47;
            this.numLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // slblLevel
            // 
            this.slblLevel.AutoSize = true;
            this.slblLevel.Location = new System.Drawing.Point(12, 86);
            this.slblLevel.Name = "slblLevel";
            this.slblLevel.Size = new System.Drawing.Size(53, 22);
            this.slblLevel.TabIndex = 48;
            this.slblLevel.Text = "Level";
            // 
            // frmEvolve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 399);
            this.Controls.Add(this.numLevel);
            this.Controls.Add(this.slblLevel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbForm);
            this.Controls.Add(this.slblForm);
            this.Controls.Add(this.cmbPokeNum);
            this.Controls.Add(this.numSpeed);
            this.Controls.Add(this.numSpDefense);
            this.Controls.Add(this.numSpAttack);
            this.Controls.Add(this.numDefense);
            this.Controls.Add(this.numAttack);
            this.Controls.Add(this.numHealth);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.slblNumber);
            this.Controls.Add(this.slblHealthStat);
            this.Controls.Add(this.slblSpeedStat);
            this.Controls.Add(this.slblSpDefenseStat);
            this.Controls.Add(this.slblSpAttackStat);
            this.Controls.Add(this.slblDefenseStat);
            this.Controls.Add(this.slblAttackStat);
            this.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmEvolve";
            this.Text = "Evolve";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEvolve_FormClosing);
            this.Load += new System.EventHandler(this.frmEvolve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label slblNumber;
        private System.Windows.Forms.Label slblHealthStat;
        private System.Windows.Forms.Label slblSpeedStat;
        private System.Windows.Forms.Label slblSpDefenseStat;
        private System.Windows.Forms.Label slblSpAttackStat;
        private System.Windows.Forms.Label slblDefenseStat;
        private System.Windows.Forms.Label slblAttackStat;
        private System.Windows.Forms.NumericUpDown numHealth;
        private System.Windows.Forms.NumericUpDown numAttack;
        private System.Windows.Forms.NumericUpDown numDefense;
        private System.Windows.Forms.NumericUpDown numSpAttack;
        private System.Windows.Forms.NumericUpDown numSpDefense;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.ComboBox cmbPokeNum;
        private Data.PokemonDataSetTableAdapters.PokemonTableAdapter pokemonTableAdapter;
        private System.Windows.Forms.BindingSource pokemonDataSetBindingSource;
        private Data.PokemonDataSet pokemonDataSet;
        private System.Windows.Forms.BindingSource pokemonBindingSource;
        private System.Windows.Forms.ComboBox cmbForm;
        private System.Windows.Forms.Label slblForm;
        private Data.PokemonDataSetTableAdapters.FormsTableAdapter formsTableAdapter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown numLevel;
        private System.Windows.Forms.Label slblLevel;
    }
}