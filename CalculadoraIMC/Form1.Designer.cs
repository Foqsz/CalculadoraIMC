namespace CalculadoraIMC
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
            idadeLb1 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            txtIdade = new TextBox();
            textBox2 = new TextBox();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            txtResultado = new Label();
            SuspendLayout();
            // 
            // idadeLb1
            // 
            idadeLb1.AutoSize = true;
            idadeLb1.Location = new Point(12, 30);
            idadeLb1.Name = "idadeLb1";
            idadeLb1.Size = new Size(36, 15);
            idadeLb1.TabIndex = 0;
            idadeLb1.Text = "Idade";
            idadeLb1.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 0;
            label1.Text = "Você é Homem ou Mulher?";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 0;
            label2.Text = "Altura (ex.: 1.75)";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 130);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 0;
            label3.Text = "Peso (ex.: 61.23)";
            label3.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(28, 168);
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
            txtIdade.Location = new Point(54, 27);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(74, 23);
            txtIdade.TabIndex = 2;
            txtIdade.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Location = new Point(169, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(74, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // txtAltura
            // 
            txtAltura.BackColor = SystemColors.InactiveCaption;
            txtAltura.Location = new Point(110, 95);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(74, 23);
            txtAltura.TabIndex = 2;
            // 
            // txtPeso
            // 
            txtPeso.BackColor = SystemColors.InactiveCaption;
            txtPeso.Location = new Point(109, 127);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(74, 23);
            txtPeso.TabIndex = 2;
            txtPeso.TextChanged += textBox4_TextChanged;
            // 
            // txtResultado
            // 
            txtResultado.AutoSize = true;
            txtResultado.BackColor = SystemColors.ActiveCaption;
            txtResultado.Location = new Point(28, 218);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(59, 15);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "Resultado";
            txtResultado.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 256);
            Controls.Add(txtPeso);
            Controls.Add(txtAltura);
            Controls.Add(textBox2);
            Controls.Add(txtIdade);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(idadeLb1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idadeLb1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox txtIdade;
        private TextBox textBox2;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private Label txtResultado;
    }
}
