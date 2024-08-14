using Entidades;
using Negocio;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            this.Activated += new EventHandler(Principal_Activated);

            Logica.Iniciar();


        }

        private void Principal_Activated(object sender, EventArgs e)
        {
            ActualizarListaDTs();
            ActualizarListaEquipos();
            ActualizarListaJugadores();
            ActualizarListaArbitros();
            Enfocar_Primeros();
            ActualizarLabels();
        }

        private void ActualizarLabels()
        {
            if (listBoxDTs.Items.Count > 0)
            {
                if (listBoxDTs.SelectedIndex == -1)
                {
                    Enfocar_Primeros();
                }

                lblNombreYApellidoDT.Text = Logica.ListaDT[listBoxDTs.SelectedIndex].Nombre + " " + Logica.ListaDT[listBoxDTs.SelectedIndex].Apellido;
                lblDNIDT.Text = "DNI: " + Logica.ListaDT[listBoxDTs.SelectedIndex].DNI.ToString();
                lblNroCarnetDT.Text = "Nro. Carnet: " + Logica.ListaDT[listBoxDTs.SelectedIndex].NroCarnet.ToString();
            }

            if (listBoxEquipos.Items.Count > 0)
            {
                if (listBoxEquipos.SelectedIndex == -1)
                {
                    Enfocar_Primeros();
                }

                groupBoxEquipoActual.Text = Logica.ListaEquipos[listBoxEquipos.SelectedIndex].Nombre + " (" + Logica.ListaEquipos[listBoxEquipos.SelectedIndex].Siglas + ")";
                lblDatosDT.Text = Logica.ObtenerNombreDT(Logica.ListaEquipos[listBoxEquipos.SelectedIndex].DNI_DirectorTecnico);
                lblColor1y2.Text = Logica.ListaEquipos[listBoxEquipos.SelectedIndex].Color1 + " - " + Logica.ListaEquipos[listBoxEquipos.SelectedIndex].Color2;
            }

            if (listBoxArbitros.Items.Count > 0)
            {
                if (listBoxArbitros.SelectedIndex == -1)
                {
                    Enfocar_Primeros();
                }

                lblNombreApellidoArbitro.Text = Logica.ListaArbitros[listBoxArbitros.SelectedIndex].Nombre + " " + Logica.ListaArbitros[listBoxArbitros.SelectedIndex].Apellido;
                lblDNIArbitro.Text = "DNI: " + Logica.ListaArbitros[listBoxArbitros.SelectedIndex].DNI.ToString();
                lblNroCarnetArbitro.Text = "Nro. Carnet: " + Logica.ListaArbitros[listBoxArbitros.SelectedIndex].NroCarnet.ToString();
            }

        }

        private void Enfocar_Primeros()
        {
            if (listBoxDTs.Items.Count > 0)
            {
                listBoxDTs.SelectedIndex = 0;
            }

            if (listBoxEquipos.Items.Count > 0)
            {
                listBoxEquipos.SelectedIndex = 0;
            }

            if (listBoxArbitros.Items.Count > 0)
            {
                listBoxArbitros.SelectedIndex = 0;
            }

            if (listBoxJugadores.Items.Count > 0)
            {
                listBoxJugadores.SelectedIndex = 0;
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            AgregarEquipo formEquipo = new AgregarEquipo();

            formEquipo.ShowDialog();
        }

        private void lblAgregarArbitro_Click(object sender, EventArgs e)
        {
            AgregarArbitro formArbitro = new AgregarArbitro();

            formArbitro.ShowDialog();
        }

        private void lblAgregarDT_Click(object sender, EventArgs e)
        {
            AgregarDT formDT = new AgregarDT();
            formDT.ShowDialog();

        }

        private void btnGuardarTodo_Click(object sender, EventArgs e)
        {
            Logica.GuardarDatos();
        }

        private void ActualizarListaDTs()
        {
            listBoxDTs.Items.Clear();
            if (Logica.ListaDT == null) return;
            foreach (DirectorTecnico dt in Logica.ListaDT)
            {
                listBoxDTs.Items.Add(dt.Apellido + ", " + dt.Nombre);
            }
        }

        private void ActualizarListaEquipos()
        {
            listBoxEquipos.Items.Clear();
            if (Logica.ListaEquipos == null) return;
            foreach (Equipo equipo in Logica.ListaEquipos)
            {
                listBoxEquipos.Items.Add(equipo.Nombre + " (" + equipo.Siglas + ")");
            }
        }

        private void ActualizarListaArbitros()
        {
            listBoxArbitros.Items.Clear();
            if (Logica.ListaArbitros == null) return;
            foreach (Arbitro arbitro in Logica.ListaArbitros)
            {
                listBoxArbitros.Items.Add(arbitro.Apellido + ", " + arbitro.Nombre);
            }
        }

        private void ActualizarListaJugadores()
        {
            listBoxJugadores.Items.Clear();
            if (Logica.ListaEquipos == null) return;
            if (listBoxEquipos.SelectedIndex == -1)
            {
                return;
            }
            foreach (Jugador jugador in Logica.ListaEquipos[listBoxEquipos.SelectedIndex].ListaJugadores)
            {
                listBoxJugadores.Items.Add(jugador.Dorsal + " | " + jugador.Apellido + ", " + jugador.Nombre);
            }
        }

        private void groupBoxArbitros_Enter(object sender, EventArgs e)
        {

        }

        private void listBoxDTs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarLabels();
        }

        private void listBoxArbitros_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarLabels();
        }

        private void listBoxEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarLabels();
            ActualizarListaJugadores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Equipos formEquipos = new Equipos();
            formEquipos.ShowDialog();

        }

        private void btnVerJugadores_Click(object sender, EventArgs e)
        {
            Jugadores formJugadores = new Jugadores();
            formJugadores.ShowDialog();
        }

        private void btnVerArbitros_Click(object sender, EventArgs e)
        {
            ListaArbitros formArbitros = new ListaArbitros();
            formArbitros.ShowDialog();
        }

        private void btnVerDTs_Click(object sender, EventArgs e)
        {
            formListaDTs formListaDTs = new formListaDTs();
            formListaDTs.ShowDialog();
        }

        private void btnVerGoleadores_Click(object sender, EventArgs e)
        {
            Goleadores formGoleadores = new Goleadores();
            formGoleadores.ShowDialog();
        }
    }
}
