namespace Pokemon_Training_App.Views
{
    partial class frmSearchResultPokemon
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
            this.pokemonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokemonDataSet = new Pokemon_Training_App.Data.PokemonDataSet();
            this.pokemonTableAdapter = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.PokemonTableAdapter();
            this.lvwResults = new System.Windows.Forms.ListView();
            this.hdrNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNoResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).BeginInit();
            this.SuspendLayout();
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
            // lvwResults
            // 
            this.lvwResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrNumber,
            this.hdrName});
            this.lvwResults.FullRowSelect = true;
            this.lvwResults.GridLines = true;
            this.lvwResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwResults.HideSelection = false;
            this.lvwResults.Location = new System.Drawing.Point(12, 12);
            this.lvwResults.Name = "lvwResults";
            this.lvwResults.Size = new System.Drawing.Size(271, 249);
            this.lvwResults.TabIndex = 0;
            this.lvwResults.UseCompatibleStateImageBehavior = false;
            this.lvwResults.View = System.Windows.Forms.View.Details;
            // 
            // hdrNumber
            // 
            this.hdrNumber.Text = "Pokemon #";
            this.hdrNumber.Width = 126;
            // 
            // hdrName
            // 
            this.hdrName.Text = "Pokemon Name";
            this.hdrName.Width = 141;
            // 
            // lblNoResult
            // 
            this.lblNoResult.AutoSize = true;
            this.lblNoResult.Location = new System.Drawing.Point(66, 125);
            this.lblNoResult.Name = "lblNoResult";
            this.lblNoResult.Size = new System.Drawing.Size(162, 22);
            this.lblNoResult.TabIndex = 1;
            this.lblNoResult.Text = "---   NO RESULT   ---";
            this.lblNoResult.Visible = false;
            // 
            // frmSearchResultPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 340);
            this.Controls.Add(this.lblNoResult);
            this.Controls.Add(this.lvwResults);
            this.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSearchResultPokemon";
            this.Text = "Pokemon";
            this.Load += new System.EventHandler(this.frmSearchResultPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource pokemonBindingSource;
        private Data.PokemonDataSet pokemonDataSet;
        private Data.PokemonDataSetTableAdapters.PokemonTableAdapter pokemonTableAdapter;
        private System.Windows.Forms.ListView lvwResults;
        private System.Windows.Forms.ColumnHeader hdrNumber;
        private System.Windows.Forms.ColumnHeader hdrName;
        private System.Windows.Forms.Label lblNoResult;
    }
}