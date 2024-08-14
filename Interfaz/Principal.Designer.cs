namespace Interfaz
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblListadoEquipos = new Label();
            listBoxEquipos = new ListBox();
            btnAgregarEquipo = new Button();
            groupBoxEquipoActual = new GroupBox();
            lblListaJugadores = new Label();
            listBoxJugadores = new ListBox();
            lblColor1y2 = new Label();
            lblColores = new Label();
            lblDatosDT = new Label();
            lblDT = new Label();
            lblAgregarDT = new Button();
            lblAgregarArbitro = new Button();
            groupBoxArbitros = new GroupBox();
            label1 = new Label();
            lblDNIArbitro = new Label();
            lblNombreApellidoArbitro = new Label();
            listBoxArbitros = new ListBox();
            groupBoxDTs = new GroupBox();
            lblNroCarnetDT = new Label();
            lblDNIDT = new Label();
            lblNombreYApellidoDT = new Label();
            listBoxDTs = new ListBox();
            btnGuardarTodo = new Button();
            groupBoxEquipoActual.SuspendLayout();
            groupBoxArbitros.SuspendLayout();
            groupBoxDTs.SuspendLayout();
            SuspendLayout();
            // 
            // lblListadoEquipos
            // 
            lblListadoEquipos.Location = new Point(12, 9);
            lblListadoEquipos.Name = "lblListadoEquipos";
            lblListadoEquipos.Size = new Size(120, 23);
            lblListadoEquipos.TabIndex = 0;
            lblListadoEquipos.Text = "Listado de Equipos";
            lblListadoEquipos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBoxEquipos
            // 
            listBoxEquipos.FormattingEnabled = true;
            listBoxEquipos.ItemHeight = 15;
            listBoxEquipos.Location = new Point(12, 35);
            listBoxEquipos.Name = "listBoxEquipos";
            listBoxEquipos.Size = new Size(120, 319);
            listBoxEquipos.TabIndex = 1;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.Location = new Point(12, 360);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(120, 23);
            btnAgregarEquipo.TabIndex = 2;
            btnAgregarEquipo.Text = "Agregar Equipo";
            btnAgregarEquipo.UseMnemonic = false;
            btnAgregarEquipo.UseVisualStyleBackColor = true;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // groupBoxEquipoActual
            // 
            groupBoxEquipoActual.Controls.Add(lblListaJugadores);
            groupBoxEquipoActual.Controls.Add(listBoxJugadores);
            groupBoxEquipoActual.Controls.Add(lblColor1y2);
            groupBoxEquipoActual.Controls.Add(lblColores);
            groupBoxEquipoActual.Controls.Add(lblDatosDT);
            groupBoxEquipoActual.Controls.Add(lblDT);
            groupBoxEquipoActual.Location = new Point(138, 34);
            groupBoxEquipoActual.Name = "groupBoxEquipoActual";
            groupBoxEquipoActual.Size = new Size(245, 349);
            groupBoxEquipoActual.TabIndex = 3;
            groupBoxEquipoActual.TabStop = false;
            groupBoxEquipoActual.Text = "nombreEquipo";
            // 
            // lblListaJugadores
            // 
            lblListaJugadores.AutoSize = true;
            lblListaJugadores.Location = new Point(6, 68);
            lblListaJugadores.Name = "lblListaJugadores";
            lblListaJugadores.Size = new Size(106, 15);
            lblListaJugadores.TabIndex = 5;
            lblListaJugadores.Text = "Lista de Jugadores:";
            // 
            // listBoxJugadores
            // 
            listBoxJugadores.FormattingEnabled = true;
            listBoxJugadores.ItemHeight = 15;
            listBoxJugadores.Location = new Point(6, 84);
            listBoxJugadores.Name = "listBoxJugadores";
            listBoxJugadores.Size = new Size(233, 259);
            listBoxJugadores.TabIndex = 4;
            // 
            // lblColor1y2
            // 
            lblColor1y2.AutoSize = true;
            lblColor1y2.Location = new Point(118, 44);
            lblColor1y2.Name = "lblColor1y2";
            lblColor1y2.Size = new Size(91, 15);
            lblColor1y2.TabIndex = 3;
            lblColor1y2.Text = "Color1 + Color2";
            // 
            // lblColores
            // 
            lblColores.AutoSize = true;
            lblColores.Location = new Point(62, 44);
            lblColores.Name = "lblColores";
            lblColores.Size = new Size(50, 15);
            lblColores.TabIndex = 2;
            lblColores.Text = "Colores:";
            // 
            // lblDatosDT
            // 
            lblDatosDT.AutoSize = true;
            lblDatosDT.Location = new Point(118, 19);
            lblDatosDT.Name = "lblDatosDT";
            lblDatosDT.Size = new Size(50, 15);
            lblDatosDT.TabIndex = 1;
            lblDatosDT.Text = "DatosDT";
            // 
            // lblDT
            // 
            lblDT.AutoSize = true;
            lblDT.Location = new Point(17, 19);
            lblDT.Name = "lblDT";
            lblDT.Size = new Size(95, 15);
            lblDT.TabIndex = 0;
            lblDT.Text = "Director Técnico:";
            // 
            // lblAgregarDT
            // 
            lblAgregarDT.Location = new Point(132, 123);
            lblAgregarDT.Name = "lblAgregarDT";
            lblAgregarDT.Size = new Size(102, 23);
            lblAgregarDT.TabIndex = 4;
            lblAgregarDT.Text = "Agregar DT";
            lblAgregarDT.UseVisualStyleBackColor = true;
            lblAgregarDT.Click += lblAgregarDT_Click;
            // 
            // lblAgregarArbitro
            // 
            lblAgregarArbitro.Location = new Point(132, 123);
            lblAgregarArbitro.Name = "lblAgregarArbitro";
            lblAgregarArbitro.Size = new Size(102, 23);
            lblAgregarArbitro.TabIndex = 5;
            lblAgregarArbitro.Text = "Agregar Árbitro";
            lblAgregarArbitro.UseVisualStyleBackColor = true;
            lblAgregarArbitro.Click += lblAgregarArbitro_Click;
            // 
            // groupBoxArbitros
            // 
            groupBoxArbitros.Controls.Add(label1);
            groupBoxArbitros.Controls.Add(lblAgregarArbitro);
            groupBoxArbitros.Controls.Add(lblDNIArbitro);
            groupBoxArbitros.Controls.Add(lblNombreApellidoArbitro);
            groupBoxArbitros.Controls.Add(listBoxArbitros);
            groupBoxArbitros.Location = new Point(389, 35);
            groupBoxArbitros.Name = "groupBoxArbitros";
            groupBoxArbitros.Size = new Size(284, 154);
            groupBoxArbitros.TabIndex = 6;
            groupBoxArbitros.TabStop = false;
            groupBoxArbitros.Text = "Lista de Árbitros";
            groupBoxArbitros.Enter += groupBoxArbitros_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 67);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 3;
            label1.Text = "N° Carnet: nroCarnet";
            // 
            // lblDNIArbitro
            // 
            lblDNIArbitro.AutoSize = true;
            lblDNIArbitro.Location = new Point(132, 43);
            lblDNIArbitro.Name = "lblDNIArbitro";
            lblDNIArbitro.Size = new Size(87, 15);
            lblDNIArbitro.TabIndex = 2;
            lblDNIArbitro.Text = "DNI: dniArbitro";
            // 
            // lblNombreApellidoArbitro
            // 
            lblNombreApellidoArbitro.AutoSize = true;
            lblNombreApellidoArbitro.Location = new Point(132, 22);
            lblNombreApellidoArbitro.Name = "lblNombreApellidoArbitro";
            lblNombreApellidoArbitro.Size = new Size(109, 15);
            lblNombreApellidoArbitro.TabIndex = 1;
            lblNombreApellidoArbitro.Text = "Nombre + Apellido";
            // 
            // listBoxArbitros
            // 
            listBoxArbitros.FormattingEnabled = true;
            listBoxArbitros.ItemHeight = 15;
            listBoxArbitros.Location = new Point(6, 22);
            listBoxArbitros.Name = "listBoxArbitros";
            listBoxArbitros.Size = new Size(120, 124);
            listBoxArbitros.TabIndex = 0;
            // 
            // groupBoxDTs
            // 
            groupBoxDTs.Controls.Add(lblNroCarnetDT);
            groupBoxDTs.Controls.Add(lblDNIDT);
            groupBoxDTs.Controls.Add(lblAgregarDT);
            groupBoxDTs.Controls.Add(lblNombreYApellidoDT);
            groupBoxDTs.Controls.Add(listBoxDTs);
            groupBoxDTs.Location = new Point(389, 195);
            groupBoxDTs.Name = "groupBoxDTs";
            groupBoxDTs.Size = new Size(284, 154);
            groupBoxDTs.TabIndex = 7;
            groupBoxDTs.TabStop = false;
            groupBoxDTs.Text = "Lista de DTs";
            // 
            // lblNroCarnetDT
            // 
            lblNroCarnetDT.AutoSize = true;
            lblNroCarnetDT.Location = new Point(132, 67);
            lblNroCarnetDT.Name = "lblNroCarnetDT";
            lblNroCarnetDT.Size = new Size(118, 15);
            lblNroCarnetDT.TabIndex = 3;
            lblNroCarnetDT.Text = "N° Carnet: nroCarnet";
            // 
            // lblDNIDT
            // 
            lblDNIDT.AutoSize = true;
            lblDNIDT.Location = new Point(132, 43);
            lblDNIDT.Name = "lblDNIDT";
            lblDNIDT.Size = new Size(87, 15);
            lblDNIDT.TabIndex = 2;
            lblDNIDT.Text = "DNI: dniArbitro";
            // 
            // lblNombreYApellidoDT
            // 
            lblNombreYApellidoDT.AutoSize = true;
            lblNombreYApellidoDT.Location = new Point(132, 22);
            lblNombreYApellidoDT.Name = "lblNombreYApellidoDT";
            lblNombreYApellidoDT.Size = new Size(109, 15);
            lblNombreYApellidoDT.TabIndex = 1;
            lblNombreYApellidoDT.Text = "Nombre + Apellido";
            // 
            // listBoxDTs
            // 
            listBoxDTs.FormattingEnabled = true;
            listBoxDTs.ItemHeight = 15;
            listBoxDTs.Location = new Point(6, 22);
            listBoxDTs.Name = "listBoxDTs";
            listBoxDTs.Size = new Size(120, 124);
            listBoxDTs.TabIndex = 0;
            // 
            // btnGuardarTodo
            // 
            btnGuardarTodo.Location = new Point(584, 362);
            btnGuardarTodo.Name = "btnGuardarTodo";
            btnGuardarTodo.Size = new Size(89, 23);
            btnGuardarTodo.TabIndex = 8;
            btnGuardarTodo.Text = "Guardar Todo";
            btnGuardarTodo.UseVisualStyleBackColor = true;
            btnGuardarTodo.Click += btnGuardarTodo_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 397);
            Controls.Add(btnGuardarTodo);
            Controls.Add(groupBoxDTs);
            Controls.Add(groupBoxArbitros);
            Controls.Add(groupBoxEquipoActual);
            Controls.Add(btnAgregarEquipo);
            Controls.Add(listBoxEquipos);
            Controls.Add(lblListadoEquipos);
            Name = "Principal";
            Text = "Liga de Futbol";
            Load += Principal_Load;
            groupBoxEquipoActual.ResumeLayout(false);
            groupBoxEquipoActual.PerformLayout();
            groupBoxArbitros.ResumeLayout(false);
            groupBoxArbitros.PerformLayout();
            groupBoxDTs.ResumeLayout(false);
            groupBoxDTs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblListadoEquipos;
        private ListBox listBoxEquipos;
        private Button btnAgregarEquipo;
        private GroupBox groupBoxEquipoActual;
        private Label lblColores;
        private Label lblDatosDT;
        private Label lblDT;
        private Label lblColor1y2;
        private Label lblListaJugadores;
        private ListBox listBoxJugadores;
        private Button lblAgregarDT;
        private Button lblAgregarArbitro;
        private GroupBox groupBoxArbitros;
        private Label label1;
        private Label lblDNIArbitro;
        private Label lblNombreApellidoArbitro;
        private ListBox listBoxArbitros;
        private GroupBox groupBoxDTs;
        private Label lblNroCarnetDT;
        private Label lblDNIDT;
        private Label lblNombreYApellidoDT;
        private ListBox listBoxDTs;
        private Button btnGuardarTodo;
    }
}
