using Entidades;
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
    public partial class AgregarArbitro : Form
    {
        public AgregarArbitro()
        {
            InitializeComponent();
        }

        private void btnAgregarArbitro_Click(object sender, EventArgs e)
        {
            Arbitro arbitro = new Arbitro(
               txtNombreArbitro.Text,
               txtApellidoArbitro.Text,
               int.Parse(txtDNIArbitro.Text),
               int.Parse(txtNroCarnetArbitro.Text));

            Negocio.Logica.ListaArbitros.Add(arbitro);
            actualizarListaArbitros();
        }

        private void actualizarListaArbitros()
        {
            lstListaArbitros.Items.Clear();
            if (Negocio.Logica.ListaArbitros == null) return;
            foreach (Arbitro arbitro in Negocio.Logica.ListaArbitros)
            {
                lstListaArbitros.Items.Add(arbitro.Apellido + ", " + arbitro.Nombre);
            }
        }

        private void btnEliminarDT_Click(object sender, EventArgs e)
        {
            int idArbitroSeleccionado = lstListaArbitros.SelectedIndex;

            if (idArbitroSeleccionado == -1) return;
            Negocio.Logica.ListaDT.RemoveAt(idArbitroSeleccionado);
            actualizarListaArbitros();
        }
    }
}
