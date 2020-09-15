using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Menu
    {
        private string platoDia;
        private int cant_mesas;
        private int stock;
        private float precio;

        public Menu(string platoDia, int cant_mesas, int stock, float precio)
        { 
            this.platoDia = platoDia;
            this.cant_mesas = cant_mesas;
            this.stock = stock;
            this.precio = precio;
        }

        public Menu(string platoDia, int stock)
        {
            this.platoDia = platoDia;
            this.stock = stock;
        }

        public string PlatoDia
        {
            get { return this.platoDia; }
            set { this.platoDia = value; }

        }
        public int Cant_mesas 
        { 
          get { return this.cant_mesas; }
          set { this.cant_mesas = value;}
        }

        public float Precio
        {
            get { return this.precio; }
            set { this.precio = value; }

        }

        public int Stock
        {
            get { return this.stock; }
            set { this.stock = value; }
        }


        public void reservar(int mesas)
        {
            if (this.cant_mesas - mesas < 0)
            {
                Console.WriteLine($"No hay mesas disponibles para reservar. Quedan {this.cant_mesas} disponibles");
            }
            else
                {
                    this.cant_mesas -= mesas;
                    Console.WriteLine($"Quedan disponibles {this.cant_mesas} mesas");
                }
            
            
        }
        public void sumarStock(int nuevoStock)
        {
            stock += nuevoStock;
            Console.WriteLine($"Luego de la compra de {nuevoStock} unidades de {this.platoDia}, mi nuevo stock es de {this.stock} unidades");
        }

        public void quitarStock(int nuevoStock)
        {
            if (this.stock - nuevoStock < 0)
            {
                Console.WriteLine($"No tengo stock para vender {this.platoDia}. Me quedan {this.stock} unidades disponibles ");
            }
            else
            {     
            this.stock -= nuevoStock;
                Console.WriteLine($"Se vendieron {nuevoStock} de {this.platoDia}. Mi nuevo stock es {this.stock}");
            }
        }

   
        public override string ToString()
        {
            return string.Format("Plato del dia: {0} -- Cantidad de mesas {1} -- Stock {2} -- Precio {3} --", this.platoDia, this.cant_mesas, this.stock, this.precio);
        }


    }


}
