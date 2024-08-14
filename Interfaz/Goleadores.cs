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
    public partial class Goleadores : Form
    {
        public Goleadores()
        {
            InitializeComponent();
            ActualizarListaGoleadores();
        }

        private void dataGridGoleadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActualizarListaGoleadores()
        {
            var jugadoresConGoles = new List<Jugador>();

            foreach (Equipo equipo in Logica.ListaEquipos)
            {
                foreach (Jugador jugador in equipo.ListaJugadores)
                {
                    if (jugador.NroGoles > 0)
                    {
                        jugadoresConGoles.Add(jugador);
                    }
                }
            }

            // Ordenar la lista de jugadores por NroGoles en orden descendente
            var jugadoresOrdenados = jugadoresConGoles.OrderByDescending(j => j.NroGoles).ToList();

            // Limpiar las filas existentes en el DataGridView
            dataGridGoleadores.Rows.Clear();

            // Agregar los jugadores ordenados al DataGridView
            foreach (var jugador in jugadoresOrdenados)
            {
                dataGridGoleadores.Rows.Add(jugador.Nombre + " " + jugador.Apellido, jugador.NroGoles);
            }
        }

    }
}
