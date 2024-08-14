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
            actualizarListaArbitros();
            actualizarListaDTs();
            actualizarListaEquipos();
            Enfocar_Primeros();
            ActualizarLabels();
        }

        private void ActualizarLabels()
        {
            if (listBoxDTs.Items.Count > 0)
            {
                lblNombreYApellidoDT.Text = Logica.ListaDT[listBoxDTs.SelectedIndex].Nombre + " " + Logica.ListaDT[listBoxDTs.SelectedIndex].Apellido;
                lblDNIDT.Text = "DNI: " + Logica.ListaDT[listBoxDTs.SelectedIndex].DNI.ToString();
                lblNroCarnetDT.Text = "Nro. Carnet: " + Logica.ListaDT[listBoxDTs.SelectedIndex].NroCarnet.ToString();
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

        private void actualizarListaDTs()
        {
            listBoxDTs.Items.Clear();
            if (Logica.ListaDT == null) return;
            foreach (DirectorTecnico dt in Logica.ListaDT)
            {
                listBoxDTs.Items.Add(dt.Apellido + ", " + dt.Nombre);
            }
        }

        private void actualizarListaEquipos()
        {
            listBoxEquipos.Items.Clear();
            if (Logica.ListaEquipos == null) return;
            foreach (Equipo equipo in Logica.ListaEquipos)
            {
                listBoxEquipos.Items.Add(equipo.Nombre + " (" + equipo.Siglas + ")");
            }
        }

        private void actualizarListaArbitros()
        {
            listBoxArbitros.Items.Clear();
            if (Logica.ListaArbitros == null) return;
            foreach (Arbitro arbitro in Logica.ListaArbitros)
            {
                listBoxArbitros.Items.Add(arbitro.Apellido + ", " + arbitro.Nombre);
            }
        }

        private void groupBoxArbitros_Enter(object sender, EventArgs e)
        {

        }
    }
}
