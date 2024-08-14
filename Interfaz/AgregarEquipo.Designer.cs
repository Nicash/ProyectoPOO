namespace Interfaz
{
    partial class AgregarEquipo
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
            lblNombreEquipo = new Label();
            lblSiglas = new Label();
            lblDT = new Label();
            txtNombreEquipo = new TextBox();
            txtSiglasEquipo = new TextBox();
            comboBoxDTEquipo = new ComboBox();
            btnAgregarDT = new Button();
            label1 = new Label();
            txtColor1Equipo = new TextBox();
            txtColor2Equipo = new TextBox();
            lblColor2 = new Label();
            label2 = new Label();
            listBoxJugadoresEquipo = new ListBox();
            btnAgregarJugador = new Button();
            btnEliminarJugador = new Button();
            groupBoxDatosJugador = new GroupBox();
            label3 = new Label();
            txtNroGoles = new TextBox();
            lblDorsal = new Label();
            txtDorsal = new TextBox();
            lblDNIJugador = new Label();
            txtDNIJugador = new TextBox();
            lblApellidoJugador = new Label();
            txtApellidoJugador = new TextBox();
            txtNombreJugador = new TextBox();
            lblNombreJugador = new Label();
            btnGuardarEquipo = new Button();
            groupBoxDatosJugador.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombreEquipo
            // 
            lblNombreEquipo.AutoSize = true;
            lblNombreEquipo.Location = new Point(78, 13);
            lblNombreEquipo.Name = "lblNombreEquipo";
            lblNombreEquipo.Size = new Size(54, 15);
            lblNombreEquipo.TabIndex = 0;
            lblNombreEquipo.Text = "Nombre:";
            // 
            // lblSiglas
            // 
            lblSiglas.AutoSize = true;
            lblSiglas.Location = new Point(92, 41);
            lblSiglas.Name = "lblSiglas";
            lblSiglas.Size = new Size(40, 15);
            lblSiglas.TabIndex = 1;
            lblSiglas.Text = "Siglas:";
            // 
            // lblDT
            // 
            lblDT.AutoSize = true;
            lblDT.Location = new Point(37, 71);
            lblDT.Name = "lblDT";
            lblDT.Size = new Size(95, 15);
            lblDT.TabIndex = 2;
            lblDT.Text = "Director Técnico:";
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(138, 10);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(150, 23);
            txtNombreEquipo.TabIndex = 3;
            // 
            // txtSiglasEquipo
            // 
            txtSiglasEquipo.Location = new Point(138, 38);
            txtSiglasEquipo.Name = "txtSiglasEquipo";
            txtSiglasEquipo.Size = new Size(149, 23);
            txtSiglasEquipo.TabIndex = 4;
            // 
            // comboBoxDTEquipo
            // 
            comboBoxDTEquipo.FormattingEnabled = true;
            comboBoxDTEquipo.Location = new Point(138, 68);
            comboBoxDTEquipo.Name = "comboBoxDTEquipo";
            comboBoxDTEquipo.Size = new Size(149, 23);
            comboBoxDTEquipo.TabIndex = 5;
            // 
            // btnAgregarDT
            // 
            btnAgregarDT.Location = new Point(293, 67);
            btnAgregarDT.Name = "btnAgregarDT";
            btnAgregarDT.Size = new Size(75, 23);
            btnAgregarDT.TabIndex = 6;
            btnAgregarDT.Text = "Agregar DT";
            btnAgregarDT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 99);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 7;
            label1.Text = "Color 1:";
            // 
            // txtColor1Equipo
            // 
            txtColor1Equipo.Location = new Point(138, 96);
            txtColor1Equipo.Name = "txtColor1Equipo";
            txtColor1Equipo.Size = new Size(149, 23);
            txtColor1Equipo.TabIndex = 8;
            // 
            // txtColor2Equipo
            // 
            txtColor2Equipo.Location = new Point(138, 125);
            txtColor2Equipo.Name = "txtColor2Equipo";
            txtColor2Equipo.Size = new Size(149, 23);
            txtColor2Equipo.TabIndex = 9;
            // 
            // lblColor2
            // 
            lblColor2.AutoSize = true;
            lblColor2.Location = new Point(84, 128);
            lblColor2.Name = "lblColor2";
            lblColor2.Size = new Size(48, 15);
            lblColor2.TabIndex = 10;
            lblColor2.Text = "Color 2:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 154);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 11;
            label2.Text = "Listado de Jugadores:";
            // 
            // listBoxJugadoresEquipo
            // 
            listBoxJugadoresEquipo.FormattingEnabled = true;
            listBoxJugadoresEquipo.ItemHeight = 15;
            listBoxJugadoresEquipo.Location = new Point(138, 154);
            listBoxJugadoresEquipo.Name = "listBoxJugadoresEquipo";
            listBoxJugadoresEquipo.Size = new Size(149, 274);
            listBoxJugadoresEquipo.TabIndex = 12;
            // 
            // btnAgregarJugador
            // 
            btnAgregarJugador.Location = new Point(293, 154);
            btnAgregarJugador.Name = "btnAgregarJugador";
            btnAgregarJugador.Size = new Size(75, 23);
            btnAgregarJugador.TabIndex = 13;
            btnAgregarJugador.Text = "Agregar Jugador";
            btnAgregarJugador.UseVisualStyleBackColor = true;
            btnAgregarJugador.Click += btnAgregarJugador_Click;
            // 
            // btnEliminarJugador
            // 
            btnEliminarJugador.Location = new Point(293, 183);
            btnEliminarJugador.Name = "btnEliminarJugador";
            btnEliminarJugador.Size = new Size(75, 23);
            btnEliminarJugador.TabIndex = 14;
            btnEliminarJugador.Text = "Eliminar";
            btnEliminarJugador.UseVisualStyleBackColor = true;
            btnEliminarJugador.Click += btnEliminarJugador_Click;
            // 
            // groupBoxDatosJugador
            // 
            groupBoxDatosJugador.Controls.Add(label3);
            groupBoxDatosJugador.Controls.Add(txtNroGoles);
            groupBoxDatosJugador.Controls.Add(lblDorsal);
            groupBoxDatosJugador.Controls.Add(txtDorsal);
            groupBoxDatosJugador.Controls.Add(lblDNIJugador);
            groupBoxDatosJugador.Controls.Add(txtDNIJugador);
            groupBoxDatosJugador.Controls.Add(lblApellidoJugador);
            groupBoxDatosJugador.Controls.Add(txtApellidoJugador);
            groupBoxDatosJugador.Controls.Add(txtNombreJugador);
            groupBoxDatosJugador.Controls.Add(lblNombreJugador);
            groupBoxDatosJugador.Location = new Point(374, 154);
            groupBoxDatosJugador.Name = "groupBoxDatosJugador";
            groupBoxDatosJugador.Size = new Size(221, 171);
            groupBoxDatosJugador.TabIndex = 15;
            groupBoxDatosJugador.TabStop = false;
            groupBoxDatosJugador.Text = "Datos del Jugador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 138);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 9;
            label3.Text = "Cantidad de Goles:";
            // 
            // txtNroGoles
            // 
            txtNroGoles.Location = new Point(118, 135);
            txtNroGoles.Name = "txtNroGoles";
            txtNroGoles.Size = new Size(97, 23);
            txtNroGoles.TabIndex = 8;
            // 
            // lblDorsal
            // 
            lblDorsal.AutoSize = true;
            lblDorsal.Location = new Point(17, 109);
            lblDorsal.Name = "lblDorsal";
            lblDorsal.Size = new Size(43, 15);
            lblDorsal.TabIndex = 7;
            lblDorsal.Text = "Dorsal:";
            // 
            // txtDorsal
            // 
            txtDorsal.Location = new Point(66, 106);
            txtDorsal.Name = "txtDorsal";
            txtDorsal.Size = new Size(149, 23);
            txtDorsal.TabIndex = 6;
            // 
            // lblDNIJugador
            // 
            lblDNIJugador.AutoSize = true;
            lblDNIJugador.Location = new Point(30, 80);
            lblDNIJugador.Name = "lblDNIJugador";
            lblDNIJugador.Size = new Size(30, 15);
            lblDNIJugador.TabIndex = 5;
            lblDNIJugador.Text = "DNI:";
            // 
            // txtDNIJugador
            // 
            txtDNIJugador.Location = new Point(66, 77);
            txtDNIJugador.Name = "txtDNIJugador";
            txtDNIJugador.Size = new Size(149, 23);
            txtDNIJugador.TabIndex = 4;
            // 
            // lblApellidoJugador
            // 
            lblApellidoJugador.AutoSize = true;
            lblApellidoJugador.Location = new Point(6, 51);
            lblApellidoJugador.Name = "lblApellidoJugador";
            lblApellidoJugador.Size = new Size(54, 15);
            lblApellidoJugador.TabIndex = 3;
            lblApellidoJugador.Text = "Apellido:";
            // 
            // txtApellidoJugador
            // 
            txtApellidoJugador.Location = new Point(66, 48);
            txtApellidoJugador.Name = "txtApellidoJugador";
            txtApellidoJugador.Size = new Size(149, 23);
            txtApellidoJugador.TabIndex = 2;
            // 
            // txtNombreJugador
            // 
            txtNombreJugador.Location = new Point(66, 19);
            txtNombreJugador.Name = "txtNombreJugador";
            txtNombreJugador.Size = new Size(149, 23);
            txtNombreJugador.TabIndex = 1;
            // 
            // lblNombreJugador
            // 
            lblNombreJugador.AutoSize = true;
            lblNombreJugador.Location = new Point(6, 22);
            lblNombreJugador.Name = "lblNombreJugador";
            lblNombreJugador.Size = new Size(54, 15);
            lblNombreJugador.TabIndex = 0;
            lblNombreJugador.Text = "Nombre:";
            // 
            // btnGuardarEquipo
            // 
            btnGuardarEquipo.Location = new Point(492, 405);
            btnGuardarEquipo.Name = "btnGuardarEquipo";
            btnGuardarEquipo.Size = new Size(103, 23);
            btnGuardarEquipo.TabIndex = 16;
            btnGuardarEquipo.Text = "Guardar Equipo";
            btnGuardarEquipo.UseVisualStyleBackColor = true;
            btnGuardarEquipo.Click += btnGuardarEquipo_Click;
            // 
            // AgregarEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 441);
            Controls.Add(btnGuardarEquipo);
            Controls.Add(groupBoxDatosJugador);
            Controls.Add(btnEliminarJugador);
            Controls.Add(btnAgregarJugador);
            Controls.Add(listBoxJugadoresEquipo);
            Controls.Add(label2);
            Controls.Add(lblColor2);
            Controls.Add(txtColor2Equipo);
            Controls.Add(txtColor1Equipo);
            Controls.Add(label1);
            Controls.Add(btnAgregarDT);
            Controls.Add(comboBoxDTEquipo);
            Controls.Add(txtSiglasEquipo);
            Controls.Add(txtNombreEquipo);
            Controls.Add(lblDT);
            Controls.Add(lblSiglas);
            Controls.Add(lblNombreEquipo);
            Name = "AgregarEquipo";
            Text = "Agregar Equipo";
            Load += AgregarEquipo_Load;
            groupBoxDatosJugador.ResumeLayout(false);
            groupBoxDatosJugador.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreEquipo;
        private Label lblSiglas;
        private Label lblDT;
        private TextBox txtNombreEquipo;
        private TextBox txtSiglasEquipo;
        private ComboBox comboBoxDTEquipo;
        private Button btnAgregarDT;
        private Label label1;
        private TextBox txtColor1Equipo;
        private TextBox txtColor2Equipo;
        private Label lblColor2;
        private Label label2;
        private ListBox listBoxJugadoresEquipo;
        private Button btnAgregarJugador;
        private Button btnEliminarJugador;
        private GroupBox groupBoxDatosJugador;
        private Label lblApellidoJugador;
        private TextBox txtApellidoJugador;
        private TextBox txtNombreJugador;
        private Label lblNombreJugador;
        private Label lblDNIJugador;
        private TextBox txtDNIJugador;
        private Label label3;
        private TextBox txtNroGoles;
        private Label lblDorsal;
        private TextBox txtDorsal;
        private Button btnGuardarEquipo;
    }
}