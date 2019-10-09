using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuto0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un valor.");

            try
            {
                int c = Convert.ToInt32(Console.ReadLine());

            }
            catch(Exception ex) {
                   Console.WriteLine("introducir un numero");
            }
            finally {
                Console.WriteLine("se ejecuta siempre");

            }






            /* Console.WriteLine("Primer valor:");
             int a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Segundo valor:");
             int b = Convert.ToInt32(Console.ReadLine());
             int resultado = 0;
             resultado = a + b;

            // <, >, >=, <=, ==, !=
             // && ||

             if (a == 0 || b > 3)
             {
                 for (int j = 0; j < 120; j=j+3)

                     Console.WriteLine("valor de j:" + j.ToString());

                if (a == 1)
                     Console.WriteLine("Hola");
                 else
                     Console.WriteLine("aaaa");
             }
             else
                 Console.WriteLine("adios");


             Console.WriteLine("la suma es:" + resultado.ToString());
             if (resultado > 10)
                 Console.WriteLine("El resultado es mayor que 10");
             else if (resultado == 10)
             Console.WriteLine("el resultado es igual a 10");
             else 
                 Console.WriteLine("3l resultado es menor que 10");
             while (resultado < 100)
             {
                 resultado = 10 + resultado;
                 Console.WriteLine("el resultado de la operacion es " + resultado.ToString());
             }
             Console.WriteLine("XXXXXXXXXXXXXXXX");

             resultado = 0;
             do
             {
                 resultado = 10 + resultado;
                 Console.WriteLine("el resultado de la operacion es " + resultado.ToString());
             }
             while (resultado < 100);

             Console.WriteLine("XXXXXXXXXXXXXXXX");

             for (int i = 0; i < resultado; i++)
             {
                 Console.WriteLine("el valor de i es:" + i.ToString());

             }*/

            Console.ReadLine();
        }
    }
    
}
