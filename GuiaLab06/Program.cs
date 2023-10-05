using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GuiaLab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxA      = 0;
            int asiAct    = 0;
            int vecesLe   = 0;
            int vecesVa   = 0;
            int totalAsi  = 0;
            int totalSa   = 0;
            int aforo     = 0;
            string opcion;
            Console.WriteLine("Ingrese un numero maximo de personas: ");
            if (int.TryParse(Console.ReadLine(), out maxA) && maxA > 0)
            {
                Console.WriteLine("=====================================");
                Console.WriteLine("El numero maximo establecido es de " + maxA + " personas" +
                    ", presione una tecla para comenzar a contar.");
                Console.ReadKey();
                do
                {
                    Console.Clear();
                    Console.WriteLine("=====================================");
                    Console.WriteLine("| Asistentes actuales | " + asiAct);
                    aforo = (asiAct * 100) / maxA;
                    Console.WriteLine("| Aforo               | " + aforo + " %");
                    Console.WriteLine("| Maximo              | " + maxA + " personas");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("Presione ");
                    Console.WriteLine("[i] si ingresa una persona");
                    Console.WriteLine("[s] si sale una persona");
                    Console.WriteLine("[x] para terminar");


                     opcion = Console.ReadLine().ToLower();
                    switch (opcion)
                    {
                        case "i":
                      
                            if (asiAct < maxA)
                            {
                                asiAct++;
                                totalAsi++;
                                if (asiAct == maxA)
                                {
                                    vecesLe++;

                                }
                            }
                            else
                            {
                                Console.WriteLine("\nEl local esta lleno. No se puede ingresar mas personas");
                            }

                            break;

                        case "s":
                       
                            if (asiAct > 0)
                            {
                                asiAct--;
                                totalSa++;
                                if (asiAct == 0)
                                {
                                    vecesVa++;
                                }
                            }
                            else
                            {

                                Console.WriteLine("\nEl local ya está vacío. No se puede sacar más personas.");
                            
                            }

                            break;
                        case "x":

                            Console.Clear();    
                            break;


                        default:
                            Console.WriteLine("\nOpción no válida. Presione [i], [s] o [x].");
                            break;
                            
                    }
                    Console.Clear();
                } while (opcion !="x");
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("El programa ha terminado");
                Console.WriteLine("=================================");
                Console.WriteLine("Estadísticas:");
                Console.WriteLine("-------------------------");
                Console.WriteLine(totalAsi + " personas ingresaron.");
                Console.WriteLine(totalSa + " personas salieron.");
                Console.WriteLine(vecesLe + " veces se lleno el local");
                Console.WriteLine(vecesVa + " veces estuvo vacio el local");
            }
            else {
                Console.WriteLine("El número máximo debe ser mayor que cero.");
            }

            Console.ReadKey();  

        }
    }
}
