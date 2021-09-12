namespace Pokemon_Training_App.Views
{
    partial class frmSearchResultPartner
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
            this.dgvPartners = new System.Windows.Forms.DataGridView();
            this.pokemonDataSet = new Pokemon_Training_App.Data.PokemonDataSet();
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnersTableAdapter = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.PartnersTableAdapter();
            this.tableAdapterManager = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.TableAdapterManager();
            this.partnerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pokeNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pokeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natureIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natureNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasPokerusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.healthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spAttackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spDefenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVHealthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVAttackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVDefenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVSpAttackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVSpDefenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalEVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPartners
            // 
            this.dgvPartners.AllowUserToAddRows = false;
            this.dgvPartners.AllowUserToDeleteRows = false;
            this.dgvPartners.AllowUserToResizeRows = false;
            this.dgvPartners.AutoGenerateColumns = false;
            this.dgvPartners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPartners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partnerIDDataGridViewTextBoxColumn,
            this.nicknameDataGridViewTextBoxColumn,
            this.pokeNumDataGridViewTextBoxColumn,
            this.pokeNameDataGridViewTextBoxColumn,
            this.formIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.natureIDDataGridViewTextBoxColumn,
            this.natureNameDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn,
            this.hasPokerusDataGridViewCheckBoxColumn,
            this.healthDataGridViewTextBoxColumn,
            this.attackDataGridViewTextBoxColumn,
            this.defenseDataGridViewTextBoxColumn,
            this.spAttackDataGridViewTextBoxColumn,
            this.spDefenseDataGridViewTextBoxColumn,
            this.speedDataGridViewTextBoxColumn,
            this.eVHealthDataGridViewTextBoxColumn,
            this.eVAttackDataGridViewTextBoxColumn,
            this.eVDefenseDataGridViewTextBoxColumn,
            this.eVSpAttackDataGridViewTextBoxColumn,
            this.eVSpDefenseDataGridViewTextBoxColumn,
            this.eVSpeedDataGridViewTextBoxColumn,
            this.totalEVDataGridViewTextBoxColumn});
            this.dgvPartners.DataSource = this.partnersBindingSource;
            this.dgvPartners.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPartners.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPartners.Location = new System.Drawing.Point(0, 0);
            this.dgvPartners.MultiSelect = false;
            this.dgvPartners.Name = "dgvPartners";
            this.dgvPartners.ReadOnly = true;
            this.dgvPartners.RowHeadersVisible = false;
            this.dgvPartners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartners.Size = new System.Drawing.Size(1904, 367);
            this.dgvPartners.TabIndex = 3;
            this.dgvPartners.TabStop = false;
            // 
            // pokemonDataSet
            // 
            this.pokemonDataSet.DataSetName = "PokemonDataSet";
            this.pokemonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partnersBindingSource
            // 
            this.partnersBindingSource.DataMember = "Partners";
            this.partnersBindingSource.DataSource = this.pokemonDataSet;
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
            // partnerIDDataGridViewTextBoxColumn
            // 
            this.partnerIDDataGridViewTextBoxColumn.DataPropertyName = "PartnerID";
            this.partnerIDDataGridViewTextBoxColumn.HeaderText = "PartnerID";
            this.partnerIDDataGridViewTextBoxColumn.Name = "partnerIDDataGridViewTextBoxColumn";
            this.partnerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.partnerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nicknameDataGridViewTextBoxColumn
            // 
            this.nicknameDataGridViewTextBoxColumn.DataPropertyName = "Nickname";
            this.nicknameDataGridViewTextBoxColumn.FillWeight = 125F;
            this.nicknameDataGridViewTextBoxColumn.HeaderText = "Nickname";
            this.nicknameDataGridViewTextBoxColumn.Name = "nicknameDataGridViewTextBoxColumn";
            this.nicknameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pokeNumDataGridViewTextBoxColumn
            // 
            this.pokeNumDataGridViewTextBoxColumn.DataPropertyName = "PokeNum";
            this.pokeNumDataGridViewTextBoxColumn.FillWeight = 75F;
            this.pokeNumDataGridViewTextBoxColumn.HeaderText = "Number";
            this.pokeNumDataGridViewTextBoxColumn.Name = "pokeNumDataGridViewTextBoxColumn";
            this.pokeNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pokeNameDataGridViewTextBoxColumn
            // 
            this.pokeNameDataGridViewTextBoxColumn.DataPropertyName = "PokeName";
            this.pokeNameDataGridViewTextBoxColumn.FillWeight = 125F;
            this.pokeNameDataGridViewTextBoxColumn.HeaderText = "Species";
            this.pokeNameDataGridViewTextBoxColumn.Name = "pokeNameDataGridViewTextBoxColumn";
            this.pokeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formIDDataGridViewTextBoxColumn
            // 
            this.formIDDataGridViewTextBoxColumn.DataPropertyName = "FormID";
            this.formIDDataGridViewTextBoxColumn.HeaderText = "FormID";
            this.formIDDataGridViewTextBoxColumn.Name = "formIDDataGridViewTextBoxColumn";
            this.formIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.formIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 125F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Form Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // natureIDDataGridViewTextBoxColumn
            // 
            this.natureIDDataGridViewTextBoxColumn.DataPropertyName = "NatureID";
            this.natureIDDataGridViewTextBoxColumn.HeaderText = "NatureID";
            this.natureIDDataGridViewTextBoxColumn.Name = "natureIDDataGridViewTextBoxColumn";
            this.natureIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.natureIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // natureNameDataGridViewTextBoxColumn
            // 
            this.natureNameDataGridViewTextBoxColumn.DataPropertyName = "NatureName";
            this.natureNameDataGridViewTextBoxColumn.FillWeight = 125F;
            this.natureNameDataGridViewTextBoxColumn.HeaderText = "Nature Name";
            this.natureNameDataGridViewTextBoxColumn.Name = "natureNameDataGridViewTextBoxColumn";
            this.natureNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.FillWeight = 75F;
            this.levelDataGridViewTextBoxColumn.HeaderText = "Level";
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hasPokerusDataGridViewCheckBoxColumn
            // 
            this.hasPokerusDataGridViewCheckBoxColumn.DataPropertyName = "HasPokerus";
            this.hasPokerusDataGridViewCheckBoxColumn.FillWeight = 75F;
            this.hasPokerusDataGridViewCheckBoxColumn.HeaderText = "Pokerus";
            this.hasPokerusDataGridViewCheckBoxColumn.Name = "hasPokerusDataGridViewCheckBoxColumn";
            this.hasPokerusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // healthDataGridViewTextBoxColumn
            // 
            this.healthDataGridViewTextBoxColumn.DataPropertyName = "Health";
            this.healthDataGridViewTextBoxColumn.FillWeight = 75F;
            this.healthDataGridViewTextBoxColumn.HeaderText = "HP";
            this.healthDataGridViewTextBoxColumn.Name = "healthDataGridViewTextBoxColumn";
            this.healthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attackDataGridViewTextBoxColumn
            // 
            this.attackDataGridViewTextBoxColumn.DataPropertyName = "Attack";
            this.attackDataGridViewTextBoxColumn.FillWeight = 75F;
            this.attackDataGridViewTextBoxColumn.HeaderText = "Atk";
            this.attackDataGridViewTextBoxColumn.Name = "attackDataGridViewTextBoxColumn";
            this.attackDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defenseDataGridViewTextBoxColumn
            // 
            this.defenseDataGridViewTextBoxColumn.DataPropertyName = "Defense";
            this.defenseDataGridViewTextBoxColumn.FillWeight = 75F;
            this.defenseDataGridViewTextBoxColumn.HeaderText = "Def";
            this.defenseDataGridViewTextBoxColumn.Name = "defenseDataGridViewTextBoxColumn";
            this.defenseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spAttackDataGridViewTextBoxColumn
            // 
            this.spAttackDataGridViewTextBoxColumn.DataPropertyName = "SpAttack";
            this.spAttackDataGridViewTextBoxColumn.FillWeight = 75F;
            this.spAttackDataGridViewTextBoxColumn.HeaderText = "SpAtk";
            this.spAttackDataGridViewTextBoxColumn.Name = "spAttackDataGridViewTextBoxColumn";
            this.spAttackDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spDefenseDataGridViewTextBoxColumn
            // 
            this.spDefenseDataGridViewTextBoxColumn.DataPropertyName = "SpDefense";
            this.spDefenseDataGridViewTextBoxColumn.FillWeight = 75F;
            this.spDefenseDataGridViewTextBoxColumn.HeaderText = "SpDef";
            this.spDefenseDataGridViewTextBoxColumn.Name = "spDefenseDataGridViewTextBoxColumn";
            this.spDefenseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // speedDataGridViewTextBoxColumn
            // 
            this.speedDataGridViewTextBoxColumn.DataPropertyName = "Speed";
            this.speedDataGridViewTextBoxColumn.FillWeight = 75F;
            this.speedDataGridViewTextBoxColumn.HeaderText = "Spd";
            this.speedDataGridViewTextBoxColumn.Name = "speedDataGridViewTextBoxColumn";
            this.speedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eVHealthDataGridViewTextBoxColumn
            // 
            this.eVHealthDataGridViewTextBoxColumn.DataPropertyName = "EVHealth";
            this.eVHealthDataGridViewTextBoxColumn.FillWeight = 75F;
            this.eVHealthDataGridViewTextBoxColumn.HeaderText = "HP EV";
            this.eVHealthDataGridViewTextBoxColumn.Name = "eVHealthDataGridViewTextBoxColumn";
            this.eVHealthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eVAttackDataGridViewTextBoxColumn
            // 
            this.eVAttackDataGridViewTextBoxColumn.DataPropertyName = "EVAttack";
            this.eVAttackDataGridViewTextBoxColumn.FillWeight = 75F;
            this.eVAttackDataGridViewTextBoxColumn.HeaderText = "Atk EV";
            this.eVAttackDataGridViewTextBoxColumn.Name = "eVAttackDataGridViewTextBoxColumn";
            this.eVAttackDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eVDefenseDataGridViewTextBoxColumn
            // 
            this.eVDefenseDataGridViewTextBoxColumn.DataPropertyName = "EVDefense";
            this.eVDefenseDataGridViewTextBoxColumn.FillWeight = 75F;
            this.eVDefenseDataGridViewTextBoxColumn.HeaderText = "Def EV";
            this.eVDefenseDataGridViewTextBoxColumn.Name = "eVDefenseDataGridViewTextBoxColumn";
            this.eVDefenseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eVSpAttackDataGridViewTextBoxColumn
            // 
            this.eVSpAttackDataGridViewTextBoxColumn.DataPropertyName = "EVSpAttack";
            this.eVSpAttackDataGridViewTextBoxColumn.FillWeight = 75F;
            this.eVSpAttackDataGridViewTextBoxColumn.HeaderText = "SpAtk EV";
            this.eVSpAttackDataGridViewTextBoxColumn.Name = "eVSpAttackDataGridViewTextBoxColumn";
            this.eVSpAttackDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eVSpDefenseDataGridViewTextBoxColumn
            // 
            this.eVSpDefenseDataGridViewTextBoxColumn.DataPropertyName = "EVSpDefense";
            this.eVSpDefenseDataGridViewTextBoxColumn.FillWeight = 75F;
            this.eVSpDefenseDataGridViewTextBoxColumn.HeaderText = "SpDef EV";
            this.eVSpDefenseDataGridViewTextBoxColumn.Name = "eVSpDefenseDataGridViewTextBoxColumn";
            this.eVSpDefenseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eVSpeedDataGridViewTextBoxColumn
            // 
            this.eVSpeedDataGridViewTextBoxColumn.DataPropertyName = "EVSpeed";
            this.eVSpeedDataGridViewTextBoxColumn.FillWeight = 75F;
            this.eVSpeedDataGridViewTextBoxColumn.HeaderText = "Spd EV";
            this.eVSpeedDataGridViewTextBoxColumn.Name = "eVSpeedDataGridViewTextBoxColumn";
            this.eVSpeedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalEVDataGridViewTextBoxColumn
            // 
            this.totalEVDataGridViewTextBoxColumn.DataPropertyName = "TotalEV";
            this.totalEVDataGridViewTextBoxColumn.FillWeight = 75F;
            this.totalEVDataGridViewTextBoxColumn.HeaderText = "Total EVs";
            this.totalEVDataGridViewTextBoxColumn.Name = "totalEVDataGridViewTextBoxColumn";
            this.totalEVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmSearchResultPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 501);
            this.Controls.Add(this.dgvPartners);
            this.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSearchResultPartner";
            this.Text = "frmSearchResultPartner";
            this.Load += new System.EventHandler(this.frmSearchResultPartner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPartners;
        private Data.PokemonDataSet pokemonDataSet;
        private System.Windows.Forms.BindingSource partnersBindingSource;
        private Data.PokemonDataSetTableAdapters.PartnersTableAdapter partnersTableAdapter;
        private Data.PokemonDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pokeNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pokeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn natureIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn natureNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasPokerusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spAttackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spDefenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVHealthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVAttackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVDefenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVSpAttackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVSpDefenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVSpeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalEVDataGridViewTextBoxColumn;
    }
}