using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        public int Dorsal { get; set; }
        public int NroGoles { get; set; }

        public Jugador(string nombre, string apellido, int dni, int dorsal, int nrogoles) : base(nombre, apellido, dni)
        {
            this.Dorsal = dorsal;
            this.NroGoles = nrogoles;
        }
    }
}
