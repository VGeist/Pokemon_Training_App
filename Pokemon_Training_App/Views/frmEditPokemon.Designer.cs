namespace Pokemon_Training_App.Views
{
    partial class frmEditPokemon
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
            this.slblPokemonName = new System.Windows.Forms.Label();
            this.slblPokemonNumber = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPokemonName = new System.Windows.Forms.TextBox();
            this.pokemonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokemonDataSet = new Pokemon_Training_App.Data.PokemonDataSet();
            this.pokemonTableAdapter = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.PokemonTableAdapter();
            this.tableAdapterManager = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.TableAdapterManager();
            this.lblPokeNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // slblPokemonName
            // 
            this.slblPokemonName.AutoSize = true;
            this.slblPokemonName.Location = new System.Drawing.Point(12, 61);
            this.slblPokemonName.Name = "slblPokemonName";
            this.slblPokemonName.Size = new System.Drawing.Size(138, 22);
            this.slblPokemonName.TabIndex = 28;
            this.slblPokemonName.Text = "Pokemon Name";
            // 
            // slblPokemonNumber
            // 
            this.slblPokemonNumber.AutoSize = true;
            this.slblPokemonNumber.Location = new System.Drawing.Point(12, 15);
            this.slblPokemonNumber.Name = "slblPokemonNumber";
            this.slblPokemonNumber.Size = new System.Drawing.Size(158, 22);
            this.slblPokemonNumber.TabIndex = 27;
            this.slblPokemonNumber.Text = "Pokemon Number";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(180, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Entry";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(85, 100);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(89, 30);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(305, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPokemonName
            // 
            this.txtPokemonName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokemonBindingSource, "Name", true));
            this.txtPokemonName.Location = new System.Drawing.Point(190, 58);
            this.txtPokemonName.Name = "txtPokemonName";
            this.txtPokemonName.Size = new System.Drawing.Size(185, 30);
            this.txtPokemonName.TabIndex = 2;
            // 
            // pokemonBindingSource
            // 
            this.pokemonBindingSource.DataMember = "Pokemon";
            this.pokemonBindingSource.DataSource = this.pokemonDataSet;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FormsTableAdapter = null;
            this.tableAdapterManager.NaturesTableAdapter = null;
            this.tableAdapterManager.PokemonTableAdapter = this.pokemonTableAdapter;
            this.tableAdapterManager.UpdateOrder = Pokemon_Training_App.Data.PokemonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblPokeNum
            // 
            this.lblPokeNum.AutoSize = true;
            this.lblPokeNum.Location = new System.Drawing.Point(186, 15);
            this.lblPokeNum.Name = "lblPokeNum";
            this.lblPokeNum.Size = new System.Drawing.Size(46, 22);
            this.lblPokeNum.TabIndex = 29;
            this.lblPokeNum.Text = "###";
            // 
            // frmEditPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 138);
            this.Controls.Add(this.lblPokeNum);
            this.Controls.Add(this.slblPokemonName);
            this.Controls.Add(this.slblPokemonNumber);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPokemonName);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEditPokemon";
            this.Text = "Edit Pokemon Entry";
            this.Load += new System.EventHandler(this.frmEditPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label slblPokemonName;
        private System.Windows.Forms.Label slblPokemonNumber;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPokemonName;
        private Data.PokemonDataSet pokemonDataSet;
        private System.Windows.Forms.BindingSource pokemonBindingSource;
        private Data.PokemonDataSetTableAdapters.PokemonTableAdapter pokemonTableAdapter;
        private Data.PokemonDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblPokeNum;
    }
}