using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE04._JimenezRamirezJulioFabian
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] vector = new double[3];
            Console.WriteLine("Escriba los valores de a, b y c respectivamente: ");
            for (int contador = 0; contador < 3; contador++)
            {
                Console.Write("Escriba un valor double ");
                vector[contador] = Convert.ToDouble(Console.ReadLine());

            }
            Console.WriteLine("El valor menor entre a,b,c es: {0} ",vector.Min());
            Console.ReadKey();

        }
    }
}
