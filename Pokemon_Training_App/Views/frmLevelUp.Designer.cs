namespace Pokemon_Training_App.Views
{
    partial class frmLevelUp
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
            this.slblHealthStat = new System.Windows.Forms.Label();
            this.slblSpeedStat = new System.Windows.Forms.Label();
            this.slblSpDefenseStat = new System.Windows.Forms.Label();
            this.slblSpAttackStat = new System.Windows.Forms.Label();
            this.slblDefenseStat = new System.Windows.Forms.Label();
            this.slblAttackStat = new System.Windows.Forms.Label();
            this.slblLevel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.numSpDefense = new System.Windows.Forms.NumericUpDown();
            this.numSpAttack = new System.Windows.Forms.NumericUpDown();
            this.numDefense = new System.Windows.Forms.NumericUpDown();
            this.numAttack = new System.Windows.Forms.NumericUpDown();
            this.numHealth = new System.Windows.Forms.NumericUpDown();
            this.numLevel = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // slblHealthStat
            // 
            this.slblHealthStat.AutoSize = true;
            this.slblHealthStat.Location = new System.Drawing.Point(11, 49);
            this.slblHealthStat.Name = "slblHealthStat";
            this.slblHealthStat.Size = new System.Drawing.Size(62, 22);
            this.slblHealthStat.TabIndex = 21;
            this.slblHealthStat.Text = "Health";
            // 
            // slblSpeedStat
            // 
            this.slblSpeedStat.AutoSize = true;
            this.slblSpeedStat.Location = new System.Drawing.Point(11, 244);
            this.slblSpeedStat.Name = "slblSpeedStat";
            this.slblSpeedStat.Size = new System.Drawing.Size(59, 22);
            this.slblSpeedStat.TabIndex = 17;
            this.slblSpeedStat.Text = "Speed";
            // 
            // slblSpDefenseStat
            // 
            this.slblSpDefenseStat.AutoSize = true;
            this.slblSpDefenseStat.Location = new System.Drawing.Point(11, 205);
            this.slblSpDefenseStat.Name = "slblSpDefenseStat";
            this.slblSpDefenseStat.Size = new System.Drawing.Size(95, 22);
            this.slblSpDefenseStat.TabIndex = 16;
            this.slblSpDefenseStat.Text = "SpDefense";
            // 
            // slblSpAttackStat
            // 
            this.slblSpAttackStat.AutoSize = true;
            this.slblSpAttackStat.Location = new System.Drawing.Point(11, 166);
            this.slblSpAttackStat.Name = "slblSpAttackStat";
            this.slblSpAttackStat.Size = new System.Drawing.Size(81, 22);
            this.slblSpAttackStat.TabIndex = 15;
            this.slblSpAttackStat.Text = "SpAttack";
            // 
            // slblDefenseStat
            // 
            this.slblDefenseStat.AutoSize = true;
            this.slblDefenseStat.Location = new System.Drawing.Point(11, 127);
            this.slblDefenseStat.Name = "slblDefenseStat";
            this.slblDefenseStat.Size = new System.Drawing.Size(75, 22);
            this.slblDefenseStat.TabIndex = 14;
            this.slblDefenseStat.Text = "Defense";
            // 
            // slblAttackStat
            // 
            this.slblAttackStat.AutoSize = true;
            this.slblAttackStat.Location = new System.Drawing.Point(11, 88);
            this.slblAttackStat.Name = "slblAttackStat";
            this.slblAttackStat.Size = new System.Drawing.Size(61, 22);
            this.slblAttackStat.TabIndex = 13;
            this.slblAttackStat.Text = "Attack";
            // 
            // slblLevel
            // 
            this.slblLevel.AutoSize = true;
            this.slblLevel.Location = new System.Drawing.Point(11, 10);
            this.slblLevel.Name = "slblLevel";
            this.slblLevel.Size = new System.Drawing.Size(53, 22);
            this.slblLevel.TabIndex = 26;
            this.slblLevel.Text = "Level";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(226, 282);
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
            this.btnConfirm.Location = new System.Drawing.Point(18, 282);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(87, 32);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // numSpeed
            // 
            this.numSpeed.Location = new System.Drawing.Point(178, 242);
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
            // numSpDefense
            // 
            this.numSpDefense.Location = new System.Drawing.Point(178, 203);
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
            // numSpAttack
            // 
            this.numSpAttack.Location = new System.Drawing.Point(178, 164);
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
            // numDefense
            // 
            this.numDefense.Location = new System.Drawing.Point(178, 125);
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
            // numAttack
            // 
            this.numAttack.Location = new System.Drawing.Point(178, 86);
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
            // numHealth
            // 
            this.numHealth.Location = new System.Drawing.Point(178, 47);
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
            // numLevel
            // 
            this.numLevel.Location = new System.Drawing.Point(178, 8);
            this.numLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLevel.Name = "numLevel";
            this.numLevel.Size = new System.Drawing.Size(139, 30);
            this.numLevel.TabIndex = 1;
            this.numLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Location = new System.Drawing.Point(122, 282);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 32);
            this.btnReset.TabIndex = 47;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmLevelUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 321);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.numSpeed);
            this.Controls.Add(this.numSpDefense);
            this.Controls.Add(this.numSpAttack);
            this.Controls.Add(this.numDefense);
            this.Controls.Add(this.numAttack);
            this.Controls.Add(this.numHealth);
            this.Controls.Add(this.numLevel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.slblLevel);
            this.Controls.Add(this.slblHealthStat);
            this.Controls.Add(this.slblSpeedStat);
            this.Controls.Add(this.slblSpDefenseStat);
            this.Controls.Add(this.slblSpAttackStat);
            this.Controls.Add(this.slblDefenseStat);
            this.Controls.Add(this.slblAttackStat);
            this.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmLevelUp";
            this.Text = "Level Up";
            this.Load += new System.EventHandler(this.frmLevelUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label slblHealthStat;
        private System.Windows.Forms.Label slblSpeedStat;
        private System.Windows.Forms.Label slblSpDefenseStat;
        private System.Windows.Forms.Label slblSpAttackStat;
        private System.Windows.Forms.Label slblDefenseStat;
        private System.Windows.Forms.Label slblAttackStat;
        private System.Windows.Forms.Label slblLevel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.NumericUpDown numSpDefense;
        private System.Windows.Forms.NumericUpDown numSpAttack;
        private System.Windows.Forms.NumericUpDown numDefense;
        private System.Windows.Forms.NumericUpDown numAttack;
        private System.Windows.Forms.NumericUpDown numHealth;
        private System.Windows.Forms.NumericUpDown numLevel;
        private System.Windows.Forms.Button btnReset;
    }
}