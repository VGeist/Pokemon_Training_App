namespace Pokemon_Training_App.Views
{
    partial class frmAddPartner
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.slblPokemonNum = new System.Windows.Forms.Label();
            this.slblNickname = new System.Windows.Forms.Label();
            this.slblNature = new System.Windows.Forms.Label();
            this.slblLevel = new System.Windows.Forms.Label();
            this.txtPokemonNum = new System.Windows.Forms.TextBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.cmbNature = new System.Windows.Forms.ComboBox();
            this.tabStats = new System.Windows.Forms.TabControl();
            this.tpgEV = new System.Windows.Forms.TabPage();
            this.txtHealthEV = new System.Windows.Forms.TextBox();
            this.slblHealthEV = new System.Windows.Forms.Label();
            this.txtSpeedEV = new System.Windows.Forms.TextBox();
            this.txtSpDefenseEV = new System.Windows.Forms.TextBox();
            this.txtSpAttackEV = new System.Windows.Forms.TextBox();
            this.txtDefenseEV = new System.Windows.Forms.TextBox();
            this.txtAttackEV = new System.Windows.Forms.TextBox();
            this.slblSpeedEV = new System.Windows.Forms.Label();
            this.slblSpDefenseEV = new System.Windows.Forms.Label();
            this.slblSpAttackEV = new System.Windows.Forms.Label();
            this.slblDefenseEV = new System.Windows.Forms.Label();
            this.slblAttackEV = new System.Windows.Forms.Label();
            this.cmbForm = new System.Windows.Forms.ComboBox();
            this.slblForm = new System.Windows.Forms.Label();
            this.btnAddForm = new System.Windows.Forms.Button();
            this.tpgStats = new System.Windows.Forms.TabPage();
            this.txtSpeedStat = new System.Windows.Forms.TextBox();
            this.slblSpeedStat = new System.Windows.Forms.Label();
            this.slblSpDefenseStat = new System.Windows.Forms.Label();
            this.txtSpDefenseStat = new System.Windows.Forms.TextBox();
            this.txtSpAttackStat = new System.Windows.Forms.TextBox();
            this.slblSpAttackStat = new System.Windows.Forms.Label();
            this.slblDefenseStat = new System.Windows.Forms.Label();
            this.txtDefenseStat = new System.Windows.Forms.TextBox();
            this.txtAttackStat = new System.Windows.Forms.TextBox();
            this.slblAttackStat = new System.Windows.Forms.Label();
            this.slblHealthStat = new System.Windows.Forms.Label();
            this.txtHealthStat = new System.Windows.Forms.TextBox();
            this.chkHasPokerus = new System.Windows.Forms.CheckBox();
            this.ttpPokerus = new System.Windows.Forms.ToolTip(this.components);
            this.tabStats.SuspendLayout();
            this.tpgEV.SuspendLayout();
            this.tpgStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(280, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 32);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(280, 349);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 32);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(280, 387);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // slblPokemonNum
            // 
            this.slblPokemonNum.AutoSize = true;
            this.slblPokemonNum.Location = new System.Drawing.Point(12, 15);
            this.slblPokemonNum.Name = "slblPokemonNum";
            this.slblPokemonNum.Size = new System.Drawing.Size(158, 22);
            this.slblPokemonNum.TabIndex = 3;
            this.slblPokemonNum.Text = "Pokemon Number";
            // 
            // slblNickname
            // 
            this.slblNickname.AutoSize = true;
            this.slblNickname.Location = new System.Drawing.Point(12, 53);
            this.slblNickname.Name = "slblNickname";
            this.slblNickname.Size = new System.Drawing.Size(91, 22);
            this.slblNickname.TabIndex = 4;
            this.slblNickname.Text = "Nickname";
            // 
            // slblNature
            // 
            this.slblNature.AutoSize = true;
            this.slblNature.Location = new System.Drawing.Point(12, 96);
            this.slblNature.Name = "slblNature";
            this.slblNature.Size = new System.Drawing.Size(66, 22);
            this.slblNature.TabIndex = 5;
            this.slblNature.Text = "Nature";
            // 
            // slblLevel
            // 
            this.slblLevel.AutoSize = true;
            this.slblLevel.Location = new System.Drawing.Point(266, 95);
            this.slblLevel.Name = "slblLevel";
            this.slblLevel.Size = new System.Drawing.Size(53, 22);
            this.slblLevel.TabIndex = 6;
            this.slblLevel.Text = "Level";
            // 
            // txtPokemonNum
            // 
            this.txtPokemonNum.Location = new System.Drawing.Point(185, 12);
            this.txtPokemonNum.Name = "txtPokemonNum";
            this.txtPokemonNum.Size = new System.Drawing.Size(180, 30);
            this.txtPokemonNum.TabIndex = 1;
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(185, 53);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(180, 30);
            this.txtNickname.TabIndex = 2;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(325, 94);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(40, 30);
            this.txtLevel.TabIndex = 4;
            // 
            // cmbNature
            // 
            this.cmbNature.FormattingEnabled = true;
            this.cmbNature.Items.AddRange(new object[] {
            "Calm",
            "Bold",
            "Hardy",
            "Bashful",
            "Relaxed",
            "TEMPORARY"});
            this.cmbNature.Location = new System.Drawing.Point(84, 93);
            this.cmbNature.MaxDropDownItems = 32;
            this.cmbNature.Name = "cmbNature";
            this.cmbNature.Size = new System.Drawing.Size(159, 30);
            this.cmbNature.TabIndex = 3;
            this.cmbNature.Text = "Hardy";
            // 
            // tabStats
            // 
            this.tabStats.Controls.Add(this.tpgStats);
            this.tabStats.Controls.Add(this.tpgEV);
            this.tabStats.Location = new System.Drawing.Point(16, 175);
            this.tabStats.Name = "tabStats";
            this.tabStats.SelectedIndex = 0;
            this.tabStats.Size = new System.Drawing.Size(258, 248);
            this.tabStats.TabIndex = 7;
            this.tabStats.TabStop = false;
            // 
            // tpgEV
            // 
            this.tpgEV.Controls.Add(this.txtHealthEV);
            this.tpgEV.Controls.Add(this.slblHealthEV);
            this.tpgEV.Controls.Add(this.txtSpeedEV);
            this.tpgEV.Controls.Add(this.txtSpDefenseEV);
            this.tpgEV.Controls.Add(this.txtSpAttackEV);
            this.tpgEV.Controls.Add(this.txtDefenseEV);
            this.tpgEV.Controls.Add(this.txtAttackEV);
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
            // txtHealthEV
            // 
            this.txtHealthEV.Location = new System.Drawing.Point(142, 9);
            this.txtHealthEV.Name = "txtHealthEV";
            this.txtHealthEV.Size = new System.Drawing.Size(100, 30);
            this.txtHealthEV.TabIndex = 8;
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
            // txtSpeedEV
            // 
            this.txtSpeedEV.Location = new System.Drawing.Point(142, 174);
            this.txtSpeedEV.Name = "txtSpeedEV";
            this.txtSpeedEV.Size = new System.Drawing.Size(100, 30);
            this.txtSpeedEV.TabIndex = 13;
            // 
            // txtSpDefenseEV
            // 
            this.txtSpDefenseEV.Location = new System.Drawing.Point(142, 141);
            this.txtSpDefenseEV.Name = "txtSpDefenseEV";
            this.txtSpDefenseEV.Size = new System.Drawing.Size(100, 30);
            this.txtSpDefenseEV.TabIndex = 12;
            // 
            // txtSpAttackEV
            // 
            this.txtSpAttackEV.Location = new System.Drawing.Point(142, 108);
            this.txtSpAttackEV.Name = "txtSpAttackEV";
            this.txtSpAttackEV.Size = new System.Drawing.Size(100, 30);
            this.txtSpAttackEV.TabIndex = 11;
            // 
            // txtDefenseEV
            // 
            this.txtDefenseEV.Location = new System.Drawing.Point(142, 75);
            this.txtDefenseEV.Name = "txtDefenseEV";
            this.txtDefenseEV.Size = new System.Drawing.Size(100, 30);
            this.txtDefenseEV.TabIndex = 10;
            // 
            // txtAttackEV
            // 
            this.txtAttackEV.Location = new System.Drawing.Point(142, 42);
            this.txtAttackEV.Name = "txtAttackEV";
            this.txtAttackEV.Size = new System.Drawing.Size(100, 30);
            this.txtAttackEV.TabIndex = 9;
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
            // cmbForm
            // 
            this.cmbForm.FormattingEnabled = true;
            this.cmbForm.Items.AddRange(new object[] {
            "Default",
            "Calm",
            "Bold",
            "Hardy",
            "Bashful",
            "Relaxed",
            "TEMPORARY"});
            this.cmbForm.Location = new System.Drawing.Point(84, 136);
            this.cmbForm.MaxDropDownItems = 32;
            this.cmbForm.Name = "cmbForm";
            this.cmbForm.Size = new System.Drawing.Size(159, 30);
            this.cmbForm.TabIndex = 5;
            this.cmbForm.Text = "Default";
            // 
            // slblForm
            // 
            this.slblForm.AutoSize = true;
            this.slblForm.Location = new System.Drawing.Point(12, 139);
            this.slblForm.Name = "slblForm";
            this.slblForm.Size = new System.Drawing.Size(53, 22);
            this.slblForm.TabIndex = 13;
            this.slblForm.Text = "Form";
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
            this.btnAddForm.Click += new System.EventHandler(this.btnAddForm_Click);
            // 
            // tpgStats
            // 
            this.tpgStats.Controls.Add(this.txtHealthStat);
            this.tpgStats.Controls.Add(this.slblHealthStat);
            this.tpgStats.Controls.Add(this.txtSpeedStat);
            this.tpgStats.Controls.Add(this.txtSpDefenseStat);
            this.tpgStats.Controls.Add(this.txtSpAttackStat);
            this.tpgStats.Controls.Add(this.txtDefenseStat);
            this.tpgStats.Controls.Add(this.txtAttackStat);
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
            // txtSpeedStat
            // 
            this.txtSpeedStat.Location = new System.Drawing.Point(142, 174);
            this.txtSpeedStat.Name = "txtSpeedStat";
            this.txtSpeedStat.Size = new System.Drawing.Size(100, 30);
            this.txtSpeedStat.TabIndex = 13;
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
            // txtSpDefenseStat
            // 
            this.txtSpDefenseStat.Location = new System.Drawing.Point(142, 141);
            this.txtSpDefenseStat.Name = "txtSpDefenseStat";
            this.txtSpDefenseStat.Size = new System.Drawing.Size(100, 30);
            this.txtSpDefenseStat.TabIndex = 12;
            // 
            // txtSpAttackStat
            // 
            this.txtSpAttackStat.Location = new System.Drawing.Point(142, 108);
            this.txtSpAttackStat.Name = "txtSpAttackStat";
            this.txtSpAttackStat.Size = new System.Drawing.Size(100, 30);
            this.txtSpAttackStat.TabIndex = 11;
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
            // txtDefenseStat
            // 
            this.txtDefenseStat.Location = new System.Drawing.Point(142, 75);
            this.txtDefenseStat.Name = "txtDefenseStat";
            this.txtDefenseStat.Size = new System.Drawing.Size(100, 30);
            this.txtDefenseStat.TabIndex = 10;
            // 
            // txtAttackStat
            // 
            this.txtAttackStat.Location = new System.Drawing.Point(142, 42);
            this.txtAttackStat.Name = "txtAttackStat";
            this.txtAttackStat.Size = new System.Drawing.Size(100, 30);
            this.txtAttackStat.TabIndex = 9;
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
            // slblHealthStat
            // 
            this.slblHealthStat.AutoSize = true;
            this.slblHealthStat.Location = new System.Drawing.Point(8, 12);
            this.slblHealthStat.Name = "slblHealthStat";
            this.slblHealthStat.Size = new System.Drawing.Size(62, 22);
            this.slblHealthStat.TabIndex = 10;
            this.slblHealthStat.Text = "Health";
            // 
            // txtHealthStat
            // 
            this.txtHealthStat.Location = new System.Drawing.Point(142, 9);
            this.txtHealthStat.Name = "txtHealthStat";
            this.txtHealthStat.Size = new System.Drawing.Size(100, 30);
            this.txtHealthStat.TabIndex = 8;
            // 
            // chkHasPokerus
            // 
            this.chkHasPokerus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chkHasPokerus.Image = global::Pokemon_Training_App.Properties.Resources.PokérusIC_infected;
            this.chkHasPokerus.Location = new System.Drawing.Point(292, 204);
            this.chkHasPokerus.Name = "chkHasPokerus";
            this.chkHasPokerus.Size = new System.Drawing.Size(73, 51);
            this.chkHasPokerus.TabIndex = 14;
            this.ttpPokerus.SetToolTip(this.chkHasPokerus, "Check if pokemon has (or had) Pokerus.\r\nPokemon with Pokerus gain EVs faster.");
            this.chkHasPokerus.UseVisualStyleBackColor = true;
            // 
            // ttpPokerus
            // 
            this.ttpPokerus.ToolTipTitle = "Pokerus";
            // 
            // frmAddPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 428);
            this.Controls.Add(this.chkHasPokerus);
            this.Controls.Add(this.btnAddForm);
            this.Controls.Add(this.cmbForm);
            this.Controls.Add(this.slblForm);
            this.Controls.Add(this.tabStats);
            this.Controls.Add(this.cmbNature);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.txtPokemonNum);
            this.Controls.Add(this.slblLevel);
            this.Controls.Add(this.slblNature);
            this.Controls.Add(this.slblNickname);
            this.Controls.Add(this.slblPokemonNum);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAddPartner";
            this.Text = "New Partner Entry";
            this.tabStats.ResumeLayout(false);
            this.tpgEV.ResumeLayout(false);
            this.tpgEV.PerformLayout();
            this.tpgStats.ResumeLayout(false);
            this.tpgStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label slblPokemonNum;
        private System.Windows.Forms.Label slblNickname;
        private System.Windows.Forms.Label slblNature;
        private System.Windows.Forms.Label slblLevel;
        private System.Windows.Forms.TextBox txtPokemonNum;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.ComboBox cmbNature;
        private System.Windows.Forms.TabControl tabStats;
        private System.Windows.Forms.TabPage tpgEV;
        private System.Windows.Forms.TextBox txtHealthEV;
        private System.Windows.Forms.Label slblHealthEV;
        private System.Windows.Forms.TextBox txtSpeedEV;
        private System.Windows.Forms.TextBox txtSpDefenseEV;
        private System.Windows.Forms.TextBox txtSpAttackEV;
        private System.Windows.Forms.TextBox txtDefenseEV;
        private System.Windows.Forms.TextBox txtAttackEV;
        private System.Windows.Forms.Label slblSpeedEV;
        private System.Windows.Forms.Label slblSpDefenseEV;
        private System.Windows.Forms.Label slblSpAttackEV;
        private System.Windows.Forms.Label slblDefenseEV;
        private System.Windows.Forms.Label slblAttackEV;
        private System.Windows.Forms.ComboBox cmbForm;
        private System.Windows.Forms.Label slblForm;
        private System.Windows.Forms.Button btnAddForm;
        private System.Windows.Forms.TabPage tpgStats;
        private System.Windows.Forms.TextBox txtHealthStat;
        private System.Windows.Forms.Label slblHealthStat;
        private System.Windows.Forms.TextBox txtSpeedStat;
        private System.Windows.Forms.TextBox txtSpDefenseStat;
        private System.Windows.Forms.TextBox txtSpAttackStat;
        private System.Windows.Forms.TextBox txtDefenseStat;
        private System.Windows.Forms.TextBox txtAttackStat;
        private System.Windows.Forms.Label slblSpeedStat;
        private System.Windows.Forms.Label slblSpDefenseStat;
        private System.Windows.Forms.Label slblSpAttackStat;
        private System.Windows.Forms.Label slblDefenseStat;
        private System.Windows.Forms.Label slblAttackStat;
        private System.Windows.Forms.CheckBox chkHasPokerus;
        private System.Windows.Forms.ToolTip ttpPokerus;
    }
}