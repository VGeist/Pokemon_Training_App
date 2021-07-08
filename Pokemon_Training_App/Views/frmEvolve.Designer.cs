namespace Pokemon_Training_App.Views
{
    partial class frmEvolve
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEvolve = new System.Windows.Forms.Button();
            this.slblNumber = new System.Windows.Forms.Label();
            this.slblHealthStat = new System.Windows.Forms.Label();
            this.slblSpeedStat = new System.Windows.Forms.Label();
            this.slblSpDefenseStat = new System.Windows.Forms.Label();
            this.slblSpAttackStat = new System.Windows.Forms.Label();
            this.slblDefenseStat = new System.Windows.Forms.Label();
            this.slblAttackStat = new System.Windows.Forms.Label();
            this.numPokeNum = new System.Windows.Forms.NumericUpDown();
            this.numHealth = new System.Windows.Forms.NumericUpDown();
            this.numAttack = new System.Windows.Forms.NumericUpDown();
            this.numDefense = new System.Windows.Forms.NumericUpDown();
            this.numSpAttack = new System.Windows.Forms.NumericUpDown();
            this.numSpDefense = new System.Windows.Forms.NumericUpDown();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPokeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(138, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnEvolve
            // 
            this.btnEvolve.AutoSize = true;
            this.btnEvolve.Location = new System.Drawing.Point(33, 247);
            this.btnEvolve.Name = "btnEvolve";
            this.btnEvolve.Size = new System.Drawing.Size(87, 32);
            this.btnEvolve.TabIndex = 8;
            this.btnEvolve.Text = "Evolve";
            this.btnEvolve.UseVisualStyleBackColor = true;
            // 
            // slblNumber
            // 
            this.slblNumber.AutoSize = true;
            this.slblNumber.Location = new System.Drawing.Point(11, 10);
            this.slblNumber.Name = "slblNumber";
            this.slblNumber.Size = new System.Drawing.Size(103, 22);
            this.slblNumber.TabIndex = 42;
            this.slblNumber.Text = "Pokemon #";
            // 
            // slblHealthStat
            // 
            this.slblHealthStat.AutoSize = true;
            this.slblHealthStat.Location = new System.Drawing.Point(11, 43);
            this.slblHealthStat.Name = "slblHealthStat";
            this.slblHealthStat.Size = new System.Drawing.Size(62, 22);
            this.slblHealthStat.TabIndex = 41;
            this.slblHealthStat.Text = "Health";
            // 
            // slblSpeedStat
            // 
            this.slblSpeedStat.AutoSize = true;
            this.slblSpeedStat.Location = new System.Drawing.Point(11, 207);
            this.slblSpeedStat.Name = "slblSpeedStat";
            this.slblSpeedStat.Size = new System.Drawing.Size(59, 22);
            this.slblSpeedStat.TabIndex = 40;
            this.slblSpeedStat.Text = "Speed";
            // 
            // slblSpDefenseStat
            // 
            this.slblSpDefenseStat.AutoSize = true;
            this.slblSpDefenseStat.Location = new System.Drawing.Point(11, 175);
            this.slblSpDefenseStat.Name = "slblSpDefenseStat";
            this.slblSpDefenseStat.Size = new System.Drawing.Size(95, 22);
            this.slblSpDefenseStat.TabIndex = 39;
            this.slblSpDefenseStat.Text = "SpDefense";
            // 
            // slblSpAttackStat
            // 
            this.slblSpAttackStat.AutoSize = true;
            this.slblSpAttackStat.Location = new System.Drawing.Point(11, 142);
            this.slblSpAttackStat.Name = "slblSpAttackStat";
            this.slblSpAttackStat.Size = new System.Drawing.Size(81, 22);
            this.slblSpAttackStat.TabIndex = 38;
            this.slblSpAttackStat.Text = "SpAttack";
            // 
            // slblDefenseStat
            // 
            this.slblDefenseStat.AutoSize = true;
            this.slblDefenseStat.Location = new System.Drawing.Point(11, 109);
            this.slblDefenseStat.Name = "slblDefenseStat";
            this.slblDefenseStat.Size = new System.Drawing.Size(75, 22);
            this.slblDefenseStat.TabIndex = 37;
            this.slblDefenseStat.Text = "Defense";
            // 
            // slblAttackStat
            // 
            this.slblAttackStat.AutoSize = true;
            this.slblAttackStat.Location = new System.Drawing.Point(11, 76);
            this.slblAttackStat.Name = "slblAttackStat";
            this.slblAttackStat.Size = new System.Drawing.Size(61, 22);
            this.slblAttackStat.TabIndex = 36;
            this.slblAttackStat.Text = "Attack";
            // 
            // numPokeNum
            // 
            this.numPokeNum.Location = new System.Drawing.Point(145, 7);
            this.numPokeNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPokeNum.Name = "numPokeNum";
            this.numPokeNum.Size = new System.Drawing.Size(100, 30);
            this.numPokeNum.TabIndex = 1;
            // 
            // numHealth
            // 
            this.numHealth.Location = new System.Drawing.Point(145, 41);
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
            this.numHealth.Size = new System.Drawing.Size(100, 30);
            this.numHealth.TabIndex = 2;
            this.numHealth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numAttack
            // 
            this.numAttack.Location = new System.Drawing.Point(145, 74);
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
            this.numAttack.Size = new System.Drawing.Size(100, 30);
            this.numAttack.TabIndex = 3;
            this.numAttack.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numDefense
            // 
            this.numDefense.Location = new System.Drawing.Point(145, 107);
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
            this.numDefense.Size = new System.Drawing.Size(100, 30);
            this.numDefense.TabIndex = 4;
            this.numDefense.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numSpAttack
            // 
            this.numSpAttack.Location = new System.Drawing.Point(145, 140);
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
            this.numSpAttack.Size = new System.Drawing.Size(100, 30);
            this.numSpAttack.TabIndex = 5;
            this.numSpAttack.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numSpDefense
            // 
            this.numSpDefense.Location = new System.Drawing.Point(145, 173);
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
            this.numSpDefense.Size = new System.Drawing.Size(100, 30);
            this.numSpDefense.TabIndex = 6;
            this.numSpDefense.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numSpeed
            // 
            this.numSpeed.Location = new System.Drawing.Point(145, 206);
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
            this.numSpeed.Size = new System.Drawing.Size(100, 30);
            this.numSpeed.TabIndex = 7;
            this.numSpeed.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // frmEvolve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 286);
            this.Controls.Add(this.numSpeed);
            this.Controls.Add(this.numSpDefense);
            this.Controls.Add(this.numSpAttack);
            this.Controls.Add(this.numDefense);
            this.Controls.Add(this.numAttack);
            this.Controls.Add(this.numHealth);
            this.Controls.Add(this.numPokeNum);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEvolve);
            this.Controls.Add(this.slblNumber);
            this.Controls.Add(this.slblHealthStat);
            this.Controls.Add(this.slblSpeedStat);
            this.Controls.Add(this.slblSpDefenseStat);
            this.Controls.Add(this.slblSpAttackStat);
            this.Controls.Add(this.slblDefenseStat);
            this.Controls.Add(this.slblAttackStat);
            this.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmEvolve";
            this.Text = "frmEvolve";
            ((System.ComponentModel.ISupportInitialize)(this.numPokeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEvolve;
        private System.Windows.Forms.Label slblNumber;
        private System.Windows.Forms.Label slblHealthStat;
        private System.Windows.Forms.Label slblSpeedStat;
        private System.Windows.Forms.Label slblSpDefenseStat;
        private System.Windows.Forms.Label slblSpAttackStat;
        private System.Windows.Forms.Label slblDefenseStat;
        private System.Windows.Forms.Label slblAttackStat;
        private System.Windows.Forms.NumericUpDown numPokeNum;
        private System.Windows.Forms.NumericUpDown numHealth;
        private System.Windows.Forms.NumericUpDown numAttack;
        private System.Windows.Forms.NumericUpDown numDefense;
        private System.Windows.Forms.NumericUpDown numSpAttack;
        private System.Windows.Forms.NumericUpDown numSpDefense;
        private System.Windows.Forms.NumericUpDown numSpeed;
    }
}