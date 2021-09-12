namespace Pokemon_Training_App.Views
{
    partial class frmPokemonForms
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
            this.pokemonDataSet = new Pokemon_Training_App.Data.PokemonDataSet();
            this.formsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formsTableAdapter = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.FormsTableAdapter();
            this.tableAdapterManager = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.TableAdapterManager();
            this.dgvForms = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.colFormID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPokeNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaseHealth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaseAttack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaseDefense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaseSpAttack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaseSpDefense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaseSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForms)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.PokemonTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Pokemon_Training_App.Data.PokemonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvForms
            // 
            this.dgvForms.AllowUserToAddRows = false;
            this.dgvForms.AllowUserToDeleteRows = false;
            this.dgvForms.AutoGenerateColumns = false;
            this.dgvForms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvForms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFormID,
            this.colPokeNum,
            this.colName,
            this.colBaseHealth,
            this.colBaseAttack,
            this.colBaseDefense,
            this.colBaseSpAttack,
            this.colBaseSpDefense,
            this.colBaseSpeed});
            this.dgvForms.DataSource = this.formsBindingSource;
            this.dgvForms.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvForms.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvForms.Location = new System.Drawing.Point(0, 0);
            this.dgvForms.MultiSelect = false;
            this.dgvForms.Name = "dgvForms";
            this.dgvForms.ReadOnly = true;
            this.dgvForms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvForms.Size = new System.Drawing.Size(884, 311);
            this.dgvForms.TabIndex = 1;
            this.dgvForms.TabStop = false;
            this.dgvForms.SelectionChanged += new System.EventHandler(this.dgvForms_SelectionChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(21, 323);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(74, 33);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(710, 323);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(74, 33);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(790, 323);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 33);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // colFormID
            // 
            this.colFormID.DataPropertyName = "FormID";
            this.colFormID.HeaderText = "FormID";
            this.colFormID.Name = "colFormID";
            this.colFormID.ReadOnly = true;
            this.colFormID.Visible = false;
            // 
            // colPokeNum
            // 
            this.colPokeNum.DataPropertyName = "PokeNum";
            this.colPokeNum.HeaderText = "PokeNum";
            this.colPokeNum.Name = "colPokeNum";
            this.colPokeNum.ReadOnly = true;
            this.colPokeNum.Visible = false;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.FillWeight = 200F;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colBaseHealth
            // 
            this.colBaseHealth.DataPropertyName = "BaseHealth";
            this.colBaseHealth.HeaderText = "Health";
            this.colBaseHealth.Name = "colBaseHealth";
            this.colBaseHealth.ReadOnly = true;
            // 
            // colBaseAttack
            // 
            this.colBaseAttack.DataPropertyName = "BaseAttack";
            this.colBaseAttack.HeaderText = "Attack";
            this.colBaseAttack.Name = "colBaseAttack";
            this.colBaseAttack.ReadOnly = true;
            // 
            // colBaseDefense
            // 
            this.colBaseDefense.DataPropertyName = "BaseDefense";
            this.colBaseDefense.HeaderText = "Defense";
            this.colBaseDefense.Name = "colBaseDefense";
            this.colBaseDefense.ReadOnly = true;
            // 
            // colBaseSpAttack
            // 
            this.colBaseSpAttack.DataPropertyName = "BaseSpAttack";
            this.colBaseSpAttack.HeaderText = "SpAttack";
            this.colBaseSpAttack.Name = "colBaseSpAttack";
            this.colBaseSpAttack.ReadOnly = true;
            // 
            // colBaseSpDefense
            // 
            this.colBaseSpDefense.DataPropertyName = "BaseSpDefense";
            this.colBaseSpDefense.HeaderText = "SpDefense";
            this.colBaseSpDefense.Name = "colBaseSpDefense";
            this.colBaseSpDefense.ReadOnly = true;
            // 
            // colBaseSpeed
            // 
            this.colBaseSpeed.DataPropertyName = "BaseSpeed";
            this.colBaseSpeed.HeaderText = "Speed";
            this.colBaseSpeed.Name = "colBaseSpeed";
            this.colBaseSpeed.ReadOnly = true;
            // 
            // frmPokemonForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 369);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvForms);
            this.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPokemonForms";
            this.Text = "Forms | #";
            this.Activated += new System.EventHandler(this.frmPokemonForms_Activated);
            this.Load += new System.EventHandler(this.frmPokemonForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Data.PokemonDataSet pokemonDataSet;
        private System.Windows.Forms.BindingSource formsBindingSource;
        private Data.PokemonDataSetTableAdapters.FormsTableAdapter formsTableAdapter;
        private Data.PokemonDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvForms;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFormID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPokeNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBaseHealth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBaseAttack;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBaseDefense;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBaseSpAttack;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBaseSpDefense;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBaseSpeed;
    }
}