namespace Interfaz
{
    partial class AgregarArbitro
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
            btnEliminarArbitro = new Button();
            btnAgregarArbitro = new Button();
            groupBox1 = new GroupBox();
            txtNroCarnetArbitro = new TextBox();
            txtDNIArbitro = new TextBox();
            txtApellidoArbitro = new TextBox();
            txtNombreArbitro = new TextBox();
            lblNroCarnetArbitro = new Label();
            lblDNIArbitro = new Label();
            lblApellidoArbitro = new Label();
            lblNombreArbitro = new Label();
            lstListaArbitros = new ListBox();
            lblListadoArbitros = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEliminarArbitro
            // 
            btnEliminarArbitro.Location = new Point(183, 56);
            btnEliminarArbitro.Name = "btnEliminarArbitro";
            btnEliminarArbitro.Size = new Size(75, 23);
            btnEliminarArbitro.TabIndex = 9;
            btnEliminarArbitro.Text = "Eliminar";
            btnEliminarArbitro.UseVisualStyleBackColor = true;
            // 
            // btnAgregarArbitro
            // 
            btnAgregarArbitro.Location = new Point(183, 27);
            btnAgregarArbitro.Name = "btnAgregarArbitro";
            btnAgregarArbitro.Size = new Size(75, 23);
            btnAgregarArbitro.TabIndex = 8;
            btnAgregarArbitro.Text = "Agregar";
            btnAgregarArbitro.UseVisualStyleBackColor = true;
            btnAgregarArbitro.Click += btnAgregarArbitro_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNroCarnetArbitro);
            groupBox1.Controls.Add(txtDNIArbitro);
            groupBox1.Controls.Add(txtApellidoArbitro);
            groupBox1.Controls.Add(txtNombreArbitro);
            groupBox1.Controls.Add(lblNroCarnetArbitro);
            groupBox1.Controls.Add(lblDNIArbitro);
            groupBox1.Controls.Add(lblApellidoArbitro);
            groupBox1.Controls.Add(lblNombreArbitro);
            groupBox1.Location = new Point(264, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 138);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Árbitro";
            // 
            // txtNroCarnetArbitro
            // 
            txtNroCarnetArbitro.Location = new Point(74, 103);
            txtNroCarnetArbitro.Name = "txtNroCarnetArbitro";
            txtNroCarnetArbitro.Size = new Size(120, 23);
            txtNroCarnetArbitro.TabIndex = 7;
            // 
            // txtDNIArbitro
            // 
            txtDNIArbitro.Location = new Point(74, 74);
            txtDNIArbitro.Name = "txtDNIArbitro";
            txtDNIArbitro.Size = new Size(120, 23);
            txtDNIArbitro.TabIndex = 6;
            // 
            // txtApellidoArbitro
            // 
            txtApellidoArbitro.Location = new Point(74, 45);
            txtApellidoArbitro.Name = "txtApellidoArbitro";
            txtApellidoArbitro.Size = new Size(120, 23);
            txtApellidoArbitro.TabIndex = 5;
            // 
            // txtNombreArbitro
            // 
            txtNombreArbitro.Location = new Point(74, 17);
            txtNombreArbitro.Name = "txtNombreArbitro";
            txtNombreArbitro.Size = new Size(120, 23);
            txtNombreArbitro.TabIndex = 4;
            // 
            // lblNroCarnetArbitro
            // 
            lblNroCarnetArbitro.AutoSize = true;
            lblNroCarnetArbitro.Location = new Point(6, 106);
            lblNroCarnetArbitro.Name = "lblNroCarnetArbitro";
            lblNroCarnetArbitro.Size = new Size(62, 15);
            lblNroCarnetArbitro.TabIndex = 3;
            lblNroCarnetArbitro.Text = "N° Carnet:";
            // 
            // lblDNIArbitro
            // 
            lblDNIArbitro.AutoSize = true;
            lblDNIArbitro.Location = new Point(38, 77);
            lblDNIArbitro.Name = "lblDNIArbitro";
            lblDNIArbitro.Size = new Size(30, 15);
            lblDNIArbitro.TabIndex = 2;
            lblDNIArbitro.Text = "DNI:";
            // 
            // lblApellidoArbitro
            // 
            lblApellidoArbitro.AutoSize = true;
            lblApellidoArbitro.Location = new Point(14, 48);
            lblApellidoArbitro.Name = "lblApellidoArbitro";
            lblApellidoArbitro.Size = new Size(54, 15);
            lblApellidoArbitro.TabIndex = 1;
            lblApellidoArbitro.Text = "Apellido:";
            // 
            // lblNombreArbitro
            // 
            lblNombreArbitro.AutoSize = true;
            lblNombreArbitro.Location = new Point(14, 20);
            lblNombreArbitro.Name = "lblNombreArbitro";
            lblNombreArbitro.Size = new Size(54, 15);
            lblNombreArbitro.TabIndex = 0;
            lblNombreArbitro.Text = "Nombre:";
            // 
            // lstListaArbitros
            // 
            lstListaArbitros.FormattingEnabled = true;
            lstListaArbitros.ItemHeight = 15;
            lstListaArbitros.Location = new Point(12, 27);
            lstListaArbitros.Name = "lstListaArbitros";
            lstListaArbitros.Size = new Size(165, 274);
            lstListaArbitros.TabIndex = 6;
            // 
            // lblListadoArbitros
            // 
            lblListadoArbitros.AutoSize = true;
            lblListadoArbitros.Location = new Point(12, 9);
            lblListadoArbitros.Name = "lblListadoArbitros";
            lblListadoArbitros.Size = new Size(106, 15);
            lblListadoArbitros.TabIndex = 5;
            lblListadoArbitros.Text = "Listado de Árbitros";
            // 
            // AgregarArbitro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 311);
            Controls.Add(btnEliminarArbitro);
            Controls.Add(btnAgregarArbitro);
            Controls.Add(groupBox1);
            Controls.Add(lstListaArbitros);
            Controls.Add(lblListadoArbitros);
            Name = "AgregarArbitro";
            Text = "Agregar Árbitro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminarArbitro;
        private Button btnAgregarArbitro;
        private GroupBox groupBox1;
        private TextBox txtNroCarnetArbitro;
        private TextBox txtDNIArbitro;
        private TextBox txtApellidoArbitro;
        private TextBox txtNombreArbitro;
        private Label lblNroCarnetArbitro;
        private Label lblDNIArbitro;
        private Label lblApellidoArbitro;
        private Label lblNombreArbitro;
        private ListBox lstListaArbitros;
        private Label lblListadoArbitros;
    }
}