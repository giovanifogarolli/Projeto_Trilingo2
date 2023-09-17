using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using SendEmail;

namespace Duolingo_2._0
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());

        }
        public static List<User> listaUser = new List<User>();
        public static List<Email> emailSetup = new List<Email>();
        public static cfg cfgP = new cfg();
    }
}
