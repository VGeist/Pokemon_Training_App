namespace Pokemon_Training_App.Views
{
    partial class frmSearchPokemon
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
            this.slblPokemonNum = new System.Windows.Forms.Label();
            this.txtPokemonName = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.radName = new System.Windows.Forms.RadioButton();
            this.radNumber = new System.Windows.Forms.RadioButton();
            this.pokemonDataSet = new Pokemon_Training_App.Data.PokemonDataSet();
            this.pokemonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokemonTableAdapter = new Pokemon_Training_App.Data.PokemonDataSetTableAdapters.PokemonTableAdapter();
            this.numPokeNum = new System.Windows.Forms.NumericUpDown();
            this.btnGetAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPokeNum)).BeginInit();
            this.SuspendLayout();
            // 
            // slblPokemonName
            // 
            this.slblPokemonName.AutoSize = true;
            this.slblPokemonName.Enabled = false;
            this.slblPokemonName.Location = new System.Drawing.Point(47, 75);
            this.slblPokemonName.Name = "slblPokemonName";
            this.slblPokemonName.Size = new System.Drawing.Size(143, 22);
            this.slblPokemonName.TabIndex = 0;
            this.slblPokemonName.Text = "Pokemon Name:";
            // 
            // slblPokemonNum
            // 
            this.slblPokemonNum.AutoSize = true;
            this.slblPokemonNum.Location = new System.Drawing.Point(47, 22);
            this.slblPokemonNum.Name = "slblPokemonNum";
            this.slblPokemonNum.Size = new System.Drawing.Size(163, 22);
            this.slblPokemonNum.TabIndex = 1;
            this.slblPokemonNum.Text = "Pokemon Number:";
            // 
            // txtPokemonName
            // 
            this.txtPokemonName.Enabled = false;
            this.txtPokemonName.Location = new System.Drawing.Point(216, 73);
            this.txtPokemonName.Name = "txtPokemonName";
            this.txtPokemonName.Size = new System.Drawing.Size(201, 30);
            this.txtPokemonName.TabIndex = 2;
            // 
            // btnApply
            // 
            this.btnApply.AutoSize = true;
            this.btnApply.Location = new System.Drawing.Point(173, 126);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(85, 32);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(296, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // radName
            // 
            this.radName.AutoSize = true;
            this.radName.Location = new System.Drawing.Point(17, 80);
            this.radName.Name = "radName";
            this.radName.Size = new System.Drawing.Size(14, 13);
            this.radName.TabIndex = 10;
            this.radName.UseVisualStyleBackColor = true;
            this.radName.CheckedChanged += new System.EventHandler(this.radName_CheckedChanged);
            // 
            // radNumber
            // 
            this.radNumber.AutoSize = true;
            this.radNumber.Checked = true;
            this.radNumber.Location = new System.Drawing.Point(17, 27);
            this.radNumber.Name = "radNumber";
            this.radNumber.Size = new System.Drawing.Size(14, 13);
            this.radNumber.TabIndex = 10;
            this.radNumber.TabStop = true;
            this.radNumber.UseVisualStyleBackColor = true;
            this.radNumber.CheckedChanged += new System.EventHandler(this.radNumber_CheckedChanged);
            // 
            // pokemonDataSet
            // 
            this.pokemonDataSet.DataSetName = "PokemonDataSet";
            this.pokemonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pokemonBindingSource
            // 
            this.pokemonBindingSource.DataSource = this.pokemonDataSet;
            this.pokemonBindingSource.Position = 0;
            // 
            // pokemonTableAdapter
            // 
            this.pokemonTableAdapter.ClearBeforeFill = true;
            // 
            // numPokeNum
            // 
            this.numPokeNum.Location = new System.Drawing.Point(216, 20);
            this.numPokeNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPokeNum.Name = "numPokeNum";
            this.numPokeNum.Size = new System.Drawing.Size(85, 30);
            this.numPokeNum.TabIndex = 1;
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(50, 126);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(85, 32);
            this.btnGetAll.TabIndex = 12;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // frmSearchPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 176);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.numPokeNum);
            this.Controls.Add(this.radNumber);
            this.Controls.Add(this.radName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtPokemonName);
            this.Controls.Add(this.slblPokemonNum);
            this.Controls.Add(this.slblPokemonName);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSearchPokemon";
            this.Text = "Find Pokemon";
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPokeNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label slblPokemonName;
        private System.Windows.Forms.Label slblPokemonNum;
        private System.Windows.Forms.TextBox txtPokemonName;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton radName;
        private System.Windows.Forms.RadioButton radNumber;
        private Data.PokemonDataSet pokemonDataSet;
        private System.Windows.Forms.BindingSource pokemonBindingSource;
        private Data.PokemonDataSetTableAdapters.PokemonTableAdapter pokemonTableAdapter;
        private System.Windows.Forms.NumericUpDown numPokeNum;
        private System.Windows.Forms.Button btnGetAll;
    }
}