namespace Interfaz
{
    partial class Jugadores
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
            dataGridJugadores = new DataGridView();
            Equipo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Dorsal = new DataGridViewTextBoxColumn();
            NroGoles = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridJugadores).BeginInit();
            SuspendLayout();
            // 
            // dataGridJugadores
            // 
            dataGridJugadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridJugadores.Columns.AddRange(new DataGridViewColumn[] { Equipo, Nombre, Apellido, DNI, Dorsal, NroGoles });
            dataGridJugadores.Dock = DockStyle.Fill;
            dataGridJugadores.Location = new Point(0, 0);
            dataGridJugadores.Name = "dataGridJugadores";
            dataGridJugadores.Size = new Size(800, 450);
            dataGridJugadores.TabIndex = 0;
            dataGridJugadores.CellContentClick += dataGridJugadores_CellContentClick;
            // 
            // Equipo
            // 
            Equipo.HeaderText = "Equipo";
            Equipo.Name = "Equipo";
            Equipo.Width = 69;
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
            // Dorsal
            // 
            Dorsal.HeaderText = "Dorsal";
            Dorsal.Name = "Dorsal";
            Dorsal.Width = 65;
            // 
            // NroGoles
            // 
            NroGoles.HeaderText = "N° Goles";
            NroGoles.Name = "NroGoles";
            NroGoles.Width = 78;
            // 
            // Jugadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridJugadores);
            Name = "Jugadores";
            Text = "Lista de Jugadores";
            ((System.ComponentModel.ISupportInitialize)dataGridJugadores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridJugadores;
        private DataGridViewTextBoxColumn Equipo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Dorsal;
        private DataGridViewTextBoxColumn NroGoles;
    }
}