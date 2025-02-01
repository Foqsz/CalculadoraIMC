namespace CalculadoraIMC
{
    partial class CalculadoraDeIMC
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
            idadeLb1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            txtIdade = new TextBox();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            txtResultado = new Label();
            SuspendLayout();
            // 
            // idadeLb1
            // 
            idadeLb1.AutoSize = true;
            idadeLb1.Location = new Point(67, 30);
            idadeLb1.Name = "idadeLb1";
            idadeLb1.Size = new Size(36, 15);
            idadeLb1.TabIndex = 0;
            idadeLb1.Text = "Idade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 69);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 0;
            label2.Text = "Altura (ex.: 1.75)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 105);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 0;
            label3.Text = "Peso (ex.: 61.23)";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(67, 157);
            button1.Name = "button1";
            button1.Size = new Size(135, 23);
            button1.TabIndex = 1;
            button1.Text = "Calcular IMC";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtIdade
            // 
            txtIdade.BackColor = SystemColors.InactiveCaption;
            txtIdade.Location = new Point(152, 27);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(74, 23);
            txtIdade.TabIndex = 2;
            // 
            // txtAltura
            // 
            txtAltura.BackColor = SystemColors.InactiveCaption;
            txtAltura.Location = new Point(152, 66);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(74, 23);
            txtAltura.TabIndex = 2;
            // 
            // txtPeso
            // 
            txtPeso.BackColor = SystemColors.InactiveCaption;
            txtPeso.Location = new Point(152, 105);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(74, 23);
            txtPeso.TabIndex = 2;
            // 
            // txtResultado
            // 
            txtResultado.AutoSize = true;
            txtResultado.BackColor = SystemColors.ActiveCaption;
            txtResultado.Location = new Point(72, 206);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(59, 15);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "Resultado";
            // 
            // CalculadoraDeIMC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 256);
            Controls.Add(txtPeso);
            Controls.Add(txtAltura);
            Controls.Add(txtIdade);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(label2);
            Controls.Add(idadeLb1);
            Name = "CalculadoraDeIMC";
            Text = "Calculadora de IMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idadeLb1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox txtIdade;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private Label txtResultado;
    }
}
