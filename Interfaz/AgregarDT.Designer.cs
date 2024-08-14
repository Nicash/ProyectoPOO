namespace Interfaz
{
    partial class AgregarDT
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
            lblListadoDTs = new Label();
            listBoxDTs = new ListBox();
            groupBox1 = new GroupBox();
            txtNroCarnet = new TextBox();
            txtDNIDT = new TextBox();
            txtApellidoDT = new TextBox();
            txtNombreDT = new TextBox();
            lblNroCarnet = new Label();
            lblDNIDT = new Label();
            lblApellidoDT = new Label();
            lblNombreDT = new Label();
            btnAgregarDT = new Button();
            btnEliminarDT = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblListadoDTs
            // 
            lblListadoDTs.AutoSize = true;
            lblListadoDTs.Location = new Point(12, 9);
            lblListadoDTs.Name = "lblListadoDTs";
            lblListadoDTs.Size = new Size(165, 15);
            lblListadoDTs.TabIndex = 0;
            lblListadoDTs.Text = "Listado de Directores Técnicos";
            // 
            // listBoxDTs
            // 
            listBoxDTs.FormattingEnabled = true;
            listBoxDTs.ItemHeight = 15;
            listBoxDTs.Location = new Point(12, 27);
            listBoxDTs.Name = "listBoxDTs";
            listBoxDTs.Size = new Size(165, 274);
            listBoxDTs.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNroCarnet);
            groupBox1.Controls.Add(txtDNIDT);
            groupBox1.Controls.Add(txtApellidoDT);
            groupBox1.Controls.Add(txtNombreDT);
            groupBox1.Controls.Add(lblNroCarnet);
            groupBox1.Controls.Add(lblDNIDT);
            groupBox1.Controls.Add(lblApellidoDT);
            groupBox1.Controls.Add(lblNombreDT);
            groupBox1.Location = new Point(264, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 138);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del DT";
            // 
            // txtNroCarnet
            // 
            txtNroCarnet.Location = new Point(74, 103);
            txtNroCarnet.Name = "txtNroCarnet";
            txtNroCarnet.Size = new Size(120, 23);
            txtNroCarnet.TabIndex = 7;
            // 
            // txtDNIDT
            // 
            txtDNIDT.Location = new Point(74, 74);
            txtDNIDT.Name = "txtDNIDT";
            txtDNIDT.Size = new Size(120, 23);
            txtDNIDT.TabIndex = 6;
            // 
            // txtApellidoDT
            // 
            txtApellidoDT.Location = new Point(74, 45);
            txtApellidoDT.Name = "txtApellidoDT";
            txtApellidoDT.Size = new Size(120, 23);
            txtApellidoDT.TabIndex = 5;
            txtApellidoDT.TextChanged += txtApellidoDT_TextChanged;
            // 
            // txtNombreDT
            // 
            txtNombreDT.Location = new Point(74, 17);
            txtNombreDT.Name = "txtNombreDT";
            txtNombreDT.Size = new Size(120, 23);
            txtNombreDT.TabIndex = 4;
            // 
            // lblNroCarnet
            // 
            lblNroCarnet.AutoSize = true;
            lblNroCarnet.Location = new Point(6, 106);
            lblNroCarnet.Name = "lblNroCarnet";
            lblNroCarnet.Size = new Size(62, 15);
            lblNroCarnet.TabIndex = 3;
            lblNroCarnet.Text = "N° Carnet:";
            // 
            // lblDNIDT
            // 
            lblDNIDT.AutoSize = true;
            lblDNIDT.Location = new Point(38, 77);
            lblDNIDT.Name = "lblDNIDT";
            lblDNIDT.Size = new Size(30, 15);
            lblDNIDT.TabIndex = 2;
            lblDNIDT.Text = "DNI:";
            // 
            // lblApellidoDT
            // 
            lblApellidoDT.AutoSize = true;
            lblApellidoDT.Location = new Point(14, 48);
            lblApellidoDT.Name = "lblApellidoDT";
            lblApellidoDT.Size = new Size(54, 15);
            lblApellidoDT.TabIndex = 1;
            lblApellidoDT.Text = "Apellido:";
            // 
            // lblNombreDT
            // 
            lblNombreDT.AutoSize = true;
            lblNombreDT.Location = new Point(14, 20);
            lblNombreDT.Name = "lblNombreDT";
            lblNombreDT.Size = new Size(54, 15);
            lblNombreDT.TabIndex = 0;
            lblNombreDT.Text = "Nombre:";
            // 
            // btnAgregarDT
            // 
            btnAgregarDT.Location = new Point(183, 27);
            btnAgregarDT.Name = "btnAgregarDT";
            btnAgregarDT.Size = new Size(75, 23);
            btnAgregarDT.TabIndex = 3;
            btnAgregarDT.Text = "Agregar";
            btnAgregarDT.UseVisualStyleBackColor = true;
            btnAgregarDT.Click += btnAgregarDT_Click;
            // 
            // btnEliminarDT
            // 
            btnEliminarDT.Location = new Point(183, 56);
            btnEliminarDT.Name = "btnEliminarDT";
            btnEliminarDT.Size = new Size(75, 23);
            btnEliminarDT.TabIndex = 4;
            btnEliminarDT.Text = "Eliminar";
            btnEliminarDT.UseVisualStyleBackColor = true;
            btnEliminarDT.Click += btnEliminarDT_Click;
            // 
            // AgregarDT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 312);
            Controls.Add(btnEliminarDT);
            Controls.Add(btnAgregarDT);
            Controls.Add(groupBox1);
            Controls.Add(listBoxDTs);
            Controls.Add(lblListadoDTs);
            Name = "AgregarDT";
            Text = "Agregar DT";
            Load += AgregarDT_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListadoDTs;
        private ListBox listBoxDTs;
        private GroupBox groupBox1;
        private Label lblApellidoDT;
        private Label lblNombreDT;
        private Button btnAgregarDT;
        private Button btnEliminarDT;
        private Label lblNroCarnet;
        private Label lblDNIDT;
        private TextBox txtApellidoDT;
        private TextBox txtNombreDT;
        private TextBox txtNroCarnet;
        private TextBox txtDNIDT;
    }
}