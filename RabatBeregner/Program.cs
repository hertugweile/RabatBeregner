using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rabatberegner;


namespace Rabatberegner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rabatberegner");
            var rabatberegner = new RabatberegnerClass();

            Console.Write("Indtast vareantal: ");
            int vareantal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indtast stykpris: ");
            double stykpris = Convert.ToDouble(Console.ReadLine());

            var feedback = "Prisen er: "+rabatberegner.GetPrisEfterRabat(vareantal, stykpris);
            Console.WriteLine(feedback);
            Console.ReadLine();
        }
    }
}
