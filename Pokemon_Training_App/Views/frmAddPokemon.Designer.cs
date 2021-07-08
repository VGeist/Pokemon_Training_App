namespace Pokemon_Training_App.Views
{
    partial class frmAddPokemon
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
            this.slblBaseSpeed = new System.Windows.Forms.Label();
            this.slblBaseSpDef = new System.Windows.Forms.Label();
            this.slblBaseSpAtk = new System.Windows.Forms.Label();
            this.slblBaseDefense = new System.Windows.Forms.Label();
            this.slblBaseAttack = new System.Windows.Forms.Label();
            this.slblPokemonName = new System.Windows.Forms.Label();
            this.slblPokemonNumber = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPokemonName = new System.Windows.Forms.TextBox();
            this.slblBaseHealth = new System.Windows.Forms.Label();
            this.slblStatsNotice = new System.Windows.Forms.Label();
            this.slblFormName = new System.Windows.Forms.Label();
            this.pokemonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokemonDataSet = new Pokemon_Training_App.Data.PokemonDataSet();
            this.pokemonTableAdapter = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.PokemonTableAdapter();
            this.numPokeNum = new System.Windows.Forms.NumericUpDown();
            this.numBaseHealth = new System.Windows.Forms.NumericUpDown();
            this.numBaseAttack = new System.Windows.Forms.NumericUpDown();
            this.numBaseDefense = new System.Windows.Forms.NumericUpDown();
            this.numBaseSpAttack = new System.Windows.Forms.NumericUpDown();
            this.numBaseSpDefense = new System.Windows.Forms.NumericUpDown();
            this.numBaseSpeed = new System.Windows.Forms.NumericUpDown();
            this.txtFormName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPokeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseSpAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseSpDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // slblBaseSpeed
            // 
            this.slblBaseSpeed.AutoSize = true;
            this.slblBaseSpeed.Location = new System.Drawing.Point(12, 401);
            this.slblBaseSpeed.Name = "slblBaseSpeed";
            this.slblBaseSpeed.Size = new System.Drawing.Size(135, 22);
            this.slblBaseSpeed.TabIndex = 33;
            this.slblBaseSpeed.Text = "Base Speed Stat";
            // 
            // slblBaseSpDef
            // 
            this.slblBaseSpDef.AutoSize = true;
            this.slblBaseSpDef.Location = new System.Drawing.Point(12, 357);
            this.slblBaseSpDef.Name = "slblBaseSpDef";
            this.slblBaseSpDef.Size = new System.Drawing.Size(134, 22);
            this.slblBaseSpDef.TabIndex = 32;
            this.slblBaseSpDef.Text = "Base SpDef Stat";
            // 
            // slblBaseSpAtk
            // 
            this.slblBaseSpAtk.AutoSize = true;
            this.slblBaseSpAtk.Location = new System.Drawing.Point(12, 313);
            this.slblBaseSpAtk.Name = "slblBaseSpAtk";
            this.slblBaseSpAtk.Size = new System.Drawing.Size(134, 22);
            this.slblBaseSpAtk.TabIndex = 31;
            this.slblBaseSpAtk.Text = "Base SpAtk Stat";
            // 
            // slblBaseDefense
            // 
            this.slblBaseDefense.AutoSize = true;
            this.slblBaseDefense.Location = new System.Drawing.Point(12, 269);
            this.slblBaseDefense.Name = "slblBaseDefense";
            this.slblBaseDefense.Size = new System.Drawing.Size(151, 22);
            this.slblBaseDefense.TabIndex = 30;
            this.slblBaseDefense.Text = "Base Defense Stat";
            // 
            // slblBaseAttack
            // 
            this.slblBaseAttack.AutoSize = true;
            this.slblBaseAttack.Location = new System.Drawing.Point(12, 225);
            this.slblBaseAttack.Name = "slblBaseAttack";
            this.slblBaseAttack.Size = new System.Drawing.Size(137, 22);
            this.slblBaseAttack.TabIndex = 29;
            this.slblBaseAttack.Text = "Base Attack Stat";
            // 
            // slblPokemonName
            // 
            this.slblPokemonName.AutoSize = true;
            this.slblPokemonName.Location = new System.Drawing.Point(12, 62);
            this.slblPokemonName.Name = "slblPokemonName";
            this.slblPokemonName.Size = new System.Drawing.Size(138, 22);
            this.slblPokemonName.TabIndex = 28;
            this.slblPokemonName.Text = "Pokemon Name";
            // 
            // slblPokemonNumber
            // 
            this.slblPokemonNumber.AutoSize = true;
            this.slblPokemonNumber.Location = new System.Drawing.Point(12, 18);
            this.slblPokemonNumber.Name = "slblPokemonNumber";
            this.slblPokemonNumber.Size = new System.Drawing.Size(158, 22);
            this.slblPokemonNumber.TabIndex = 27;
            this.slblPokemonNumber.Text = "Pokemon Number";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(219, 441);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(138, 441);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 441);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPokemonName
            // 
            this.txtPokemonName.Location = new System.Drawing.Point(190, 58);
            this.txtPokemonName.Name = "txtPokemonName";
            this.txtPokemonName.Size = new System.Drawing.Size(185, 30);
            this.txtPokemonName.TabIndex = 2;
            // 
            // slblBaseHealth
            // 
            this.slblBaseHealth.AutoSize = true;
            this.slblBaseHealth.Location = new System.Drawing.Point(12, 181);
            this.slblBaseHealth.Name = "slblBaseHealth";
            this.slblBaseHealth.Size = new System.Drawing.Size(104, 22);
            this.slblBaseHealth.TabIndex = 36;
            this.slblBaseHealth.Text = "Base Health";
            // 
            // slblStatsNotice
            // 
            this.slblStatsNotice.AutoSize = true;
            this.slblStatsNotice.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slblStatsNotice.Location = new System.Drawing.Point(12, 102);
            this.slblStatsNotice.Name = "slblStatsNotice";
            this.slblStatsNotice.Size = new System.Drawing.Size(316, 17);
            this.slblStatsNotice.TabIndex = 37;
            this.slblStatsNotice.Text = "Input initial (default or most common) form data.";
            // 
            // slblFormName
            // 
            this.slblFormName.AutoSize = true;
            this.slblFormName.Location = new System.Drawing.Point(12, 137);
            this.slblFormName.Name = "slblFormName";
            this.slblFormName.Size = new System.Drawing.Size(104, 22);
            this.slblFormName.TabIndex = 39;
            this.slblFormName.Text = "Form Name";
            // 
            // pokemonBindingSource
            // 
            this.pokemonBindingSource.DataSource = this.pokemonDataSet;
            this.pokemonBindingSource.Position = 0;
            // 
            // pokemonDataSet
            // 
            this.pokemonDataSet.DataSetName = "PokemonDataSet";
            this.pokemonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pokemonTableAdapter
            // 
            this.pokemonTableAdapter.ClearBeforeFill = true;
            // 
            // numPokeNum
            // 
            this.numPokeNum.Location = new System.Drawing.Point(190, 14);
            this.numPokeNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPokeNum.Name = "numPokeNum";
            this.numPokeNum.Size = new System.Drawing.Size(185, 30);
            this.numPokeNum.TabIndex = 1;
            // 
            // numBaseHealth
            // 
            this.numBaseHealth.Location = new System.Drawing.Point(190, 179);
            this.numBaseHealth.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBaseHealth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBaseHealth.Name = "numBaseHealth";
            this.numBaseHealth.Size = new System.Drawing.Size(185, 30);
            this.numBaseHealth.TabIndex = 4;
            this.numBaseHealth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numBaseAttack
            // 
            this.numBaseAttack.Location = new System.Drawing.Point(190, 223);
            this.numBaseAttack.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBaseAttack.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBaseAttack.Name = "numBaseAttack";
            this.numBaseAttack.Size = new System.Drawing.Size(185, 30);
            this.numBaseAttack.TabIndex = 5;
            this.numBaseAttack.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numBaseDefense
            // 
            this.numBaseDefense.Location = new System.Drawing.Point(190, 267);
            this.numBaseDefense.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBaseDefense.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBaseDefense.Name = "numBaseDefense";
            this.numBaseDefense.Size = new System.Drawing.Size(185, 30);
            this.numBaseDefense.TabIndex = 6;
            this.numBaseDefense.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numBaseSpAttack
            // 
            this.numBaseSpAttack.Location = new System.Drawing.Point(190, 311);
            this.numBaseSpAttack.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBaseSpAttack.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBaseSpAttack.Name = "numBaseSpAttack";
            this.numBaseSpAttack.Size = new System.Drawing.Size(185, 30);
            this.numBaseSpAttack.TabIndex = 7;
            this.numBaseSpAttack.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numBaseSpDefense
            // 
            this.numBaseSpDefense.Location = new System.Drawing.Point(190, 355);
            this.numBaseSpDefense.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBaseSpDefense.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBaseSpDefense.Name = "numBaseSpDefense";
            this.numBaseSpDefense.Size = new System.Drawing.Size(185, 30);
            this.numBaseSpDefense.TabIndex = 8;
            this.numBaseSpDefense.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numBaseSpeed
            // 
            this.numBaseSpeed.Location = new System.Drawing.Point(190, 399);
            this.numBaseSpeed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBaseSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBaseSpeed.Name = "numBaseSpeed";
            this.numBaseSpeed.Size = new System.Drawing.Size(185, 30);
            this.numBaseSpeed.TabIndex = 9;
            this.numBaseSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtFormName
            // 
            this.txtFormName.Location = new System.Drawing.Point(190, 134);
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.Size = new System.Drawing.Size(185, 30);
            this.txtFormName.TabIndex = 3;
            // 
            // frmAddPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 487);
            this.Controls.Add(this.txtFormName);
            this.Controls.Add(this.numBaseSpeed);
            this.Controls.Add(this.numBaseSpDefense);
            this.Controls.Add(this.numBaseSpAttack);
            this.Controls.Add(this.numBaseDefense);
            this.Controls.Add(this.numBaseAttack);
            this.Controls.Add(this.numBaseHealth);
            this.Controls.Add(this.numPokeNum);
            this.Controls.Add(this.slblFormName);
            this.Controls.Add(this.slblStatsNotice);
            this.Controls.Add(this.slblBaseHealth);
            this.Controls.Add(this.slblBaseSpeed);
            this.Controls.Add(this.slblBaseSpDef);
            this.Controls.Add(this.slblBaseSpAtk);
            this.Controls.Add(this.slblBaseDefense);
            this.Controls.Add(this.slblBaseAttack);
            this.Controls.Add(this.slblPokemonName);
            this.Controls.Add(this.slblPokemonNumber);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPokemonName);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAddPokemon";
            this.Text = "New Pokemon Entry";
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPokeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseSpAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseSpDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label slblBaseSpeed;
        private System.Windows.Forms.Label slblBaseSpDef;
        private System.Windows.Forms.Label slblBaseSpAtk;
        private System.Windows.Forms.Label slblBaseDefense;
        private System.Windows.Forms.Label slblBaseAttack;
        private System.Windows.Forms.Label slblPokemonName;
        private System.Windows.Forms.Label slblPokemonNumber;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPokemonName;
        private System.Windows.Forms.Label slblBaseHealth;
        private System.Windows.Forms.Label slblStatsNotice;
        private System.Windows.Forms.Label slblFormName;
        private System.Windows.Forms.BindingSource pokemonBindingSource;
        private Data.PokemonDataSet pokemonDataSet;
        private Data.PokemonDataSetTableAdapters.PokemonTableAdapter pokemonTableAdapter;
        private System.Windows.Forms.NumericUpDown numPokeNum;
        private System.Windows.Forms.NumericUpDown numBaseHealth;
        private System.Windows.Forms.NumericUpDown numBaseAttack;
        private System.Windows.Forms.NumericUpDown numBaseDefense;
        private System.Windows.Forms.NumericUpDown numBaseSpAttack;
        private System.Windows.Forms.NumericUpDown numBaseSpDefense;
        private System.Windows.Forms.NumericUpDown numBaseSpeed;
        private System.Windows.Forms.TextBox txtFormName;
    }
}