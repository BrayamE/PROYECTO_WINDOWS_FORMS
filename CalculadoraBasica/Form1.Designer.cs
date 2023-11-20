namespace CalculadoraBasica
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
            btnResultado = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btnLimpiar = new Button();
            btn9 = new Button();
            btnSuma = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnResta = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMultiplicacion = new Button();
            btn0 = new Button();
            btnIgual = new Button();
            btnDivision = new Button();
            SuspendLayout();
            // 
            // btnResultado
            // 
            btnResultado.BackColor = SystemColors.ActiveCaption;
            btnResultado.Cursor = Cursors.IBeam;
            btnResultado.Font = new Font("Century Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point);
            btnResultado.Location = new Point(8, 33);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(390, 86);
            btnResultado.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ControlLight;
            btn7.Cursor = Cursors.Hand;
            btn7.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.ForeColor = SystemColors.InactiveCaptionText;
            btn7.Location = new Point(12, 144);
            btn7.Name = "btn7";
            btn7.Size = new Size(81, 67);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Cursor = Cursors.Hand;
            btn8.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.Location = new Point(113, 144);
            btn8.Name = "btn8";
            btn8.Size = new Size(83, 67);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn4
            // 
            btn4.Cursor = Cursors.Hand;
            btn4.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(12, 232);
            btn4.Name = "btn4";
            btn4.Size = new Size(81, 67);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.Cursor = Cursors.Hand;
            btn1.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(12, 322);
            btn1.Name = "btn1";
            btn1.Size = new Size(81, 67);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.ForeColor = SystemColors.Highlight;
            btnLimpiar.Location = new Point(12, 412);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(81, 67);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "C";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btn9
            // 
            btn9.Cursor = Cursors.Hand;
            btn9.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.Location = new Point(217, 144);
            btn9.Name = "btn9";
            btn9.Size = new Size(83, 67);
            btn9.TabIndex = 17;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnSuma
            // 
            btnSuma.Cursor = Cursors.Hand;
            btnSuma.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuma.ForeColor = SystemColors.ControlDark;
            btnSuma.Location = new Point(318, 144);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(81, 67);
            btnSuma.TabIndex = 18;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btn5
            // 
            btn5.Cursor = Cursors.Hand;
            btn5.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(115, 232);
            btn5.Name = "btn5";
            btn5.Size = new Size(81, 67);
            btn5.TabIndex = 19;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Cursor = Cursors.Hand;
            btn6.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.Location = new Point(219, 232);
            btn6.Name = "btn6";
            btn6.Size = new Size(81, 67);
            btn6.TabIndex = 20;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnResta
            // 
            btnResta.Cursor = Cursors.Hand;
            btnResta.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnResta.ForeColor = SystemColors.ControlDark;
            btnResta.Location = new Point(318, 232);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(81, 67);
            btnResta.TabIndex = 21;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btn2
            // 
            btn2.Cursor = Cursors.Hand;
            btn2.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(115, 322);
            btn2.Name = "btn2";
            btn2.Size = new Size(81, 67);
            btn2.TabIndex = 22;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Cursor = Cursors.Hand;
            btn3.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(219, 322);
            btn3.Name = "btn3";
            btn3.Size = new Size(81, 67);
            btn3.TabIndex = 23;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.Cursor = Cursors.Hand;
            btnMultiplicacion.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultiplicacion.ForeColor = SystemColors.ControlDark;
            btnMultiplicacion.Location = new Point(318, 322);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(81, 67);
            btnMultiplicacion.TabIndex = 24;
            btnMultiplicacion.Text = "X";
            btnMultiplicacion.UseVisualStyleBackColor = true;
            btnMultiplicacion.Click += btnMultiplicacion_Click;
            // 
            // btn0
            // 
            btn0.Cursor = Cursors.Hand;
            btn0.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.Location = new Point(113, 412);
            btn0.Name = "btn0";
            btn0.Size = new Size(81, 67);
            btn0.TabIndex = 25;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnIgual
            // 
            btnIgual.Cursor = Cursors.Hand;
            btnIgual.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnIgual.ForeColor = SystemColors.ActiveCaption;
            btnIgual.Location = new Point(219, 412);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(81, 67);
            btnIgual.TabIndex = 26;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnDivision
            // 
            btnDivision.Cursor = Cursors.Hand;
            btnDivision.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivision.ForeColor = SystemColors.ControlDark;
            btnDivision.Location = new Point(318, 412);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(81, 67);
            btnDivision.TabIndex = 27;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(411, 506);
            Controls.Add(btnDivision);
            Controls.Add(btnIgual);
            Controls.Add(btn0);
            Controls.Add(btnMultiplicacion);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btnResta);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btnSuma);
            Controls.Add(btn9);
            Controls.Add(btnLimpiar);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnResultado);
            ForeColor = SystemColors.InactiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox btnResultado;
        private Button btn7;
        private Button btn8;
        private Button btn4;
        private Button btn1;
        private Button btnLimpiar;
        private Button btn9;
        private Button btnSuma;
        private Button btn5;
        private Button btn6;
        private Button btnResta;
        private Button btn2;
        private Button btn3;
        private Button btnMultiplicacion;
        private Button btn0;
        private Button btnIgual;
        private Button btnDivision;
    }
}