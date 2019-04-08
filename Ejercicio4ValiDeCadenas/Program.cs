using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4ValiDeCadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            string entero;
            Console.WriteLine("Ingrese un numero entero");
            entero = Console.ReadLine();

            if (int.TryParse(entero, out int result))

            { Console.WriteLine($"Ud ingresó {result}"); }
            else
            { Console.WriteLine("Error"); };

            string nrodecimal;
            Console.WriteLine("Ingrese un numero decimal");
            nrodecimal = Console.ReadLine();

            if (decimal.TryParse(nrodecimal, out decimal result1))
            { Console.WriteLine($"El numero ingresado fue: {result1}"); }
            else
            { Console.WriteLine("Error"); ; }
            

            string entnegativo;
            Console.WriteLine("Ingrese un entero negativo");
            entnegativo = Console.ReadLine();

            if (int.TryParse(entnegativo, out int result2))
            {
                if (result2 >= 0)
                { Console.WriteLine("Usted no ingresó un numero negativo"); }
                else { Console.WriteLine($"Ud.ingresó el nro: {result2}"); } }

            else { Console.WriteLine("Ud no ingresó un nro entero"); }


            string decnegativo;
            Console.WriteLine("Ingrese un entero negativo");
            decnegativo = Console.ReadLine();

            if (decimal.TryParse(decnegativo, out decimal result3))
            {
                if (result3 >= 0)
                { Console.WriteLine("Usted no ingresó un decimal negativo"); }
                else { Console.WriteLine($"Ud.ingresó el nro: {result3}"); }
            }

            else { Console.WriteLine("Ud no ingresó un nro decimal"); }
            Console.ReadKey();







        }
    }
}
