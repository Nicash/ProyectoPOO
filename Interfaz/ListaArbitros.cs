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
    public partial class ListaArbitros : Form
    {
        public ListaArbitros()
        {
            InitializeComponent();
            ActualizarListaArbitros();
        }

        private void ActualizarListaArbitros()
        {
            foreach (Arbitro arbitro in Logica.ListaArbitros)
            {
                dataGridArbitros.Rows.Add(arbitro.Nombre, arbitro.Apellido, arbitro.DNI, arbitro.NroCarnet);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
