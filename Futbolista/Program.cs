using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbolista
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo num1 = null;
            Equipo num2 = null;
            try
            {
                num1 = new Equipo("Leonel", "Messi");
                num2 = new Equipo("Paulo", "Dybala", 35, 5000000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            List<Equipo> LstProductos = new List<Equipo>();
            LstProductos.Add(num1);
            LstProductos.Add(num2);

            Console.WriteLine(num1.ToString());
            Console.WriteLine(num2.ToString());

            num1.hacerGol();
            num1.hacerGol(10);
            num2.hacerGol(25);

            Console.WriteLine(num1.ToString());
            Console.WriteLine(num2.ToString());

            Console.ReadKey();


        }
    }
}
