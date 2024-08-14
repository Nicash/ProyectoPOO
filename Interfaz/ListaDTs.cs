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
    public partial class formListaDTs : Form
    {
        public formListaDTs()
        {
            InitializeComponent();
            ActualizarListaDTs();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActualizarListaDTs()
        {
            foreach (DirectorTecnico dt in Logica.ListaDT)
            {
                dataGridListaDTs.Rows.Add(dt.Nombre, dt.Apellido, dt.DNI, dt.NroCarnet);
            }
        }
    }
}
