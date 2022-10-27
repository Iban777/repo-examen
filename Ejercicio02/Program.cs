using System;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
                //Declarar variables

                    double a, b, c;
                    double x1, x2, raiz;

                    int opcion;
            do
            {
                //Limpia la consola cuando le das opcion 1 al finalizar el programa

                Console.Clear();

                //Entrada de valores

                Console.WriteLine("Algoritmo de ecuacion de segundo grado (ax2 + bx + c = 0)");
                Console.WriteLine(" ");

                Console.Write("Pon el valor de A: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Pon el valor de B: ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Pon el valor de C: ");
                c = Convert.ToDouble(Console.ReadLine());

                //Algoritmos

                raiz = Math.Pow(b, 2) - 4 * (a * c);

                if (a == 0)
                    Console.WriteLine("ERROR el valor de A no puede ser 0");
                else if (raiz < 0)

                    Console.WriteLine("ERROR el valor de la RAIZ no puede ser negativo");

                x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * (a * c))) / 2 * a;
                x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * (a * c))) / 2 * a;

                //Salida de valores

                if (x1 != x2)
                    Console.WriteLine($"Resultado ecuacion segundo grado {a}x2 + {b} + {c} = x1 = {x1} x2 = {x2}");
                else if (x1 == x2)
                {
                    Console.WriteLine($"Resultado ecuacion segundo grado  {a}x2 + {b} + {c} = x1 = {x1}");
                }

                //Una vez acabada la operacion le pregunto que desea realizar al usuario

                Console.WriteLine(" ");
                Console.WriteLine("¿Que desea realizar?");
                Console.WriteLine("1. Continuar: ");
                Console.WriteLine("2. Salir: ");

                opcion = Convert.ToInt16(Console.ReadLine());
            }

                while (opcion != 2);
                if (opcion == 2)
                {
                Console.WriteLine("Salir del programa");
                }
                Console.ReadKey();


    {

            }
                

                
                
            }
            
        }
    }

