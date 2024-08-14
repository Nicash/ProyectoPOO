namespace Interfaz
{
    partial class formListaDTs
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
            dataGridListaDTs = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            NroCarnet = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridListaDTs).BeginInit();
            SuspendLayout();
            // 
            // dataGridListaDTs
            // 
            dataGridListaDTs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridListaDTs.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, DNI, NroCarnet });
            dataGridListaDTs.Dock = DockStyle.Fill;
            dataGridListaDTs.Location = new Point(0, 0);
            dataGridListaDTs.Name = "dataGridListaDTs";
            dataGridListaDTs.Size = new Size(800, 450);
            dataGridListaDTs.TabIndex = 0;
            dataGridListaDTs.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            // 
            // NroCarnet
            // 
            NroCarnet.HeaderText = "N° Carnet";
            NroCarnet.Name = "NroCarnet";
            // 
            // formListaDTs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridListaDTs);
            Name = "formListaDTs";
            Text = "Lista de DTs";
            ((System.ComponentModel.ISupportInitialize)dataGridListaDTs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridListaDTs;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn NroCarnet;
    }
}