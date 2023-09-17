namespace Duolingo_2._0
{
    partial class frmConfig
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
            this.gpbL = new System.Windows.Forms.GroupBox();
            this.rdbJ = new System.Windows.Forms.RadioButton();
            this.rdbI = new System.Windows.Forms.RadioButton();
            this.gpbD = new System.Windows.Forms.GroupBox();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.gpbL.SuspendLayout();
            this.gpbD.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbL
            // 
            this.gpbL.Controls.Add(this.rdbJ);
            this.gpbL.Controls.Add(this.rdbI);
            this.gpbL.Location = new System.Drawing.Point(27, 37);
            this.gpbL.Name = "gpbL";
            this.gpbL.Size = new System.Drawing.Size(200, 100);
            this.gpbL.TabIndex = 0;
            this.gpbL.TabStop = false;
            this.gpbL.Text = "Selecione a Linguagem";
            // 
            // rdbJ
            // 
            this.rdbJ.AutoSize = true;
            this.rdbJ.Location = new System.Drawing.Point(108, 47);
            this.rdbJ.Name = "rdbJ";
            this.rdbJ.Size = new System.Drawing.Size(59, 17);
            this.rdbJ.TabIndex = 1;
            this.rdbJ.TabStop = true;
            this.rdbJ.Text = "Italiano";
            this.rdbJ.UseVisualStyleBackColor = true;
            this.rdbJ.CheckedChanged += new System.EventHandler(this.rdbJ_CheckedChanged);
            // 
            // rdbI
            // 
            this.rdbI.AutoSize = true;
            this.rdbI.Location = new System.Drawing.Point(28, 47);
            this.rdbI.Name = "rdbI";
            this.rdbI.Size = new System.Drawing.Size(53, 17);
            this.rdbI.TabIndex = 0;
            this.rdbI.TabStop = true;
            this.rdbI.Text = "Inglês";
            this.rdbI.UseVisualStyleBackColor = true;
            this.rdbI.CheckedChanged += new System.EventHandler(this.rdbI_CheckedChanged_1);
            // 
            // gpbD
            // 
            this.gpbD.Controls.Add(this.rdbF);
            this.gpbD.Controls.Add(this.rdbM);
            this.gpbD.Controls.Add(this.rdbD);
            this.gpbD.Location = new System.Drawing.Point(27, 170);
            this.gpbD.Name = "gpbD";
            this.gpbD.Size = new System.Drawing.Size(200, 100);
            this.gpbD.TabIndex = 1;
            this.gpbD.TabStop = false;
            this.gpbD.Text = "Selecione a dificuldade";
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Location = new System.Drawing.Point(15, 50);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(47, 17);
            this.rdbF.TabIndex = 2;
            this.rdbF.TabStop = true;
            this.rdbF.Text = "Facil";
            this.rdbF.UseVisualStyleBackColor = true;
            this.rdbF.CheckedChanged += new System.EventHandler(this.rdbF_CheckedChanged_1);
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Location = new System.Drawing.Point(70, 50);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(54, 17);
            this.rdbM.TabIndex = 1;
            this.rdbM.TabStop = true;
            this.rdbM.Text = "Médio";
            this.rdbM.UseVisualStyleBackColor = true;
            this.rdbM.CheckedChanged += new System.EventHandler(this.rdbM_CheckedChanged_1);
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Location = new System.Drawing.Point(135, 50);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(50, 17);
            this.rdbD.TabIndex = 0;
            this.rdbD.TabStop = true;
            this.rdbD.Text = "Dificil";
            this.rdbD.UseVisualStyleBackColor = true;
            this.rdbD.CheckedChanged += new System.EventHandler(this.rdbD_CheckedChanged_1);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 303);
            this.Controls.Add(this.gpbD);
            this.Controls.Add(this.gpbL);
            this.Name = "frmConfig";
            this.Text = "Config";
            this.gpbL.ResumeLayout(false);
            this.gpbL.PerformLayout();
            this.gpbD.ResumeLayout(false);
            this.gpbD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbL;
        private System.Windows.Forms.RadioButton rdbJ;
        private System.Windows.Forms.RadioButton rdbI;
        private System.Windows.Forms.GroupBox gpbD;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.RadioButton rdbD;
    }
}