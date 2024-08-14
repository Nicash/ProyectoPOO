using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        public string Nombre { get; set; }
        public string Siglas { get; set; }
        public string Color1 { get; set; }
        public string Color2 { get; set; }
        public int DNI_DirectorTecnico { get; set; }
        public List<Jugador> ListaJugadores { get; set; }

        public Equipo()
        {
            ListaJugadores = new List<Jugador>();
        }

    }
}
