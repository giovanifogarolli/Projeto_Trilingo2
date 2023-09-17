using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duolingo_2._0
{
    internal class eng
    {

        // PERGUNTA E RESPOSTA EM INGLES DIFIFULDADE FACIL

        private string[] pergunta =
        {
            "Good Night Jaqueline",
            "I’m too tired",
            "I’m hungry",
            "Can you switch the light on Camila?",
            "Nice to meet you too João!",
        };
        private string[] resposta =
        {
            "Boa noite Jaqueline",
            "Estou muito cansado",
            "Estou com fome",
            "Camila, você poderia ligar as luzes?",
            "Prazer em te conhecer também João!",
        };

        // PERGUNTA E RESPOSTA EM INGLES DIFIFULDADE MEDIO

        private string[] pergunta2 =
{
            "I didn’t sleep very well, I had a bad dream",
            "Are you up to anything this night?",
            "I was at literally the ugliest place in the world yesterday",
            "Giovani went to buy coffe at Point do Café",
            "He left his house at 6 in the evening to be on time for his class",
        };
        private string[] resposta2 =
        {
            "Não dormi muito bem, tive pesadelos",
            "Topa fazer algo essa noite?",
            "Ontem eu estava literalmente no lugar mais feio do mundo",
            "Giovani foi ao Point do Café comprar Café",
            "Ele saiu de casa às 6 da tarde para chegar a tempo na aula",
        };


        // PERGUNTA E RESPOSTA EM INGLES DIFIFULDADE DIFICIL

        private string[] pergunta3 =
{
            "Marcos has been acting weird lately. I think he is out of his mind!",
            "A working computer and internet connection are necessary for my job",
            "The news channels work 24/7 to provide us with information",
            "The comedian is famous for using ironic humor to criticize the government",
            "I felt nauseous during the road trip, so I took medicine for motion sickness",
        };
        private string[] resposta3 =
        {
            "Marcos tem agido estranho ultimamente. Acho que ele está louco!",
            "Para o meu trabalho é nescessario um computador que funcione e conexão a internet.",
            "O canal de noticia trabalha 24 horas por dia 7 dias na semana para nos informar",
            "O comediante é famoso por usar humor ironico para criticar o governo",
            "Estava sentindo nauseas durante a viagem, então tomei remedio para enjôo",
        };

        private Bitmap[] imagem1 = new Bitmap[]
        {
            Properties.Resources.Cachorro,
            Properties.Resources.gato,
            Properties.Resources.rato,
            Properties.Resources.vaca,
            Properties.Resources.leão,
        };
        private string[] respostaimg1 =
        {
            "Dog",
            "Cat",
            "Rat",
            "Cow",
            "Lion",
        };

        private Bitmap[] imagem2 = new Bitmap[] {
            Properties.Resources.pombo,
            Properties.Resources.Macaco,
            Properties.Resources.Lupo,
            Properties.Resources.Galinha,
            Properties.Resources.Ra,
        };

        private string[] respostaimg2 =
        {
            "Pigeon",
            "Monkey",
            "Wolf",
            "Chicken",
            "Frog",
        };

        private Bitmap[] imagem3 = new Bitmap[]
        {
            Properties.Resources.Avestruz,
            Properties.Resources.tatu,
            Properties.Resources.borboleta,
            Properties.Resources.Hipopotamo,
            Properties.Resources.Alce,
        };
        private string[] respostaimg3 =
        {
            "Ostrich",
            "Armadillo",
            "Butterfly",
            "Hippopotamus",
            "Moose",
        };

        public string[] Pergunta1 { get => pergunta; set => pergunta = value; }
        public string[] Resposta1 { get => resposta; set => resposta = value; }
        public string[] Pergunta2 { get => pergunta2; set => pergunta2 = value; }
        public string[] Resposta2 { get => resposta2; set => resposta2 = value; }
        public string[] Pergunta3 { get => pergunta3; set => pergunta3 = value; }
        public string[] Resposta3 { get => resposta3; set => resposta3 = value; }
        public Bitmap[] Imagem1 { get => imagem1; set => imagem1 = value; }
        public string[] Respostaimg1 { get => respostaimg1; set => respostaimg1 = value; }
        public Bitmap[] Imagem2 { get => imagem2; set => imagem2 = value; }
        public string[] Respostaimg2 { get => respostaimg2; set => respostaimg2 = value; }
        public Bitmap[] Imagem3 { get => imagem3; set => imagem3 = value; }
        public string[] Respostaimg3 { get => respostaimg3; set => respostaimg3 = value; }
    }
}
