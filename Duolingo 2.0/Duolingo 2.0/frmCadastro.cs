using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using SendEmail;

namespace Duolingo_2._0
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
            txtLoginSenha.PasswordChar = '*';
            txtLoginSenha.MaxLength = 11;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        User user1 = null;
        
        private void lblMostraSenha_Click(object sender, EventArgs e)
        {
            if (lblMostraSenha.Text == "Mostrar")
            {
                lblMostraSenha.Text = "Esconder";
                txtLoginSenha.PasswordChar = '\0';
            }
            else
            {
                lblMostraSenha.Text = "Mostrar";
                txtLoginSenha.PasswordChar = '*';
            }
        }
        
        private void lblLoginCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().ShowDialog();
        }
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var emailSender = new Email("smtp.office365.com", "trilingo.verification@outlook.com", "trilingoEmail123");
            
            if (txtLoginSenha.Text== String.Empty || txtLoginNome.Text == String.Empty || txtCadastroTel.Text == String.Empty)
            {
                MessageBox.Show("Preencha todos os campos para continuar!");
            }
            else if(!emailSender.ValidateEmail(txtCadastroTel.Text))
            {
                MessageBox.Show("Email inválido, tente novamente");
                txtCadastroTel.Text = string.Empty;
            }
            else{
                Random random = new Random();
                user1 = new User();
                user1.Nome = txtLoginNome.Text;
                user1.Senha = txtLoginSenha.Text;
                user1.Email = txtCadastroTel.Text;
                int x = random.Next(1,999);
                foreach(var user in Program.listaUser)
                {
                    if(user.Id != x)
                    {
                        user1.Id = x;
                    }
                }
                Program.listaUser.Add(user1);
                Program.emailSetup.Add(emailSender);
                MessageBox.Show("Cadastro realizado");
                this.Hide();
                new frmLogin().ShowDialog();
            }
        }
        

    }
}
