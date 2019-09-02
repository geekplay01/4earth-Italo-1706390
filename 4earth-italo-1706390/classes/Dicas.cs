using _4earth_italo_1706390.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _4earth_Italo_1706390.Classes
{
    public class Dicas:Operacoes
    {
        public string Caracteristica { get; set; }

        public string Tipo { get; set; }

        public string Nome { get; set; }


        public Dicas(string _nome, string _caracteristica)
        {
            Nome = _nome;
            Caracteristica = _caracteristica;

        }

        public Dicas()
        {

        }

        public List<object> GerarDicas()
        {
            List<Dicas> Ld = new List<Dicas>();
            Ld.Add(new Dicas("Reciclgem recidencial", "Esta é uma dica que tem como caracterisca o tipo de reciclegem residencial: Dica 01"));
            List<object> ListaDicas = new List<object>();
            ListaDicas.Add(new Dicas("reciclegem Industrial", "Esta é uma dica que tem como caracterisca o tipo de reciclegem industrial: Dica 02"));
            List<object> ListaDiscas = null;
            return ListaDiscas;

            
        }

        
       

        
    }
}
