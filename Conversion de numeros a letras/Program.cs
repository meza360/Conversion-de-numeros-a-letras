using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_de_numeros_a_letras
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un numero inferior a mil para ver su numero expresado en letras:");

            int u = 0, d = 0, c = 0,c1 = 0;
            string uni = "", dec = "", cen = "";
            int cant = int.Parse(Console.ReadLine());
            c = cant / 100;
            c = c % 100;
            c1 = cant % 100;
            switch (c)
            {
                case 0: cen = ""; break;

                case 1:
                    if (c1==0)
                    {
                        cen = "Cien";
                    }
                    else
                    {
                        cen = "Ciento";
                    }
                              
                    break;

                case 2: cen = "Doscientos"; break;

                case 3: cen = "Trescientos"; break;

                case 4: cen = "Cuatrocientos"; break;

                case 5: cen = "Quinientos"; break;

                case 6: cen = "Seiscientos"; break;

                case 7: cen = "Setecientos"; break;

                case 8: cen = "Ochocientos"; break;

                case 9: cen = "Novescientos"; break;

                default:
                    break;
            }



            Console.WriteLine(cen);

            Console.ReadKey();


        }
    }
}
