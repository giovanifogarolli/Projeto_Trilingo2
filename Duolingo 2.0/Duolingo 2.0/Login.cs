using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using SendEmail;

namespace Duolingo_2._0
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtLoginSenha.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (Program.listaUser.Count < 1)
            {
                MessageBox.Show("Nenhum usuário cadastrado! Cadastre-se primeiro");
                this.Hide();
                new frmCadastro().ShowDialog();
            }
            else
            {
                User user = new User();
                foreach (var users in Program.listaUser)
                {
                    user.Senha = users.Senha;
                    user.Nome = users.Nome;
                    user.Email = users.Email;
                    user.Id = users.Id;
                }

                if (txtLoginNome.Text != user.Nome || txtLoginSenha.Text != user.Senha)
                {
                    MessageBox.Show("Usuário e/ou senha incorretos!\nTente novamente");
                    txtLoginSenha.Text = txtLoginNome.Text = "";
                }
                else
                {
                    MessageBox.Show("Acesso liberado!");
                    frmPrincipal frmPrincipal = new frmPrincipal();              
                    this.Hide();
                    Program.cfgP.Nome = user.Nome;
                    frmPrincipal.ShowDialog();
                }
            }
        }

        private void lblMostraSenha_Click(object sender, EventArgs e)
        {
            if(lblMostraSenha.Text == "Mostrar")
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
            new frmCadastro().ShowDialog();
        }

        private void lblLoginEsqueciSenha_Click(object sender, EventArgs e)
        {
            if (Program.listaUser.Count == 0)
            {
                MessageBox.Show("Nenhum usuário cadastrado!");
            }
            else
            {
                this.Hide();
                new frmEsqueciSenha().ShowDialog();
            }
        }
    }
}
