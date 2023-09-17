namespace Duolingo_2._0
{
    partial class frmPrincipal
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
            this.btnJ = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnhs = new System.Windows.Forms.Button();
            this.lblF = new System.Windows.Forms.TextBox();
            this.txtbR = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pgb = new System.Windows.Forms.ProgressBar();
            this.lblQ = new System.Windows.Forms.Label();
            this.hs = new System.Windows.Forms.Timer(this.components);
            this.ex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJ
            // 
            this.btnJ.Location = new System.Drawing.Point(168, 194);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(118, 36);
            this.btnJ.TabIndex = 0;
            this.btnJ.Text = "Jogar";
            this.btnJ.UseVisualStyleBackColor = true;
            this.btnJ.Click += new System.EventHandler(this.btnJ_Click);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(168, 278);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(118, 36);
            this.btnT.TabIndex = 1;
            this.btnT.Text = "Como jogar";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(168, 236);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(118, 36);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "Configurações";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(168, 320);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(118, 36);
            this.btnS.TabIndex = 3;
            this.btnS.Text = "Sair";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(540, 376);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(118, 36);
            this.btnE.TabIndex = 4;
            this.btnE.Text = "Enviar";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Visible = false;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(168, 412);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(118, 36);
            this.btnR.TabIndex = 5;
            this.btnR.Text = "Tentar Novamente";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Visible = false;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(168, 454);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(118, 36);
            this.btnM.TabIndex = 6;
            this.btnM.Text = "Menu";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Visible = false;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnhs
            // 
            this.btnhs.Location = new System.Drawing.Point(168, 496);
            this.btnhs.Name = "btnhs";
            this.btnhs.Size = new System.Drawing.Size(118, 36);
            this.btnhs.TabIndex = 7;
            this.btnhs.Text = "Highcore";
            this.btnhs.UseVisualStyleBackColor = true;
            this.btnhs.Visible = false;
            this.btnhs.Click += new System.EventHandler(this.btnhs_Click);
            // 
            // lblF
            // 
            this.lblF.Location = new System.Drawing.Point(415, 284);
            this.lblF.Name = "lblF";
            this.lblF.ReadOnly = true;
            this.lblF.Size = new System.Drawing.Size(356, 20);
            this.lblF.TabIndex = 8;
            this.lblF.Visible = false;
            // 
            // txtbR
            // 
            this.txtbR.Location = new System.Drawing.Point(415, 350);
            this.txtbR.Name = "txtbR";
            this.txtbR.Size = new System.Drawing.Size(356, 20);
            this.txtbR.TabIndex = 9;
            this.txtbR.Visible = false;
            this.txtbR.TextChanged += new System.EventHandler(this.txtbR_TextChanged);
            this.txtbR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbR_KeyPress);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Duolingo_2._0.Properties.Resources.duofeliz;
            this.pictureBox3.Location = new System.Drawing.Point(539, 103);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(199, 175);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Duolingo_2._0.Properties.Resources.trilingo;
            this.pictureBox2.Location = new System.Drawing.Point(415, 405);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(314, 271);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // pgb
            // 
            this.pgb.Location = new System.Drawing.Point(-2, 664);
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(1267, 23);
            this.pgb.TabIndex = 12;
            this.pgb.Visible = false;
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblQ.Location = new System.Drawing.Point(461, 60);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(268, 40);
            this.lblQ.TabIndex = 13;
            this.lblQ.Text = "Traduza essa frase";
            this.lblQ.Visible = false;
            // 
            // hs
            // 
            this.hs.Interval = 1000;
            this.hs.Tick += new System.EventHandler(this.hs_Tick);
            // 
            // ex
            // 
            this.ex.AutoSize = true;
            this.ex.Location = new System.Drawing.Point(12, 9);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(35, 13);
            this.ex.TabIndex = 14;
            this.ex.Text = "label1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ex);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.pgb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtbR);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.btnhs);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnJ);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnhs;
        private System.Windows.Forms.TextBox lblF;
        private System.Windows.Forms.TextBox txtbR;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ProgressBar pgb;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Timer hs;
        private System.Windows.Forms.Label ex;
    }
}