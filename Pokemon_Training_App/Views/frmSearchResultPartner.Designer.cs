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
            this.colPartnerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPokeNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPokeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFormID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFormName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNatureID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNatureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPokerus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colHealth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDefense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpAttack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpDefense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHealthEV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttackEV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDefenseEV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpAttackEV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpDefenseEV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpeedEV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalEV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokemonDataSet = new Pokemon_Training_App.Data.PokemonDataSet();
            this.partnersTableAdapter = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.PartnersTableAdapter();
            this.tableAdapterManager = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.TableAdapterManager();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).BeginInit();
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
            this.colPartnerID,
            this.colNickname,
            this.colPokeNum,
            this.colPokeName,
            this.colFormID,
            this.colFormName,
            this.colNatureID,
            this.colNatureName,
            this.colLevel,
            this.colPokerus,
            this.colHealth,
            this.colAttack,
            this.colDefense,
            this.colSpAttack,
            this.colSpDefense,
            this.colSpeed,
            this.colHealthEV,
            this.colAttackEV,
            this.colDefenseEV,
            this.colSpAttackEV,
            this.colSpDefenseEV,
            this.colSpeedEV,
            this.colTotalEV});
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
            // colPartnerID
            // 
            this.colPartnerID.DataPropertyName = "PartnerID";
            this.colPartnerID.HeaderText = "PartnerID";
            this.colPartnerID.Name = "colPartnerID";
            this.colPartnerID.ReadOnly = true;
            this.colPartnerID.Visible = false;
            // 
            // colNickname
            // 
            this.colNickname.DataPropertyName = "Nickname";
            this.colNickname.FillWeight = 125F;
            this.colNickname.HeaderText = "Nickname";
            this.colNickname.Name = "colNickname";
            this.colNickname.ReadOnly = true;
            // 
            // colPokeNum
            // 
            this.colPokeNum.DataPropertyName = "PokeNum";
            this.colPokeNum.FillWeight = 75F;
            this.colPokeNum.HeaderText = "Number";
            this.colPokeNum.Name = "colPokeNum";
            this.colPokeNum.ReadOnly = true;
            // 
            // colPokeName
            // 
            this.colPokeName.DataPropertyName = "PokeName";
            this.colPokeName.FillWeight = 125F;
            this.colPokeName.HeaderText = "Species";
            this.colPokeName.Name = "colPokeName";
            this.colPokeName.ReadOnly = true;
            // 
            // colFormID
            // 
            this.colFormID.DataPropertyName = "FormID";
            this.colFormID.HeaderText = "FormID";
            this.colFormID.Name = "colFormID";
            this.colFormID.ReadOnly = true;
            this.colFormID.Visible = false;
            // 
            // colFormName
            // 
            this.colFormName.DataPropertyName = "Name";
            this.colFormName.FillWeight = 125F;
            this.colFormName.HeaderText = "Form";
            this.colFormName.Name = "colFormName";
            this.colFormName.ReadOnly = true;
            // 
            // colNatureID
            // 
            this.colNatureID.DataPropertyName = "NatureID";
            this.colNatureID.HeaderText = "NatureID";
            this.colNatureID.Name = "colNatureID";
            this.colNatureID.ReadOnly = true;
            this.colNatureID.Visible = false;
            // 
            // colNatureName
            // 
            this.colNatureName.DataPropertyName = "NatureName";
            this.colNatureName.FillWeight = 125F;
            this.colNatureName.HeaderText = "Nature";
            this.colNatureName.Name = "colNatureName";
            this.colNatureName.ReadOnly = true;
            // 
            // colLevel
            // 
            this.colLevel.DataPropertyName = "Level";
            this.colLevel.FillWeight = 75F;
            this.colLevel.HeaderText = "Level";
            this.colLevel.Name = "colLevel";
            this.colLevel.ReadOnly = true;
            // 
            // colPokerus
            // 
            this.colPokerus.DataPropertyName = "HasPokerus";
            this.colPokerus.FillWeight = 75F;
            this.colPokerus.HeaderText = "Pokerus";
            this.colPokerus.Name = "colPokerus";
            this.colPokerus.ReadOnly = true;
            // 
            // colHealth
            // 
            this.colHealth.DataPropertyName = "Health";
            this.colHealth.FillWeight = 75F;
            this.colHealth.HeaderText = "HP";
            this.colHealth.Name = "colHealth";
            this.colHealth.ReadOnly = true;
            // 
            // colAttack
            // 
            this.colAttack.DataPropertyName = "Attack";
            this.colAttack.FillWeight = 75F;
            this.colAttack.HeaderText = "Atk";
            this.colAttack.Name = "colAttack";
            this.colAttack.ReadOnly = true;
            // 
            // colDefense
            // 
            this.colDefense.DataPropertyName = "Defense";
            this.colDefense.FillWeight = 75F;
            this.colDefense.HeaderText = "Def";
            this.colDefense.Name = "colDefense";
            this.colDefense.ReadOnly = true;
            // 
            // colSpAttack
            // 
            this.colSpAttack.DataPropertyName = "SpAttack";
            this.colSpAttack.FillWeight = 75F;
            this.colSpAttack.HeaderText = "SpAtk";
            this.colSpAttack.Name = "colSpAttack";
            this.colSpAttack.ReadOnly = true;
            // 
            // colSpDefense
            // 
            this.colSpDefense.DataPropertyName = "SpDefense";
            this.colSpDefense.FillWeight = 75F;
            this.colSpDefense.HeaderText = "SpDef";
            this.colSpDefense.Name = "colSpDefense";
            this.colSpDefense.ReadOnly = true;
            // 
            // colSpeed
            // 
            this.colSpeed.DataPropertyName = "Speed";
            this.colSpeed.FillWeight = 75F;
            this.colSpeed.HeaderText = "Spd";
            this.colSpeed.Name = "colSpeed";
            this.colSpeed.ReadOnly = true;
            // 
            // colHealthEV
            // 
            this.colHealthEV.DataPropertyName = "EVHealth";
            this.colHealthEV.FillWeight = 75F;
            this.colHealthEV.HeaderText = "HP EV";
            this.colHealthEV.Name = "colHealthEV";
            this.colHealthEV.ReadOnly = true;
            // 
            // colAttackEV
            // 
            this.colAttackEV.DataPropertyName = "EVAttack";
            this.colAttackEV.FillWeight = 75F;
            this.colAttackEV.HeaderText = "Atk EV";
            this.colAttackEV.Name = "colAttackEV";
            this.colAttackEV.ReadOnly = true;
            // 
            // colDefenseEV
            // 
            this.colDefenseEV.DataPropertyName = "EVDefense";
            this.colDefenseEV.FillWeight = 75F;
            this.colDefenseEV.HeaderText = "Def EV";
            this.colDefenseEV.Name = "colDefenseEV";
            this.colDefenseEV.ReadOnly = true;
            // 
            // colSpAttackEV
            // 
            this.colSpAttackEV.DataPropertyName = "EVSpAttack";
            this.colSpAttackEV.FillWeight = 75F;
            this.colSpAttackEV.HeaderText = "SpAtk EV";
            this.colSpAttackEV.Name = "colSpAttackEV";
            this.colSpAttackEV.ReadOnly = true;
            // 
            // colSpDefenseEV
            // 
            this.colSpDefenseEV.DataPropertyName = "EVSpDefense";
            this.colSpDefenseEV.FillWeight = 75F;
            this.colSpDefenseEV.HeaderText = "SpDef EV";
            this.colSpDefenseEV.Name = "colSpDefenseEV";
            this.colSpDefenseEV.ReadOnly = true;
            // 
            // colSpeedEV
            // 
            this.colSpeedEV.DataPropertyName = "EVSpeed";
            this.colSpeedEV.FillWeight = 75F;
            this.colSpeedEV.HeaderText = "Spd EV";
            this.colSpeedEV.Name = "colSpeedEV";
            this.colSpeedEV.ReadOnly = true;
            // 
            // colTotalEV
            // 
            this.colTotalEV.DataPropertyName = "TotalEV";
            this.colTotalEV.FillWeight = 75F;
            this.colTotalEV.HeaderText = "Total EVs";
            this.colTotalEV.Name = "colTotalEV";
            this.colTotalEV.ReadOnly = true;
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
            // btnGroup
            // 
            this.btnGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGroup.Location = new System.Drawing.Point(1542, 384);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(146, 31);
            this.btnGroup.TabIndex = 4;
            this.btnGroup.Text = "Add To Group";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(1694, 384);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(59, 31);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(1759, 384);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(59, 31);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1824, 384);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 31);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(12, 384);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(68, 31);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // frmSearchResultPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 427);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.dgvPartners);
            this.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSearchResultPartner";
            this.Text = "frmSearchResultPartner";
            this.Load += new System.EventHandler(this.frmSearchResultPartner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPartners;
        private Data.PokemonDataSet pokemonDataSet;
        private System.Windows.Forms.BindingSource partnersBindingSource;
        private Data.PokemonDataSetTableAdapters.PartnersTableAdapter partnersTableAdapter;
        private Data.PokemonDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartnerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPokeNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPokeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFormID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFormName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNatureID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNatureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPokerus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHealth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttack;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDefense;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpAttack;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpDefense;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHealthEV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttackEV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDefenseEV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpAttackEV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpDefenseEV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpeedEV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalEV;
    }
}