using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE07._JimenezRamirezJulioFabian
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            Console.Write("Escriba cuantos valores aleatorios desea tener ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            double num = random.Next(1, 100);
            int[] vector = new int[cantidad];
            for (int contador = 0; contador < cantidad; contador++)
            {
                
                
                vector[contador] = random.Next(0,101);

            }
            for (int contador = 0; contador < cantidad; contador++)
            {

                Console.WriteLine(vector[contador]);

            }
            Array.Sort(vector);
            Console.WriteLine("Los valores ya acomodados quedan así: ");
            for (int contador = 0; contador < cantidad; contador++)
            {

                Console.WriteLine(vector[contador]);

            }
            Console.ReadKey();
        }
    }
}
