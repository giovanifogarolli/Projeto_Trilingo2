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
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
            switch (Program.cfgP.Lingua)
            {
                case 1:
                    {
                        rdbI.Checked = true;
                        break;
                    }
                case 2:
                    {
                        rdbJ.Checked = true;
                        break;
                    }
            }
            switch (Program.cfgP.Dificuldade)
            {
                case 1:
                    {
                        rdbF.Checked = true;
                        break;
                    }
                case 2:
                    {
                        rdbM.Checked = true;
                        break;
                    }
                case 3:
                    {
                        rdbD.Checked = true;
                        break;
                    }
            }
        }

        private void rdbI_CheckedChanged_1(object sender, EventArgs e)
        {
            Program.cfgP.Lingua = 1;
        }

        private void rdbJ_CheckedChanged(object sender, EventArgs e)
        {
            Program.cfgP.Lingua = 2;
        }

        private void rdbF_CheckedChanged_1(object sender, EventArgs e)
        {
            Program.cfgP.Dificuldade = 1;
        }

        private void rdbM_CheckedChanged_1(object sender, EventArgs e)
        {
            Program.cfgP.Dificuldade = 2;
        }

        private void rdbD_CheckedChanged_1(object sender, EventArgs e)
        {
            Program.cfgP.Dificuldade = 3;
        }
    }
}

