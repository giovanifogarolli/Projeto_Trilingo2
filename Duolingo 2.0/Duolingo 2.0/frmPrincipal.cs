using Duolingo_2._0.Properties;
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
    public partial class frmPrincipal : Form
    {
        cfg cfg = Program.cfgP;
        eng eng = new eng();
        it it = new it();
        int[] jf = new int[5];
        int[] ji = new int[5];
        int Q = 0, score;
        bool f;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private bool DSelecionado()
        {
            if (cfg.Dificuldade > 0)
            {
                switch (cfg.Dificuldade)
                {
                    case 1:
                        score = 90;
                        break;
                    case 2:
                        score = 120;
                        break;
                    case 3:
                        score = 180;
                        break;
                }
                return true;
            }
            else { return false; }
        } // Verificar se possui Dificuldade selecionada

        private void Jogar(int D, int L)
        {
            Random P = new Random();
            Random M = new Random();
            pictureBox3.Hide();
            lblF.Hide();

            if (L == 1)
            {
                while (pgb.Value != 100)
                {
                    int Mg = M.Next(1, 3);
                    int p = P.Next(5);
                    if (Mg == 1)
                    {
                        f = true;
                        lblQ.Text = "Traduza a frase";
                        pictureBox3.Hide();
                        while (jf.Contains(p + 1))
                        {
                            p = P.Next(5);
                        }
                        {
                            jf[p] = p + 1;
                            lblF.Show();
                            switch (D)
                            {
                                case 1:
                                    lblF.Text = eng.Pergunta1[p];
                                    break;
                                case 2:
                                    lblF.Text = eng.Pergunta2[p];
                                    break;
                                case 3:
                                    lblF.Text = eng.Pergunta3[p];
                                    break;
                            }
                            Q = p;
                        }
                        break;
                    }
                    if (Mg == 2)
                    {
                        f = false;
                        lblQ.Text = "Escreva o nome do animal";
                        lblF.Hide();
                        while (ji.Contains(p + 1))
                        {
                            p = P.Next(5);
                        }
                        {
                            ji[p] = p + 1;
                            switch (D)
                            {
                                case 1:
                                    pictureBox3.Image = eng.Imagem1[p];
                                    break;
                                case 2:
                                    pictureBox3.Image = eng.Imagem2[p];
                                    break;
                                case 3:
                                    pictureBox3.Image = eng.Imagem3[p];
                                    break;

                            }
                            pictureBox3.Show();
                            pictureBox3.Location = new Point(496, 125);
                            Q = p;
                        }
                        break;
                    }
                }
            } // Configuração em Ingles
            else if (L == 2)
            {
                while (pgb.Value != 100)
                {
                    int Mg = M.Next(1, 3);
                    int p = P.Next(5);
                    if (Mg == 1)
                    {
                        f = true;
                        lblQ.Text = "Traduza a frase";
                        pictureBox3.Hide();
                        while (jf.Contains(p + 1))
                        {
                            p = P.Next(5);
                        }
                        {
                            jf[p] = p + 1;
                            lblF.Show();
                            switch (D)
                            {
                                case 1:
                                    lblF.Text = it.pergunta1[p];
                                    break;
                                case 2:
                                    lblF.Text = it.pergunta2[p];
                                    break;
                                case 3:
                                    lblF.Text = it.pergunta3[p];
                                    break;

                            }

                            Q = p;
                        }
                        break;
                    }
                    if (Mg == 2)
                    {
                        f = false;
                        lblF.Hide();
                        lblQ.Text = "Escreva o nome do animal";
                        while (ji.Contains(p + 1))
                        {
                            p = P.Next(5);
                        }
                        {
                            ji[p] = p + 1;
                            switch (D)
                            {
                                case 1:
                                    pictureBox3.Image = it.Imagem1[p];
                                    break;
                                case 2:
                                    pictureBox3.Image = it.Imagem2[p];
                                    break;
                                case 3:
                                    pictureBox3.Image = it.Imagem3[p];
                                    break;

                            }
                            Q = p;
                        }
                        pictureBox3.Location = new Point(496, 125);
                        pictureBox3.Show();
                        break;
                    }
                }
            } // Configuração em Italiano


        } // Script do jogo

        private void EnviarResposta(int L, int D)
        {
            if (L == 1)
            {
                bool x = false;
                if (f)
                {
                    switch (D)
                    {
                        case 1:
                            if (txtbR.Text.Equals(eng.Resposta1[Q], StringComparison.OrdinalIgnoreCase))
                                x = true;
                            break;
                        case 2:
                            if (txtbR.Text.Equals(eng.Resposta2[Q], StringComparison.OrdinalIgnoreCase))
                                x = true;
                            break;
                        case 3:
                            if (txtbR.Text.Equals(eng.Resposta3[Q], StringComparison.OrdinalIgnoreCase))
                                x = true;
                            break;

                    }
                    if (x == true)
                    {
                        pgb.Value += 20;
                        txtbR.Text = "";
                        Jogar(D, L);
                    }
                    else
                    {
                        MessageBox.Show("Resposta errada.");
                    }
                }
                else
                {
                    switch (D)
                    {
                        case 1:
                            if (txtbR.Text.Equals(eng.Respostaimg1[Q], StringComparison.OrdinalIgnoreCase))
                                x = true;
                            break;
                        case 2:
                            if (txtbR.Text.Equals(eng.Respostaimg2[Q], StringComparison.OrdinalIgnoreCase))
                                x = true;
                            break;
                        case 3:
                            if (txtbR.Text.Equals(eng.Respostaimg3[Q], StringComparison.OrdinalIgnoreCase))
                                x = true;
                            break;
                    }
                    if (x == true)
                    {
                        pgb.Value += 20;
                        txtbR.Text = "";
                        Jogar(D, L);
                    }
                    else
                    {
                        MessageBox.Show("Resposta errada.");
                    }
                }
            } // Resposta em Ingles
            else if (L == 2)
            {
                bool x = false;
                if (f)
                {
                    switch (D)
                    {
                        case 1:
                            if (txtbR.Text.Equals(it.resposta1[Q], StringComparison.OrdinalIgnoreCase))
                                x = true;
                            break;
                        case 2:
                            if (txtbR.Text.Equals(it.resposta2[Q], StringComparison.OrdinalIgnoreCase))
                                x = true;
                            break;
                        case 3:
                            if (txtbR.Text.Equals(it.resposta3[Q], StringComparison.OrdinalIgnoreCase))
                                x = true;
                            break;

                    }
                    if (x == true)
                    {
                        pgb.Value += 20;
                        txtbR.Text = "";
                        Jogar(D, L);
                    }
                    else
                    {
                        MessageBox.Show("Resposta errada.");
                    }
                }
                else
                {
                    switch (D)
                    {
                        case 1:
                            if (txtbR.Text.Equals(it.Respostaimg1[Q], StringComparison.OrdinalIgnoreCase))
                                x = true;
                            break;
                        case 2:
                            if (txtbR.Text.Equals(it.Respostaimg2[Q], StringComparison.OrdinalIgnoreCase))
                                x = true;
                            break;
                        case 3:
                            if (txtbR.Text.Equals(it.Respostaimg3[Q], StringComparison.OrdinalIgnoreCase))
                                x = true;
                            break;
                    }
                    if (x == true)
                    {
                        pgb.Value += 20;
                        txtbR.Text = "";
                        Jogar(D, L);
                    }
                    else
                    {
                        MessageBox.Show("Resposta errada.");
                    }
                }

            }// Resposta em Italiano
            if (pgb.Value == 100)
            {
                TerminaJogo();
            }
        } // Script resposta

        private void highscore(int x)
        {
            cfg.Nome = "Giovani";
            if (x > (Settings.Default.hs))
            {
                int aux = Settings.Default.hs;
                Settings.Default.hs = x;
                Settings.Default.nhs = cfg.Nome;
                x = aux;
            }
            if (x > Settings.Default.top2)
            {
                int aux = Settings.Default.top2;
                Settings.Default.top2 = x;
                Settings.Default.ntop2 = cfg.Nome;
                x = aux;
            }
            if (x > (Settings.Default.top3))
            {
                int aux = Settings.Default.top3;
                Settings.Default.top3 = x;
                Settings.Default.ntop3 = cfg.Nome;
                x = aux;
            }
            if (x > (Settings.Default.top4))
            {
                int aux = Settings.Default.top4;
                Settings.Default.top4 = x;
                Settings.Default.ntop4 = cfg.Nome;
                x = aux;
            }
            if (x > (Settings.Default.top5))
            {
                Settings.Default.top5 = x;
                Settings.Default.ntop5 = cfg.Nome;
            }
            Settings.Default.Save();
        } // Salva Highscore

        private void TerminaJogo()
        {
            hs.Stop();
            lblF.Hide();
            lblQ.Hide();
            txtbR.Hide();
            pictureBox3.Hide();
            btnE.Hide();

            btnhs.Show();
            pictureBox2.Show();
            pictureBox2.Image = Properties.Resources.duofeliz;
            btnM.Show();
            btnR.Show();
            highscore(score);
        } // Script fim de jogo

        private void resetJogo()
        {
            pgb.Value = 0;
            Array.Clear(jf, 0, jf.Length);
            Array.Clear(ji, 0, ji.Length);
        } // Script reset de jogo

        private void btnJ_Click(object sender, EventArgs e)
        {
            if (DSelecionado())
            {
                timer1.Start();
                hs.Start();
                Jogar(cfg.Dificuldade, cfg.Lingua);
            }
            else
            {
                MessageBox.Show("Primeiro deve selecionar uma Linguagem e uma Dificuldade.");
            }
        } // Jogar

        private void btnC_Click(object sender, EventArgs e)
        {
            frmConfig fc = new frmConfig();
            fc.ShowDialog();
        }// Configuração

        private void btnT_Click(object sender, EventArgs e)
        {
            ex.Text = "Lingua: " + cfg.Lingua + "\n Dificuldade: " + cfg.Dificuldade;
        }// Controle

        private void btnS_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }// Sair

        private void btnE_Click(object sender, EventArgs e)
        {
            EnviarResposta(cfg.Lingua, cfg.Dificuldade);
        } // Enviar resposta

        private void btnR_Click(object sender, EventArgs e)
        {
            if (DSelecionado())
            {
                resetJogo();
                timer1.Start();
                hs.Start();
                Jogar(cfg.Dificuldade, cfg.Lingua);
            }
        } // Resetar jogo

        private void btnM_Click(object sender, EventArgs e)
        {
            resetJogo();
            timer3.Start();
        } // Entrar no menu

        private void btnhs_Click(object sender, EventArgs e)
        {
            frmScore frmScore = new frmScore();
            frmScore.ShowDialog();
        } // Abrir Highscore

        private void hs_Tick(object sender, EventArgs e)
        {
            score -= 1;
            ex.Text = score.ToString();
        } // Pontuação

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            btnJ.Location = new Point(540, 376);
            btnC.Location = new Point(540, 418);
            btnT.Location = new Point(540, 460);
            btnS.Location = new Point(540, 502);
            btnE.Location = new Point(540, 376);
            pictureBox2.Location = new Point(447, 41);
            pictureBox3.Location = new Point(447, 41);
            btnR.Location = new Point(540, 418);
            btnM.Location = new Point(540, 460);
            btnhs.Location = new Point(540, 376);
        } // Carregar o frm

        private void txtbR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnE.PerformClick();
        } // Aceitar ENTER pra responder

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer2.Stop();
            }
            Opacity += 0.2;
        } // Fim da animação

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0.20000000000000007)
            {
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.trilingo;
                btnJ.Show();
                btnC.Show();
                btnT.Show();
                btnS.Show();
                btnhs.Hide();

                pictureBox3.Hide();
                btnR.Hide();
                pgb.Hide();
                lblF.Hide();
                lblQ.Hide();
                btnE.Hide();
                txtbR.Hide();
                btnM.Hide();

                timer3.Stop();
                timer2.Start();
            }
            else
            {
                Opacity -= 0.20;
            }
        } // Animação de restart

        private void txtbR_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0.20000000000000007)
            {
                btnJ.Hide();
                btnC.Hide();
                btnS.Hide();
                btnT.Hide();
                pictureBox2.Hide();
                btnR.Hide();
                btnM.Hide();
                btnhs.Hide();

                btnE.Show();
                lblF.Show();
                lblQ.Show();
                txtbR.Show();
                pgb.Show();

                timer1.Stop();
                timer2.Start();
            }
            else
            {
                Opacity -= 0.20;
            }
        } // Começo da animação
    }
}
