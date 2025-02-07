namespace GestionRiobambaZapateria
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
            label1 = new Label();
            comboBoxDias = new ComboBox();
            mtbAdidas = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            mtbNike = new MaskedTextBox();
            label4 = new Label();
            mtbPuma = new MaskedTextBox();
            label5 = new Label();
            mtbPrecioPuma = new MaskedTextBox();
            label6 = new Label();
            mtbPrecioAdidas = new MaskedTextBox();
            label7 = new Label();
            mtbPrecioNike = new MaskedTextBox();
            btnGuardar = new Button();
            btnSiguiente = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightBlue;
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(457, 21);
            label1.Name = "label1";
            label1.Size = new Size(521, 23);
            label1.TabIndex = 0;
            label1.Text = "RIOBAMBA ZAPATOS AL POR MAYOR Y MENOR";
            // 
            // comboBoxDias
            // 
            comboBoxDias.BackColor = Color.Snow;
            comboBoxDias.Font = new Font("Montserrat Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBoxDias.FormattingEnabled = true;
            comboBoxDias.Location = new Point(197, 109);
            comboBoxDias.Name = "comboBoxDias";
            comboBoxDias.Size = new Size(151, 29);
            comboBoxDias.TabIndex = 1;
            // 
            // mtbAdidas
            // 
            mtbAdidas.Font = new Font("Montserrat Black", 9F, FontStyle.Bold | FontStyle.Italic);
            mtbAdidas.Location = new Point(496, 120);
            mtbAdidas.Mask = "999";
            mtbAdidas.Name = "mtbAdidas";
            mtbAdidas.Size = new Size(125, 26);
            mtbAdidas.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Black", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(526, 88);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 3;
            label2.Text = "NIKE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Black", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(720, 88);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 5;
            label3.Text = "ADIDAS";
            // 
            // mtbNike
            // 
            mtbNike.Font = new Font("Montserrat Black", 9F, FontStyle.Bold | FontStyle.Italic);
            mtbNike.Location = new Point(686, 120);
            mtbNike.Mask = "999";
            mtbNike.Name = "mtbNike";
            mtbNike.Size = new Size(125, 26);
            mtbNike.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat Black", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(948, 78);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 7;
            label4.Text = "PUMA";
            // 
            // mtbPuma
            // 
            mtbPuma.Font = new Font("Montserrat Black", 9F, FontStyle.Bold | FontStyle.Italic);
            mtbPuma.Location = new Point(919, 110);
            mtbPuma.Mask = "999";
            mtbPuma.Name = "mtbPuma";
            mtbPuma.Size = new Size(125, 26);
            mtbPuma.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat Black", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(893, 247);
            label5.Name = "label5";
            label5.Size = new Size(207, 21);
            label5.TabIndex = 13;
            label5.Text = "PRECIO UNITARIO PUMA";
            // 
            // mtbPrecioPuma
            // 
            mtbPrecioPuma.Font = new Font("Montserrat Black", 9F, FontStyle.Bold | FontStyle.Italic);
            mtbPrecioPuma.Location = new Point(919, 279);
            mtbPrecioPuma.Mask = "999";
            mtbPrecioPuma.Name = "mtbPrecioPuma";
            mtbPrecioPuma.Size = new Size(125, 26);
            mtbPrecioPuma.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat Black", 9F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(664, 247);
            label6.Name = "label6";
            label6.Size = new Size(221, 21);
            label6.TabIndex = 11;
            label6.Text = "PRECIO UNITARIO ADIDAS";
            // 
            // mtbPrecioAdidas
            // 
            mtbPrecioAdidas.Font = new Font("Montserrat Black", 9F, FontStyle.Bold | FontStyle.Italic);
            mtbPrecioAdidas.Location = new Point(692, 279);
            mtbPrecioAdidas.Mask = "999";
            mtbPrecioAdidas.Name = "mtbPrecioAdidas";
            mtbPrecioAdidas.Size = new Size(125, 26);
            mtbPrecioAdidas.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat Black", 9F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(457, 247);
            label7.Name = "label7";
            label7.Size = new Size(196, 21);
            label7.TabIndex = 9;
            label7.Text = "PRECIO UNITARIO NIKE";
            // 
            // mtbPrecioNike
            // 
            mtbPrecioNike.Font = new Font("Montserrat Black", 9F, FontStyle.Bold | FontStyle.Italic);
            mtbPrecioNike.Location = new Point(483, 279);
            mtbPrecioNike.Mask = "999";
            mtbPrecioNike.Name = "mtbPrecioNike";
            mtbPrecioNike.Size = new Size(125, 26);
            mtbPrecioNike.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.CadetBlue;
            btnGuardar.Font = new Font("Montserrat Black", 9F, FontStyle.Bold | FontStyle.Italic);
            btnGuardar.Location = new Point(526, 358);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(145, 59);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.CadetBlue;
            btnSiguiente.Font = new Font("Montserrat Black", 9F, FontStyle.Bold | FontStyle.Italic);
            btnSiguiente.Location = new Point(708, 358);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(145, 59);
            btnSiguiente.TabIndex = 15;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 224, 192);
            label8.Font = new Font("DejaVu Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1, 388);
            label8.Name = "label8";
            label8.Size = new Size(278, 120);
            label8.TabIndex = 16;
            label8.Text = "AUTORES:                             \r\nOrrala Emilia\r\nParedes Jean\r\nSantana Andrés\r\nCURSO:\r\nSegundo Semestre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1272, 623);
            Controls.Add(label8);
            Controls.Add(btnSiguiente);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(mtbPrecioPuma);
            Controls.Add(label6);
            Controls.Add(mtbPrecioAdidas);
            Controls.Add(label7);
            Controls.Add(mtbPrecioNike);
            Controls.Add(label4);
            Controls.Add(mtbPuma);
            Controls.Add(label3);
            Controls.Add(mtbNike);
            Controls.Add(label2);
            Controls.Add(mtbAdidas);
            Controls.Add(comboBoxDias);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxDias;
        private MaskedTextBox mtbAdidas;
        private Label label2;
        private Label label3;
        private MaskedTextBox mtbNike;
        private Label label4;
        private MaskedTextBox mtbPuma;
        private Label label5;
        private MaskedTextBox mtbPrecioPuma;
        private Label label6;
        private MaskedTextBox mtbPrecioAdidas;
        private Label label7;
        private MaskedTextBox mtbPrecioNike;
        private Button btnGuardar;
        private Button btnSiguiente;
        private Label label8;
    }
}
