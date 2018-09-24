using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE01._JimenezRamirezJulioFabian
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
            Console.WriteLine("El valor maximo es {0} \nEl valor menor es {1}", vector.Max(), vector.Min());
            Console.ReadKey();

        }
    }
}
