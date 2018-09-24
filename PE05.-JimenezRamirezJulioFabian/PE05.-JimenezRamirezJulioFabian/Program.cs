using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE05._JimenezRamirezJulioFabian
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            Console.Write("Escriba la cantidad de numeros del vector");
            cantidad = Convert.ToInt32(Console.ReadLine());
            double[] vector = new double[cantidad];

            for (int contador = 0; contador < cantidad; contador++)
            {
                Console.Write("Escriba un valor double ");
                vector[contador] = Convert.ToDouble(Console.ReadLine());

            }
            Console.WriteLine("El indice de la ultima ocurrencia del elemento más grande del vector es {0}", (vector.ToList().IndexOf(vector.Max()) + 1));
            Console.ReadKey();

        }
    }
}
