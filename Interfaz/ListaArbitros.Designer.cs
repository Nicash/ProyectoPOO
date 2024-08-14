namespace Interfaz
{
    partial class ListaArbitros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridArbitros = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            NroCarnet = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridArbitros).BeginInit();
            SuspendLayout();
            // 
            // dataGridArbitros
            // 
            dataGridArbitros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridArbitros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridArbitros.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, DNI, NroCarnet });
            dataGridArbitros.Dock = DockStyle.Fill;
            dataGridArbitros.Location = new Point(0, 0);
            dataGridArbitros.Name = "dataGridArbitros";
            dataGridArbitros.Size = new Size(800, 450);
            dataGridArbitros.TabIndex = 0;
            dataGridArbitros.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 76;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.Width = 76;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            DNI.Width = 52;
            // 
            // NroCarnet
            // 
            NroCarnet.HeaderText = "N° Carnet";
            NroCarnet.Name = "NroCarnet";
            NroCarnet.Width = 84;
            // 
            // formArbitros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridArbitros);
            Name = "formArbitros";
            Text = "Árbitros";
            ((System.ComponentModel.ISupportInitialize)dataGridArbitros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridArbitros;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn NroCarnet;
    }
}