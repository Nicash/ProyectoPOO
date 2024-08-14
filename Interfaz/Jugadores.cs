using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Jugadores : Form
    {
        public Jugadores()
        {
            InitializeComponent();
            ActualizarListaJugadores();
        }

        private void dataGridJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActualizarListaJugadores() {
            foreach (Equipo equipo in Logica.ListaEquipos)
            {
                foreach (Jugador jugador in equipo.ListaJugadores)
                {
                    dataGridJugadores.Rows.Add(equipo.Nombre, jugador.Nombre, jugador.Apellido, jugador.DNI, jugador.Dorsal, jugador.NroGoles);
                }
            }
        }
    }
}
