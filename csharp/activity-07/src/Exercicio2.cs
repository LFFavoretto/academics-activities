using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios1
{
    public class Exercicio2
    {
        public void Converter(double t)
        {
            double celsius = (t - 32) * (5.0 / 9.0);
            if (celsius < 0)
            {
                Console.WriteLine($"{celsius:F1}°C: Congelando");
            }
            else if (celsius >= 0 && celsius < 20)
            {
                Console.WriteLine($"{celsius:F1}°C: Frio");
            }
            else if (celsius >= 20 && celsius < 30)
            {
                Console.WriteLine($"{celsius:F1}°C: Ameno");
            }
            else
            {
                Console.WriteLine($"{celsius:F1}°C: Quente");
            }
        }
    }
}
