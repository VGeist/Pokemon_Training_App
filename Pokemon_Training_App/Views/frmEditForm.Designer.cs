namespace Pokemon_Training_App.Views
{
    partial class frmEditForm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.slblFormName = new System.Windows.Forms.Label();
            this.txtFormName = new System.Windows.Forms.TextBox();
            this.slblBaseHealth = new System.Windows.Forms.Label();
            this.slblBaseSpeed = new System.Windows.Forms.Label();
            this.slblBaseSpDef = new System.Windows.Forms.Label();
            this.slblBaseSpAtk = new System.Windows.Forms.Label();
            this.slblBaseDefense = new System.Windows.Forms.Label();
            this.slblBaseAttack = new System.Windows.Forms.Label();
            this.slblPokemonNumber = new System.Windows.Forms.Label();
            this.numBaseSpeed = new System.Windows.Forms.NumericUpDown();
            this.numBaseSpDefense = new System.Windows.Forms.NumericUpDown();
            this.numBaseSpAttack = new System.Windows.Forms.NumericUpDown();
            this.numBaseHealth = new System.Windows.Forms.NumericUpDown();
            this.numBaseAttack = new System.Windows.Forms.NumericUpDown();
            this.numBaseDefense = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblPokeNum = new System.Windows.Forms.Label();
            this.pokemonDataSet = new Pokemon_Training_App.Data.PokemonDataSet();
            this.formsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formsTableAdapter = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.FormsTableAdapter();
            this.tableAdapterManager = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseSpDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseSpAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(125, 359);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(87, 30);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(299, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // slblFormName
            // 
            this.slblFormName.AutoSize = true;
            this.slblFormName.Location = new System.Drawing.Point(12, 58);
            this.slblFormName.Name = "slblFormName";
            this.slblFormName.Size = new System.Drawing.Size(104, 22);
            this.slblFormName.TabIndex = 72;
            this.slblFormName.Text = "Form Name";
            // 
            // txtFormName
            // 
            this.txtFormName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formsBindingSource, "Name", true));
            this.txtFormName.Location = new System.Drawing.Point(190, 54);
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.Size = new System.Drawing.Size(185, 30);
            this.txtFormName.TabIndex = 2;
            // 
            // slblBaseHealth
            // 
            this.slblBaseHealth.AutoSize = true;
            this.slblBaseHealth.Location = new System.Drawing.Point(12, 101);
            this.slblBaseHealth.Name = "slblBaseHealth";
            this.slblBaseHealth.Size = new System.Drawing.Size(104, 22);
            this.slblBaseHealth.TabIndex = 71;
            this.slblBaseHealth.Text = "Base Health";
            // 
            // slblBaseSpeed
            // 
            this.slblBaseSpeed.AutoSize = true;
            this.slblBaseSpeed.Location = new System.Drawing.Point(12, 316);
            this.slblBaseSpeed.Name = "slblBaseSpeed";
            this.slblBaseSpeed.Size = new System.Drawing.Size(135, 22);
            this.slblBaseSpeed.TabIndex = 70;
            this.slblBaseSpeed.Text = "Base Speed Stat";
            // 
            // slblBaseSpDef
            // 
            this.slblBaseSpDef.AutoSize = true;
            this.slblBaseSpDef.Location = new System.Drawing.Point(12, 273);
            this.slblBaseSpDef.Name = "slblBaseSpDef";
            this.slblBaseSpDef.Size = new System.Drawing.Size(134, 22);
            this.slblBaseSpDef.TabIndex = 69;
            this.slblBaseSpDef.Text = "Base SpDef Stat";
            // 
            // slblBaseSpAtk
            // 
            this.slblBaseSpAtk.AutoSize = true;
            this.slblBaseSpAtk.Location = new System.Drawing.Point(12, 230);
            this.slblBaseSpAtk.Name = "slblBaseSpAtk";
            this.slblBaseSpAtk.Size = new System.Drawing.Size(134, 22);
            this.slblBaseSpAtk.TabIndex = 68;
            this.slblBaseSpAtk.Text = "Base SpAtk Stat";
            // 
            // slblBaseDefense
            // 
            this.slblBaseDefense.AutoSize = true;
            this.slblBaseDefense.Location = new System.Drawing.Point(12, 187);
            this.slblBaseDefense.Name = "slblBaseDefense";
            this.slblBaseDefense.Size = new System.Drawing.Size(151, 22);
            this.slblBaseDefense.TabIndex = 67;
            this.slblBaseDefense.Text = "Base Defense Stat";
            // 
            // slblBaseAttack
            // 
            this.slblBaseAttack.AutoSize = true;
            this.slblBaseAttack.Location = new System.Drawing.Point(12, 144);
            this.slblBaseAttack.Name = "slblBaseAttack";
            this.slblBaseAttack.Size = new System.Drawing.Size(137, 22);
            this.slblBaseAttack.TabIndex = 66;
            this.slblBaseAttack.Text = "Base Attack Stat";
            // 
            // slblPokemonNumber
            // 
            this.slblPokemonNumber.AutoSize = true;
            this.slblPokemonNumber.Location = new System.Drawing.Point(12, 15);
            this.slblPokemonNumber.Name = "slblPokemonNumber";
            this.slblPokemonNumber.Size = new System.Drawing.Size(158, 22);
            this.slblPokemonNumber.TabIndex = 65;
            this.slblPokemonNumber.Text = "Pokemon Number";
            // 
            // numBaseSpeed
            // 
            this.numBaseSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.formsBindingSource, "BaseSpeed", true));
            this.numBaseSpeed.Location = new System.Drawing.Point(190, 314);
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
            this.numBaseSpeed.TabIndex = 8;
            this.numBaseSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numBaseSpDefense
            // 
            this.numBaseSpDefense.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.formsBindingSource, "BaseSpDefense", true));
            this.numBaseSpDefense.Location = new System.Drawing.Point(190, 271);
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
            this.numBaseSpDefense.TabIndex = 7;
            this.numBaseSpDefense.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numBaseSpAttack
            // 
            this.numBaseSpAttack.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.formsBindingSource, "BaseSpAttack", true));
            this.numBaseSpAttack.Location = new System.Drawing.Point(190, 228);
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
            this.numBaseSpAttack.TabIndex = 6;
            this.numBaseSpAttack.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numBaseHealth
            // 
            this.numBaseHealth.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.formsBindingSource, "BaseHealth", true));
            this.numBaseHealth.Location = new System.Drawing.Point(190, 99);
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
            this.numBaseHealth.TabIndex = 3;
            this.numBaseHealth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numBaseAttack
            // 
            this.numBaseAttack.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.formsBindingSource, "BaseAttack", true));
            this.numBaseAttack.Location = new System.Drawing.Point(190, 142);
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
            this.numBaseAttack.TabIndex = 4;
            this.numBaseAttack.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numBaseDefense
            // 
            this.numBaseDefense.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.formsBindingSource, "BaseDefense", true));
            this.numBaseDefense.Location = new System.Drawing.Point(190, 185);
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
            this.numBaseDefense.TabIndex = 5;
            this.numBaseDefense.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(218, 359);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPokeNum
            // 
            this.lblPokeNum.AutoSize = true;
            this.lblPokeNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formsBindingSource, "PokeNum", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "\\#000"));
            this.lblPokeNum.Location = new System.Drawing.Point(186, 15);
            this.lblPokeNum.Name = "lblPokeNum";
            this.lblPokeNum.Size = new System.Drawing.Size(22, 22);
            this.lblPokeNum.TabIndex = 73;
            this.lblPokeNum.Text = "#";
            // 
            // pokemonDataSet
            // 
            this.pokemonDataSet.DataSetName = "PokemonDataSet";
            this.pokemonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formsBindingSource
            // 
            this.formsBindingSource.DataMember = "Forms";
            this.formsBindingSource.DataSource = this.pokemonDataSet;
            // 
            // formsTableAdapter
            // 
            this.formsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FormsTableAdapter = this.formsTableAdapter;
            this.tableAdapterManager.NaturesTableAdapter = null;
            this.tableAdapterManager.PartnersTableAdapter = null;
            this.tableAdapterManager.PokemonTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Pokemon_Training_App.Data.PokemonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 401);
            this.Controls.Add(this.lblPokeNum);
            this.Controls.Add(this.numBaseSpeed);
            this.Controls.Add(this.numBaseSpDefense);
            this.Controls.Add(this.numBaseSpAttack);
            this.Controls.Add(this.numBaseHealth);
            this.Controls.Add(this.numBaseAttack);
            this.Controls.Add(this.numBaseDefense);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.slblFormName);
            this.Controls.Add(this.txtFormName);
            this.Controls.Add(this.slblBaseHealth);
            this.Controls.Add(this.slblBaseSpeed);
            this.Controls.Add(this.slblBaseSpDef);
            this.Controls.Add(this.slblBaseSpAtk);
            this.Controls.Add(this.slblBaseDefense);
            this.Controls.Add(this.slblBaseAttack);
            this.Controls.Add(this.slblPokemonNumber);
            this.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmEditForm";
            this.Text = "Edit Form";
            this.Load += new System.EventHandler(this.frmEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBaseSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseSpDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseSpAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label slblFormName;
        private System.Windows.Forms.TextBox txtFormName;
        private System.Windows.Forms.Label slblBaseHealth;
        private System.Windows.Forms.Label slblBaseSpeed;
        private System.Windows.Forms.Label slblBaseSpDef;
        private System.Windows.Forms.Label slblBaseSpAtk;
        private System.Windows.Forms.Label slblBaseDefense;
        private System.Windows.Forms.Label slblBaseAttack;
        private System.Windows.Forms.Label slblPokemonNumber;
        private System.Windows.Forms.NumericUpDown numBaseSpeed;
        private System.Windows.Forms.NumericUpDown numBaseSpDefense;
        private System.Windows.Forms.NumericUpDown numBaseSpAttack;
        private System.Windows.Forms.NumericUpDown numBaseHealth;
        private System.Windows.Forms.NumericUpDown numBaseAttack;
        private System.Windows.Forms.NumericUpDown numBaseDefense;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblPokeNum;
        private Data.PokemonDataSet pokemonDataSet;
        private System.Windows.Forms.BindingSource formsBindingSource;
        private Data.PokemonDataSetTableAdapters.FormsTableAdapter formsTableAdapter;
        private Data.PokemonDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}