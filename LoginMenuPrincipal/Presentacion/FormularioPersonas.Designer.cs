namespace Presentacion
{
    partial class FormularioPersonas
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
            dataGridViewPersona = new DataGridView();
            txtNombres = new TextBox();
            label1 = new Label();
            btnGuardar = new Button();
            label2 = new Label();
            txtPaterno = new TextBox();
            label3 = new Label();
            txtMaterno = new TextBox();
            label4 = new Label();
            txtNacimiento = new TextBox();
            label5 = new Label();
            txtCelular = new TextBox();
            label6 = new Label();
            txtDireccion = new TextBox();
            label7 = new Label();
            txtDocumento = new TextBox();
            label8 = new Label();
            txtCorreo = new TextBox();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersona).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPersona
            // 
            dataGridViewPersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPersona.Location = new Point(28, 204);
            dataGridViewPersona.Name = "dataGridViewPersona";
            dataGridViewPersona.RowTemplate.Height = 25;
            dataGridViewPersona.Size = new Size(893, 424);
            dataGridViewPersona.TabIndex = 0;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(28, 60);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(176, 23);
            txtNombres.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 32);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "NOMBRES";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(754, 166);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(167, 23);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 32);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 5;
            label2.Text = "APELLIDO PATERNO";
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(266, 60);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(173, 23);
            txtPaterno.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(511, 32);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 7;
            label3.Text = "APELLIDO MATERNO";
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(511, 60);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(172, 23);
            txtMaterno.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(754, 32);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 9;
            label4.Text = "FECHA NACIMIENTO";
            // 
            // txtNacimiento
            // 
            txtNacimiento.Location = new Point(754, 60);
            txtNacimiento.Name = "txtNacimiento";
            txtNacimiento.Size = new Size(167, 23);
            txtNacimiento.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(754, 95);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 17;
            label5.Text = "CELULAR";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(754, 123);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(167, 23);
            txtCelular.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(511, 95);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 15;
            label6.Text = "DIRECCION";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(511, 123);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(172, 23);
            txtDireccion.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(266, 95);
            label7.Name = "label7";
            label7.Size = new Size(133, 15);
            label7.TabIndex = 13;
            label7.Text = "NUMERO DOCUMENTO";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(266, 123);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(173, 23);
            txtDocumento.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 95);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 11;
            label8.Text = "CORREO";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(28, 123);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(176, 23);
            txtCorreo.TabIndex = 10;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(563, 656);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(167, 23);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(754, 656);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(167, 23);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormularioPersonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 711);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(label5);
            Controls.Add(txtCelular);
            Controls.Add(label6);
            Controls.Add(txtDireccion);
            Controls.Add(label7);
            Controls.Add(txtDocumento);
            Controls.Add(label8);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(txtNacimiento);
            Controls.Add(label3);
            Controls.Add(txtMaterno);
            Controls.Add(label2);
            Controls.Add(txtPaterno);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Controls.Add(txtNombres);
            Controls.Add(dataGridViewPersona);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormularioPersonas";
            Text = "FormularioPersonas";
            Load += FormularioPersonas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersona).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPersona;
        private TextBox txtNombres;
        private Label label1;
        private Button btnGuardar;
        private Label label2;
        private TextBox txtPaterno;
        private Label label3;
        private TextBox txtMaterno;
        private Label label4;
        private TextBox txtNacimiento;
        private Label label5;
        private TextBox txtCelular;
        private Label label6;
        private TextBox txtDireccion;
        private Label label7;
        private TextBox txtDocumento;
        private Label label8;
        private TextBox txtCorreo;
        private Button btnEditar;
        private Button btnEliminar;
    }
}