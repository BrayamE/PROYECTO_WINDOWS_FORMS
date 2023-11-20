namespace prueba
{
    partial class Form1
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
            txtTexto = new Label();
            btnBoton = new Button();
            btnSaludo = new Button();
            SuspendLayout();
            // 
            // txtTexto
            // 
            txtTexto.AutoSize = true;
            txtTexto.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtTexto.Location = new Point(276, 155);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(223, 39);
            txtTexto.TabIndex = 0;
            txtTexto.Text = "Hola MUNDO";
            txtTexto.Click += label1_Click;
            // 
            // btnBoton
            // 
            btnBoton.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnBoton.Location = new Point(304, 218);
            btnBoton.Name = "btnBoton";
            btnBoton.Size = new Size(158, 51);
            btnBoton.TabIndex = 1;
            btnBoton.Text = "Boton";
            btnBoton.UseVisualStyleBackColor = true;
            btnBoton.Click += btnBoton_Click;
            // 
            // btnSaludo
            // 
            btnSaludo.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaludo.Location = new Point(304, 301);
            btnSaludo.Name = "btnSaludo";
            btnSaludo.Size = new Size(158, 51);
            btnSaludo.TabIndex = 2;
            btnSaludo.Text = "Saludo";
            btnSaludo.UseVisualStyleBackColor = true;
            btnSaludo.Click += btnSaludo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaludo);
            Controls.Add(btnBoton);
            Controls.Add(txtTexto);
            Name = "Form1";
            Text = "Forms1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtTexto;
        private Button btnBoton;
        private Button btnSaludo;
    }
}