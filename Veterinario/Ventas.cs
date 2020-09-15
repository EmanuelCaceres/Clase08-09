using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario
{
    class Ventas
    {
        private int stockVacunas;
        private int dosis;
        private string tipoEstudios;
        private string tipoAnimal;
        private string tipoAlimento;

        public Ventas(int stockVacunas, int dosis)
        {
            this.stockVacunas = stockVacunas;
            this.dosis = dosis;
        }

        public Ventas(string tipoEstudios, string tipoAnimal, string tipoAlimento, int stockVacunas, int dosis)
        {
            this.tipoEstudios = tipoEstudios;
            this.tipoAnimal = tipoAnimal;
            this.tipoAlimento = tipoAlimento;
            this.stockVacunas = stockVacunas;
            this.dosis = dosis;
        }

        public void verificoStock()
        {
            Console.WriteLine($"El stock que queda de vacunas es de {this.stockVacunas}");
            Console.WriteLine($"La cantidad de dosis que quedan en stock son {this.dosis}");
            
        }

        public string compraStock(int stockVacunas, int dosis)
        {
            
            this.stockVacunas += stockVacunas;
            this.dosis += dosis;

            Console.WriteLine($"La nueva cantidad de stock de vacunas es de {this.stockVacunas} unidades");
            Console.WriteLine($"La nueva cantidad de dosis es de {this.dosis} unidades");

            return ("Compra con éxito");
         }

        public override string ToString()
        {
            return string.Format("Tipo de Estudios {0}-- Tipo de animal {1} -- Tipo de Alimento {2} -- Stock de vacunas {3} -- Tipo de estudios {4}", this.tipoEstudios, this.tipoAnimal, this.tipoAlimento, this.stockVacunas, this.dosis);
        }
    }
}
