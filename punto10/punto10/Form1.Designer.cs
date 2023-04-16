namespace punto10
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
            this.Nombre = new System.Windows.Forms.TextBox();
            this.AnioIngreso = new System.Windows.Forms.TextBox();
            this.TarifaHoraria = new System.Windows.Forms.TextBox();
            this.HorasTrabajadas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DiasTrabajados = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(287, 57);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 23);
            this.Nombre.TabIndex = 0;
            // 
            // AnioIngreso
            // 
            this.AnioIngreso.Location = new System.Drawing.Point(287, 101);
            this.AnioIngreso.Name = "AnioIngreso";
            this.AnioIngreso.Size = new System.Drawing.Size(100, 23);
            this.AnioIngreso.TabIndex = 1;
            // 
            // TarifaHoraria
            // 
            this.TarifaHoraria.Location = new System.Drawing.Point(287, 143);
            this.TarifaHoraria.Name = "TarifaHoraria";
            this.TarifaHoraria.Size = new System.Drawing.Size(100, 23);
            this.TarifaHoraria.TabIndex = 2;
            // 
            // HorasTrabajadas
            // 
            this.HorasTrabajadas.Location = new System.Drawing.Point(287, 184);
            this.HorasTrabajadas.Name = "HorasTrabajadas";
            this.HorasTrabajadas.Size = new System.Drawing.Size(100, 23);
            this.HorasTrabajadas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Anio Ingreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "tarifa horaria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "horas trabajadas por dia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dia trabajados al mes";
            // 
            // DiasTrabajados
            // 
            this.DiasTrabajados.Location = new System.Drawing.Point(287, 223);
            this.DiasTrabajados.Name = "DiasTrabajados";
            this.DiasTrabajados.Size = new System.Drawing.Size(100, 23);
            this.DiasTrabajados.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DiasTrabajados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HorasTrabajadas);
            this.Controls.Add(this.TarifaHoraria);
            this.Controls.Add(this.AnioIngreso);
            this.Controls.Add(this.Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Nombre;
        private TextBox AnioIngreso;
        private TextBox TarifaHoraria;
        private TextBox HorasTrabajadas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox DiasTrabajados;
        private Button button1;
    }
}