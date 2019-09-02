using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace _4earth_Italo_1706390.Classes
{
    public class Login
    {
        private int id;

        public int ID { get { return ID; } set { ID = value; } }

        public string Nome { get; set; }

        public string Username { get; set; }
        
        public string Email { get; set; }

        private string Senha { get; set; }

        public bool acesso;
        public string cadastro;

        public bool Acessar (string Email, string Senha)
        {
            return acesso;
        }

        public string Cadastrar(string Nome, string Senha, string Email, string Username)
        {
            return cadastro;
        }

       public Login()
        {

        }

       

        

    }
}
