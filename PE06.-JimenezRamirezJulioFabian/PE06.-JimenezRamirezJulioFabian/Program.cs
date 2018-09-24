using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE06._JimenezRamirezJulioFabian
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            Console.Write("Escriba el tamaño del vector");
            cantidad = Convert.ToInt32(Console.ReadLine());
            string[] vector = new string[cantidad];

            for (int contador = 0; contador < vector.Length; contador++)
            {
                Console.Write("Escriba algo ");
                vector[contador]=Console.ReadLine();

            }
            for (int contador=0; contador<vector.Length;contador++)
            {
                if(contador>1)
                {
                    if(vector[contador].Length>vector[contador-1].Length)
                    {
                        Console.WriteLine("El primer elemento que es mayor a su sucesion es: {0}", contador + 1);
                        contador = vector.Length;
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
