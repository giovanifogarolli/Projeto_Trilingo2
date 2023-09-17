namespace Duolingo_2._0
{
    partial class frmEsqueciSenha
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReenviaEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviaCodigo = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.lblReenviaEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnEnviaCodigo);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(268, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 366);
            this.panel1.TabIndex = 0;
            // 
            // lblReenviaEmail
            // 
            this.lblReenviaEmail.AutoSize = true;
            this.lblReenviaEmail.BackColor = System.Drawing.Color.Salmon;
            this.lblReenviaEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReenviaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReenviaEmail.ForeColor = System.Drawing.SystemColors.Info;
            this.lblReenviaEmail.Location = new System.Drawing.Point(292, 288);
            this.lblReenviaEmail.Name = "lblReenviaEmail";
            this.lblReenviaEmail.Size = new System.Drawing.Size(210, 31);
            this.lblReenviaEmail.TabIndex = 4;
            this.lblReenviaEmail.Text = "Reenviar código";
            this.lblReenviaEmail.Click += new System.EventHandler(this.lblReenviaEmail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(32, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insira o código: ";
            // 
            // btnEnviaCodigo
            // 
            this.btnEnviaCodigo.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnEnviaCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviaCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviaCodigo.Location = new System.Drawing.Point(594, 203);
            this.btnEnviaCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.btnEnviaCodigo.Name = "btnEnviaCodigo";
            this.btnEnviaCodigo.Size = new System.Drawing.Size(126, 38);
            this.btnEnviaCodigo.TabIndex = 2;
            this.btnEnviaCodigo.Text = "Enviar";
            this.btnEnviaCodigo.UseVisualStyleBackColor = false;
            this.btnEnviaCodigo.Click += new System.EventHandler(this.btnEnviaCodigo_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(268, 203);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(320, 38);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "Um código foi enviado para seu email, insira o código \r\nno campo abaixo.\r\nCheque " +
    "a caixa de spam.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmEsqueciSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel1);
            this.Name = "frmEsqueciSenha";
            this.Text = "Esqueci a senha";
            this.Load += new System.EventHandler(this.frmEsqueciSenha_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReenviaEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviaCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}