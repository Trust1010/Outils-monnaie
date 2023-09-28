using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Outils_monnaie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choisissez une monnaie entre CAD,USD et EU");
            string line = Console.ReadLine();
            Console.WriteLine("Choisissez un montant");
            double montant;
            montant = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("En quoi voulez vous convertir votre monnaie");
            string line2 = Console.ReadLine();


            if (line == "CAD" && line2 == "USD")
            {
                double USD = montant * 1.3496;
                Console.WriteLine("Votre montant est de " + USD + "dollars Canadien");

            }


            if (line == "USD" && line2 == "EU")
            {
                double EU = montant / 0.94;
                Console.WriteLine("Votre monbatant est de " + EU + " dollars Americain");
            }

            if (line == "EU" && line2 == "CAD")
            {
                double CAD = montant * 1.42362;
                Console.WriteLine("Votre montant est de " + CAD + " dollars Canadien ");
            }


            if (line == "CAD" && line2 == "EU")
            {
                double EU = montant / 1.42362;
                Console.WriteLine("Votre montant est de " + EU + " dollars Canadien ");
            }


            if (line == "USD" && line2 == "CAD")
            {
                double CAD = montant * 1.3496;
                Console.WriteLine("Votre montant est de " + CAD + " dollars Canadien ");
            }


            if (line == "EU" && line2 == "USD")
            {
                double USD = montant/1.05;
                Console.WriteLine("Votre montant est de " + USD + " dollars Canadien ");
            }

            


         Console.ReadKey();
           
        }
     
    }

}
