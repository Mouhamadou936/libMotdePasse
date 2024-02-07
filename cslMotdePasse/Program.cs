using System;
using libMotdePasse;

namespace cslMotdePasse
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez initialiser votre identifiant");
            string login = Console.ReadLine();
            Console.WriteLine("Veuillez initialiser votre mot de passe");
            string mdp = Console.ReadLine();
       

            MotdePasse conn1 = new MotdePasse(login, mdp);

            while (conn1.Longueur(mdp) == false)
            {
                Console.WriteLine("Le mot de passe doit avoir 12 ou plus caractères veillez ressasir");
                Console.WriteLine("Donner votre mot de passe");
                mdp = Console.ReadLine();
            }

            Console.WriteLine("Donner votre identifiant");
            string login1 = Console.ReadLine();
            Console.WriteLine("Donner votre mot de passe");
            string mdp1 = Console.ReadLine();
           
            while  (conn1.Verifier(mdp1, login1) == false)
            {
                Console.WriteLine("Le mot de passe ou l'identifiant sont faux veillez ressasir");
                Console.WriteLine("Donner votre identifiant");
                login1 = Console.ReadLine();
                Console.WriteLine("Donner votre mot de passe");
                mdp1 = Console.ReadLine();
            }

            Console.WriteLine("Bienvenu à vous " + login);
            
        }

    }
}
