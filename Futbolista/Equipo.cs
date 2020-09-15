using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbolista
{
    class Equipo
    {
        private string _nombre;
        private string _posicion;
        private int _goles;
        private float _precio;
        private bool _lesion;

        public Equipo(string nombre, string posicion)
        {
            this._nombre = nombre;
            this._posicion = posicion;
        }
        public Equipo(string nombre, string posicion, int goles, float precio) : this(nombre, posicion)
        {
                this._goles = goles;
                this._precio = precio;
                this._lesion = false;
     
        }

        public float Precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }
        public string posicion
        {
            get { return this._posicion; }
            set { this._posicion = value; }
        }

        public void hacerGol()
        {
            this._goles = 0;
        }

        public void hacerGol(int goles)
        {
            this._goles += goles;
        }
 
        public override string ToString()
        {
            return string.Format("Nombre: {0} -- Posicion: {1} -- Goles: {2} -- Precio: {3} -- Lesion: {4}", this._nombre, this._posicion, this._goles, this._precio, this._lesion);
        }

    }
}
