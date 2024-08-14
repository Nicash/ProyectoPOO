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
    public partial class Equipos : Form
    {
        public Equipos()
        {
            InitializeComponent();
            ActualizarListaEquipos();

        }

        private void Equipos_Load(object sender, EventArgs e)
        {

        }

        private void ActualizarListaEquipos()
        {
            foreach (Equipo equipo in Logica.ListaEquipos)
            {
                dataGridEquipos.Rows.Add(equipo.Nombre, equipo.Siglas, equipo.Color1, equipo.Color2, Logica.ObtenerNombreDT(equipo.DNI_DirectorTecnico));
            }
        }

        private void dataGridEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
