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
    public partial class frmScore : Form
    {
        public frmScore()
        {
            InitializeComponent();
        }

        private void frmScore_Load(object sender, EventArgs e)
        {
            t1.Text = Settings.Default.hs.ToString();
            t2.Text = Settings.Default.top2.ToString();
            t3.Text = Settings.Default.top3.ToString();
            t4.Text = Settings.Default.top4.ToString();
            t5.Text = Settings.Default.top5.ToString();

            ntop1.Text = Settings.Default.nhs.ToString();
            ntop2.Text = Settings.Default.ntop2.ToString();
            ntop3.Text = Settings.Default.ntop3.ToString();
            ntop4.Text = Settings.Default.ntop4.ToString();
            ntop5.Text = Settings.Default.ntop5.ToString();
        }
    }
}
