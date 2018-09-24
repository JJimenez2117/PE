using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE08._JimenezRamirezJulioFabian
{
    class Program
    {
        static void Main(string[] args)
        {
            string cantidad,opcion;
            do
            {
                Console.Write("Escriba un numero entero de 5 digitos: ");
                cantidad = Console.ReadLine();
                if (cantidad.Length > 5)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    if (cantidad[0] == cantidad[cantidad.Length - 1]&& cantidad[1] == cantidad[cantidad.Length - 2])
                    {
                        Console.WriteLine("es palindroma");
                    }
                    else
                    {
                        Console.WriteLine("no es palindroma");

                    }
                }
                Console.WriteLine("Desea ingresar otro numero?SI/NO");
                opcion = Console.ReadLine();
            }
            while (opcion == "SI") ;


          
        }
    }
}
