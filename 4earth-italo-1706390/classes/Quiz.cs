using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4earth_Italo_1706390.Classes
{
    public class Quiz
    {
        public string Tipo { get; set; }

        public string Dificuldade { get; set; }

        public string Pergunta { get; set; }

        public string[] respostas;

        public string respostaCorreta = string.Empty;

        public string Questao = string.Empty;

       

        public void GerarResposta()
        {
            respostas = new string[6];
        }

        public void CarregaQuiz()
        {

        }
     
    }
}
