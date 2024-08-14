namespace Interfaz
{
    partial class Goleadores
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
            dataGridGoleadores = new DataGridView();
            Jugador = new DataGridViewTextBoxColumn();
            Goles = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridGoleadores).BeginInit();
            SuspendLayout();
            // 
            // dataGridGoleadores
            // 
            dataGridGoleadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridGoleadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridGoleadores.Columns.AddRange(new DataGridViewColumn[] { Jugador, Goles });
            dataGridGoleadores.Dock = DockStyle.Fill;
            dataGridGoleadores.Location = new Point(0, 0);
            dataGridGoleadores.Name = "dataGridGoleadores";
            dataGridGoleadores.Size = new Size(800, 450);
            dataGridGoleadores.TabIndex = 0;
            dataGridGoleadores.CellContentClick += dataGridGoleadores_CellContentClick;
            // 
            // Jugador
            // 
            Jugador.HeaderText = "Jugador";
            Jugador.Name = "Jugador";
            Jugador.Width = 74;
            // 
            // Goles
            // 
            Goles.HeaderText = "Cantidad de Goles";
            Goles.Name = "Goles";
            Goles.Width = 91;
            // 
            // Goleadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridGoleadores);
            Name = "Goleadores";
            Text = "Goleadores";
            ((System.ComponentModel.ISupportInitialize)dataGridGoleadores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridGoleadores;
        private DataGridViewTextBoxColumn Jugador;
        private DataGridViewTextBoxColumn Goles;
    }
}