using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duolingo_2._0
{
    public partial class frmAtualizarSenha : Form
    {
        public frmAtualizarSenha()
        {
            InitializeComponent();
            txtAtualizaSenha.PasswordChar = txtAtualizaSenhaR.PasswordChar = '*';
        }

        private void lblMostraSenha_Click(object sender, EventArgs e)
        {
            if (lblMostraSenha.Text == "Mostrar")
            {
                lblMostraSenha.Text = "Esconder";
                txtAtualizaSenha.PasswordChar = '\0';
            }
            else
            {
                lblMostraSenha.Text = "Mostrar";
                txtAtualizaSenha.PasswordChar = '*';
            }
        }

        private void lblMostraSenhaR_Click(object sender, EventArgs e)
        {
            if (lblMostraSenhaR.Text == "Mostrar")
            {
                lblMostraSenhaR.Text = "Esconder";
                txtAtualizaSenhaR.PasswordChar = '\0';
            }
            else
            {
                lblMostraSenhaR.Text = "Mostrar";
                txtAtualizaSenhaR.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtAtualizaSenha.Text==string.Empty || txtAtualizaSenhaR.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos para continuar");
                txtAtualizaSenha.Text = txtAtualizaSenhaR.Text = "";
            }
            else if(txtAtualizaSenha.Text!= txtAtualizaSenhaR.Text)
            {
                MessageBox.Show("As senhas não são iguais");
                txtAtualizaSenha.Text = txtAtualizaSenhaR.Text = "";
            }
            else
            {
                foreach(var user in Program.listaUser)
                {
                    user.Senha = txtAtualizaSenha.Text;
                }
                MessageBox.Show("Senha atualizada");
                this.Hide();
                new frmLogin().ShowDialog();
            }
        }
    }
}
