using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBasico3
{
    class EjemploBasico3
    {
        static void Main(string[] args)
        {
            Double primer_numero = 0;
            Double segundo_numero = 0;
            Console.Write("Introduzca el primer númnero: ");
            primer_numero = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduzca el segundo númnero: ");
            segundo_numero = Convert.ToDouble(Console.ReadLine());

            if (primer_numero > segundo_numero )
            {
                Console.WriteLine(primer_numero + " es mayor que " + segundo_numero);
            }
            else if(segundo_numero > primer_numero)
            {
                Console.WriteLine(segundo_numero + " es mayor que " + primer_numero);
            }
            else
            {
                Console.WriteLine("Ambos números son iguales");
            }
        }
    }
}
