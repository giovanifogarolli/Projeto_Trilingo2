using SendEmail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duolingo_2._0
{
    public partial class frmEsqueciSenha : Form
    {
        public frmEsqueciSenha()
        {
            InitializeComponent();
        }
        private static readonly Random random = new Random();
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public static string GenerateRandomString(int length)
        {
            StringBuilder stringBuilder = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                char randomChar = chars[random.Next(chars.Length)];
                stringBuilder.Append(randomChar);
            }

            return stringBuilder.ToString();
        }

        private string email = "",codigoUniversal;
        private void frmEsqueciSenha_Load(object sender, EventArgs e)
        {
            string codigo = GenerateRandomString(5);
            codigoUniversal = codigo;
            foreach (var user in Program.listaUser)
            {
                email = user.Email;
            }
            foreach (var emailSender in Program.emailSetup)
            {
                emailSender.SendEmail(
                emailsTo: new List<string>
                {
                    email
                },
                subject: "Código de verificação",
                body: codigo
                );
            }
        }
        

        private void lblReenviaEmail_Click(object sender, EventArgs e)
        {
            string codigo = GenerateRandomString(5);
            codigoUniversal = codigo;
            foreach (var user in Program.listaUser)
            {
                email = user.Email;
            }
            foreach (var emailSender in Program.emailSetup)
            {
                emailSender.SendEmail(
                emailsTo: new List<string>
                {
                    email
                },
                subject: "Código de verificação",
                body: codigo
                );
            }
        }

        private void btnEnviaCodigo_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo com o código recebido");
            }
            else if (txtCodigo.Text != codigoUniversal)
            {
                MessageBox.Show("Código incorreto, tente novamente ou clicke em reenviar código");
                txtCodigo.Text = string.Empty;
            }
            else
            {
                this.Hide();
                new frmAtualizarSenha().ShowDialog();
            }
        }
    }
}

