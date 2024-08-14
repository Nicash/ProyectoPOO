using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Arbitro : Persona
    {
        public int NroCarnet {  get; set; }

        public Arbitro(string nombre, string apellido, int dni, int nroCarnet) : base(nombre, apellido, dni)
        {
            this.NroCarnet = nroCarnet;
        }
    }
}
