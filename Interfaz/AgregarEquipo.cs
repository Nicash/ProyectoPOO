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
    public partial class AgregarEquipo : Form
    {
        private Equipo equipoTemp;
        public AgregarEquipo()
        {
            InitializeComponent();
            equipoTemp = new Equipo();
            ActualizarListaDTs();
        }

        private void btnGuardarEquipo_Click(object sender, EventArgs e)
        {
            equipoTemp.Nombre = txtNombreEquipo.Text;
            equipoTemp.Siglas = txtSiglasEquipo.Text;
            equipoTemp.Color1 = txtColor1Equipo.Text;
            equipoTemp.Color2 = txtColor2Equipo.Text;
            equipoTemp.DNI_DirectorTecnico = Logica.ListaDT[comboBoxDTEquipo.SelectedIndex].DNI;

            Logica.ListaEquipos.Add(equipoTemp);
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            Jugador jugador = new Jugador(
                txtNombreJugador.Text,
                txtApellidoJugador.Text,
                int.Parse(txtDNIJugador.Text),
                int.Parse(txtDorsal.Text),
                int.Parse(txtNroGoles.Text));

            equipoTemp.ListaJugadores.Add(jugador);
            ActualizarListaJugadores();

        }

        private void ActualizarListaJugadores()
        {
            listBoxJugadoresEquipo.Items.Clear();
            foreach (Jugador jugador in equipoTemp.ListaJugadores)
            {
                listBoxJugadoresEquipo.Items.Add(jugador.Dorsal + " | " + jugador.Apellido + ", " + jugador.Nombre);

            }
        }

        private void ActualizarListaDTs()
        {
            comboBoxDTEquipo.Items.Clear();
           if (Logica.ListaDT == null) return;
           foreach (DirectorTecnico dt in Logica.ListaDT)
            {
                comboBoxDTEquipo.Items.Add(dt.Apellido + ", " + dt.Nombre);
            }
        }


        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {
            int idJugadorSeleccionado = listBoxJugadoresEquipo.SelectedIndex;

            if (idJugadorSeleccionado == -1) return;
            equipoTemp.ListaJugadores.RemoveAt(idJugadorSeleccionado);
            ActualizarListaJugadores();
        }

        private void btnAgregarDT_Click(object sender, EventArgs e)
        {
            AgregarDT formDT = new AgregarDT();

            formDT.ShowDialog();
        }

        private void AgregarEquipo_Load(object sender, EventArgs e)
        {

        }
    }
}
