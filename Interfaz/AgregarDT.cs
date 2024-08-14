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
    public partial class AgregarDT : Form
    {
        public AgregarDT()
        {
            InitializeComponent();
            actualizarListaDTs();
        }

        private void txtApellidoDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarDT_Load(object sender, EventArgs e)
        {

        }

        private void actualizarListaDTs()
        {
            listBoxDTs.Items.Clear();
            if(Negocio.Logica.ListaDT == null) return;
            foreach (DirectorTecnico dt in Negocio.Logica.ListaDT)
            {
                listBoxDTs.Items.Add(dt.Apellido + ", " + dt.Nombre);
            }
        }

        private void btnEliminarDT_Click(object sender, EventArgs e)
        {
            int idDTSeleccionado = listBoxDTs.SelectedIndex;

            if (idDTSeleccionado == -1) return;
            Negocio.Logica.ListaDT.RemoveAt(idDTSeleccionado);
            actualizarListaDTs();
        }

        private void btnAgregarDT_Click(object sender, EventArgs e)
        {
            DirectorTecnico dt = new DirectorTecnico(
               txtNombreDT.Text,
               txtApellidoDT.Text,
               int.Parse(txtDNIDT.Text),
               int.Parse(txtNroCarnet.Text));

            Negocio.Logica.ListaDT.Add(dt);
            actualizarListaDTs();
        }
    }
}
