using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Duolingo_2._0
{
    public class User
    {
        private string nome, senha, email;
        private int id;
        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
    }
}
