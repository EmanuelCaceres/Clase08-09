using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Ventas v1 = new Ventas(10,20);
            v1.verificoStock();
            v1.compraStock(15, 15);

            Ventas animal1 = new Ventas("Radiografía", "Perro", "Balanceado", 10,10);
            Console.WriteLine(animal1.compraStock(20, 20));
            Console.WriteLine(animal1.ToString());

        }
    }
}
