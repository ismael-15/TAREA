using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUNATAREA
{
    public class Collection
    {
        public static void SortedListCollection()
        {
            double cantidad1;
            double cantidad2;
            string operacion;
            double total;

            Console.WriteLine("Escriba la opcion que desea realizar");
            Console.WriteLine("1.-SUMAR");
            Console.WriteLine("2.-MULTIPLICAR");
            operacion = Console.ReadLine();

            Console.WriteLine("Ingrese el primer valor= ");
            cantidad1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor= ");
            cantidad2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            if (operacion == "SUMAR")
            {
                total = cantidad1 + cantidad2;
                Console.WriteLine("El resultado de la suma es= " + total);
                Console.ReadLine();
            }
            if (operacion == "MULTIPLICAR")
            {
                total = cantidad1 * cantidad2;
                Console.WriteLine("El resultado de la multiplicacion es= " + total);
                Console.ReadLine();

            }
        }
    }
}



  