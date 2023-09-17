using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duolingo_2._0
{
    internal class cfg
    {
        private string nome;
        private int lingua;
        private int dificuldade;

        public int Dificuldade { get => dificuldade; set => dificuldade = value; }
        public int Lingua { get => lingua; set => lingua = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
