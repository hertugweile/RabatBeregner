using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabatberegner
{
        public class RabatberegnerClass
        {
            public double GetPrisEfterRabat(int antalVarer, double stykPris) {
                double rabat = 0;

                double bruttoPris = antalVarer * stykPris;
                if (bruttoPris > 1000)
                {
                    // Indkøb over 1000 kr. giver 3% rabat
                    rabat = 0.03;
                    
                }
                if (antalVarer > 10)
                {
                    // Flere end 10 varer giver 2% rabat
                    rabat += 0.02;
                    
                }

                bruttoPris = bruttoPris - bruttoPris * rabat;

                return bruttoPris;
            }
        
    }
}
