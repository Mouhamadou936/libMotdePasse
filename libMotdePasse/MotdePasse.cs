using System;

namespace libMotdePasse
{
    public class MotdePasse
    {
        private string login;
        private string mdp;
       public MotdePasse(string login, string mdp)
        {
            this.login = login;
            this.mdp = mdp;

        }
        public bool Verifier(string mdp, string login)
        {
            bool a = false;
            if (this.mdp == mdp && this.login == login)
            { 
                a = true;
            }
            
            return a;
        }
        public bool Longueur(string mdp)
        {
            bool a = false;
            if (this.mdp.Length > 11)
            { a = true; }
            return a; 
        }
        public bool EstNumeric(string mdp)
        {
            int index = this.mdp.Length;
            bool a = false;
            
            
            return a;
        }
    }
}
