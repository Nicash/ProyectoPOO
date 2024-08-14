namespace Interfaz
{
    partial class Equipos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridEquipos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Siglas = new DataGridViewTextBoxColumn();
            Color1 = new DataGridViewTextBoxColumn();
            Color2 = new DataGridViewTextBoxColumn();
            Entrenador = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridEquipos).BeginInit();
            SuspendLayout();
            // 
            // dataGridEquipos
            // 
            dataGridEquipos.AllowUserToAddRows = false;
            dataGridEquipos.AllowUserToDeleteRows = false;
            dataGridEquipos.AllowUserToResizeColumns = false;
            dataGridEquipos.AllowUserToResizeRows = false;
            dataGridEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEquipos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Siglas, Color1, Color2, Entrenador });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridEquipos.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridEquipos.Dock = DockStyle.Fill;
            dataGridEquipos.Enabled = false;
            dataGridEquipos.Location = new Point(0, 0);
            dataGridEquipos.Name = "dataGridEquipos";
            dataGridEquipos.ReadOnly = true;
            dataGridEquipos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridEquipos.Size = new Size(800, 450);
            dataGridEquipos.TabIndex = 0;
            dataGridEquipos.CellContentClick += dataGridEquipos_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 78;
            // 
            // Siglas
            // 
            Siglas.HeaderText = "Siglas";
            Siglas.Name = "Siglas";
            Siglas.ReadOnly = true;
            Siglas.Width = 63;
            // 
            // Color1
            // 
            Color1.HeaderText = "Color 1";
            Color1.Name = "Color1";
            Color1.ReadOnly = true;
            Color1.Width = 71;
            // 
            // Color2
            // 
            Color2.HeaderText = "Color 2";
            Color2.Name = "Color2";
            Color2.ReadOnly = true;
            Color2.Width = 71;
            // 
            // Entrenador
            // 
            Entrenador.HeaderText = "Entrenador";
            Entrenador.Name = "Entrenador";
            Entrenador.ReadOnly = true;
            Entrenador.Width = 94;
            // 
            // Equipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridEquipos);
            Name = "Equipos";
            Text = "Equipos";
            Load += Equipos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridEquipos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridEquipos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Siglas;
        private DataGridViewTextBoxColumn Color1;
        private DataGridViewTextBoxColumn Color2;
        private DataGridViewTextBoxColumn Entrenador;
    }
}