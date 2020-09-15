using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu p1 = new Menu("Asado", 20, 80, 420);
            Menu p2 = new Menu("Pastas", 10, 50, 350);

            List<Menu> LstProductos = new List<Menu>();
            LstProductos.Add(p1);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            p1.quitarStock(30);
            p1.reservar(5);
            p2.reservar(8);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            p1.quitarStock(70);
            p2.quitarStock(30);
            p2.quitarStock(30);
            p2.sumarStock(50);
            p2.quitarStock(30);
            p1.reservar(5);
            p2.reservar(25);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            Console.ReadKey();

        }
    }
}
