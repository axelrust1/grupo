namespace punto9
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
            this.Horas1 = new System.Windows.Forms.TextBox();
            this.Minutos1 = new System.Windows.Forms.TextBox();
            this.Segundos1 = new System.Windows.Forms.TextBox();
            this.Segundos2 = new System.Windows.Forms.TextBox();
            this.Minutos2 = new System.Windows.Forms.TextBox();
            this.Horas2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Convertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Horas1
            // 
            this.Horas1.Location = new System.Drawing.Point(214, 57);
            this.Horas1.Name = "Horas1";
            this.Horas1.Size = new System.Drawing.Size(100, 23);
            this.Horas1.TabIndex = 0;
            // 
            // Minutos1
            // 
            this.Minutos1.Location = new System.Drawing.Point(214, 109);
            this.Minutos1.Name = "Minutos1";
            this.Minutos1.Size = new System.Drawing.Size(100, 23);
            this.Minutos1.TabIndex = 1;
            // 
            // Segundos1
            // 
            this.Segundos1.Location = new System.Drawing.Point(214, 165);
            this.Segundos1.Name = "Segundos1";
            this.Segundos1.Size = new System.Drawing.Size(100, 23);
            this.Segundos1.TabIndex = 2;
            // 
            // Segundos2
            // 
            this.Segundos2.Location = new System.Drawing.Point(522, 165);
            this.Segundos2.Name = "Segundos2";
            this.Segundos2.Size = new System.Drawing.Size(100, 23);
            this.Segundos2.TabIndex = 3;
            // 
            // Minutos2
            // 
            this.Minutos2.Location = new System.Drawing.Point(522, 109);
            this.Minutos2.Name = "Minutos2";
            this.Minutos2.Size = new System.Drawing.Size(100, 23);
            this.Minutos2.TabIndex = 4;
            // 
            // Horas2
            // 
            this.Horas2.Location = new System.Drawing.Point(522, 57);
            this.Horas2.Name = "Horas2";
            this.Horas2.Size = new System.Drawing.Size(100, 23);
            this.Horas2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tiempo1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Teimpo2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Horas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Minutos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Segundos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Segundos";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Minutos";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Horas";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Convertir
            // 
            this.Convertir.Location = new System.Drawing.Point(369, 293);
            this.Convertir.Name = "Convertir";
            this.Convertir.Size = new System.Drawing.Size(75, 23);
            this.Convertir.TabIndex = 15;
            this.Convertir.Text = "Calcular";
            this.Convertir.UseVisualStyleBackColor = true;
            this.Convertir.Click += new System.EventHandler(this.Convertir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Convertir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Horas2);
            this.Controls.Add(this.Minutos2);
            this.Controls.Add(this.Segundos2);
            this.Controls.Add(this.Segundos1);
            this.Controls.Add(this.Minutos1);
            this.Controls.Add(this.Horas1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Horas1;
        private TextBox Minutos1;
        private TextBox Segundos1;
        private TextBox Segundos2;
        private TextBox Minutos2;
        private TextBox Horas2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button Convertir;
    }
}