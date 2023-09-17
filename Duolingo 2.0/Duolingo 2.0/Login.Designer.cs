namespace Duolingo_2._0
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoginNome = new System.Windows.Forms.TextBox();
            this.txtLoginSenha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMostraSenha = new System.Windows.Forms.Label();
            this.btnLogar = new System.Windows.Forms.Button();
            this.lblLoginCadastrar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLoginEsqueciSenha = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(172, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(35, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(35, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // txtLoginNome
            // 
            this.txtLoginNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginNome.Location = new System.Drawing.Point(142, 117);
            this.txtLoginNome.Name = "txtLoginNome";
            this.txtLoginNome.Size = new System.Drawing.Size(274, 38);
            this.txtLoginNome.TabIndex = 3;
            // 
            // txtLoginSenha
            // 
            this.txtLoginSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginSenha.Location = new System.Drawing.Point(142, 211);
            this.txtLoginSenha.Name = "txtLoginSenha";
            this.txtLoginSenha.Size = new System.Drawing.Size(274, 38);
            this.txtLoginSenha.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.lblMostraSenha);
            this.panel1.Controls.Add(this.btnLogar);
            this.panel1.Controls.Add(this.lblLoginCadastrar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblLoginEsqueciSenha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtLoginSenha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLoginNome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(499, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 533);
            this.panel1.TabIndex = 5;
            // 
            // lblMostraSenha
            // 
            this.lblMostraSenha.AutoSize = true;
            this.lblMostraSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMostraSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMostraSenha.Location = new System.Drawing.Point(338, 252);
            this.lblMostraSenha.Name = "lblMostraSenha";
            this.lblMostraSenha.Size = new System.Drawing.Size(78, 25);
            this.lblMostraSenha.TabIndex = 9;
            this.lblMostraSenha.Text = "Mostrar";
            this.lblMostraSenha.Click += new System.EventHandler(this.lblMostraSenha_Click);
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnLogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.Location = new System.Drawing.Point(142, 433);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(167, 65);
            this.btnLogar.TabIndex = 8;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // lblLoginCadastrar
            // 
            this.lblLoginCadastrar.AutoSize = true;
            this.lblLoginCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoginCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginCadastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLoginCadastrar.Location = new System.Drawing.Point(255, 364);
            this.lblLoginCadastrar.Margin = new System.Windows.Forms.Padding(0);
            this.lblLoginCadastrar.Name = "lblLoginCadastrar";
            this.lblLoginCadastrar.Size = new System.Drawing.Size(166, 31);
            this.lblLoginCadastrar.TabIndex = 7;
            this.lblLoginCadastrar.Text = "cadastrar-se";
            this.lblLoginCadastrar.Click += new System.EventHandler(this.lblLoginCadastrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(39, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Não tenho conta";
            // 
            // lblLoginEsqueciSenha
            // 
            this.lblLoginEsqueciSenha.AutoSize = true;
            this.lblLoginEsqueciSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoginEsqueciSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginEsqueciSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLoginEsqueciSenha.Location = new System.Drawing.Point(114, 306);
            this.lblLoginEsqueciSenha.Name = "lblLoginEsqueciSenha";
            this.lblLoginEsqueciSenha.Size = new System.Drawing.Size(214, 31);
            this.lblLoginEsqueciSenha.TabIndex = 5;
            this.lblLoginEsqueciSenha.Text = "Esqueci a senha";
            this.lblLoginEsqueciSenha.Click += new System.EventHandler(this.lblLoginEsqueciSenha_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1452, 791);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoginNome;
        private System.Windows.Forms.TextBox txtLoginSenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoginEsqueciSenha;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Label lblLoginCadastrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMostraSenha;
    }
}

