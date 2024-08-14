using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        public int NroCarnet {  get; set; }

        public DirectorTecnico(string nombre, string apellido, int dni, int nroCarnet) : base(nombre, apellido, dni)
        {
            this.NroCarnet = nroCarnet;
        }
    }
}
