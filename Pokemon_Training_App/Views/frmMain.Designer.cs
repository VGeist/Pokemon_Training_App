namespace Pokemon_Training_App.Views
{
    partial class frmMain
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
            this.btnAddPokemon = new System.Windows.Forms.Button();
            this.btnAddPartner = new System.Windows.Forms.Button();
            this.btnSearchPokemon = new System.Windows.Forms.Button();
            this.btnSearchPartner = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTraining = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddPokemon
            // 
            this.btnAddPokemon.AutoSize = true;
            this.btnAddPokemon.Location = new System.Drawing.Point(43, 24);
            this.btnAddPokemon.Name = "btnAddPokemon";
            this.btnAddPokemon.Size = new System.Drawing.Size(176, 32);
            this.btnAddPokemon.TabIndex = 1;
            this.btnAddPokemon.Text = "Add Pokemon Data";
            this.btnAddPokemon.UseVisualStyleBackColor = true;
            this.btnAddPokemon.Click += new System.EventHandler(this.btnAddPokemon_Click);
            // 
            // btnAddPartner
            // 
            this.btnAddPartner.AutoSize = true;
            this.btnAddPartner.Location = new System.Drawing.Point(43, 64);
            this.btnAddPartner.Name = "btnAddPartner";
            this.btnAddPartner.Size = new System.Drawing.Size(176, 32);
            this.btnAddPartner.TabIndex = 2;
            this.btnAddPartner.Text = "Add Partner Data";
            this.btnAddPartner.UseVisualStyleBackColor = true;
            this.btnAddPartner.Click += new System.EventHandler(this.btnAddPartner_Click);
            // 
            // btnSearchPokemon
            // 
            this.btnSearchPokemon.AutoSize = true;
            this.btnSearchPokemon.Location = new System.Drawing.Point(299, 24);
            this.btnSearchPokemon.Name = "btnSearchPokemon";
            this.btnSearchPokemon.Size = new System.Drawing.Size(176, 32);
            this.btnSearchPokemon.TabIndex = 3;
            this.btnSearchPokemon.Text = "Search Pokemon";
            this.btnSearchPokemon.UseVisualStyleBackColor = true;
            this.btnSearchPokemon.Click += new System.EventHandler(this.btnSearchPokemon_Click);
            // 
            // btnSearchPartner
            // 
            this.btnSearchPartner.AutoSize = true;
            this.btnSearchPartner.Location = new System.Drawing.Point(299, 64);
            this.btnSearchPartner.Name = "btnSearchPartner";
            this.btnSearchPartner.Size = new System.Drawing.Size(176, 32);
            this.btnSearchPartner.TabIndex = 4;
            this.btnSearchPartner.Text = "Search Partner";
            this.btnSearchPartner.UseVisualStyleBackColor = true;
            this.btnSearchPartner.Click += new System.EventHandler(this.btnSearchPartner_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(196, 144);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 32);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTraining
            // 
            this.btnTraining.AutoSize = true;
            this.btnTraining.Location = new System.Drawing.Point(196, 104);
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.Size = new System.Drawing.Size(126, 32);
            this.btnTraining.TabIndex = 5;
            this.btnTraining.Text = "Training";
            this.btnTraining.UseVisualStyleBackColor = true;
            this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 201);
            this.Controls.Add(this.btnTraining);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearchPartner);
            this.Controls.Add(this.btnSearchPokemon);
            this.Controls.Add(this.btnAddPartner);
            this.Controls.Add(this.btnAddPokemon);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.Text = "EV/IV Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPokemon;
        private System.Windows.Forms.Button btnAddPartner;
        private System.Windows.Forms.Button btnSearchPokemon;
        private System.Windows.Forms.Button btnSearchPartner;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTraining;
    }
}