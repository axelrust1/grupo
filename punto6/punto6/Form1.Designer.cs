namespace punto6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CapacidadPerso = new System.Windows.Forms.TextBox();
            this.Asistencia = new System.Windows.Forms.TextBox();
            this.CalculoPorcentaje = new System.Windows.Forms.Button();
            this.AumentoPersonas = new System.Windows.Forms.Button();
            this.DisminuirPersonas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(148, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la capacidad de personas de la sala de cine";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(260, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese las personas q asistieron";
            // 
            // CapacidadPerso
            // 
            this.CapacidadPerso.Location = new System.Drawing.Point(489, 101);
            this.CapacidadPerso.Name = "CapacidadPerso";
            this.CapacidadPerso.Size = new System.Drawing.Size(100, 23);
            this.CapacidadPerso.TabIndex = 2;
            // 
            // Asistencia
            // 
            this.Asistencia.Location = new System.Drawing.Point(489, 134);
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.Size = new System.Drawing.Size(100, 23);
            this.Asistencia.TabIndex = 3;
            // 
            // CalculoPorcentaje
            // 
            this.CalculoPorcentaje.BackColor = System.Drawing.Color.DarkRed;
            this.CalculoPorcentaje.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CalculoPorcentaje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CalculoPorcentaje.Location = new System.Drawing.Point(316, 190);
            this.CalculoPorcentaje.Name = "CalculoPorcentaje";
            this.CalculoPorcentaje.Size = new System.Drawing.Size(153, 36);
            this.CalculoPorcentaje.TabIndex = 6;
            this.CalculoPorcentaje.Text = "Calcular porcentaje";
            this.CalculoPorcentaje.UseVisualStyleBackColor = false;
            this.CalculoPorcentaje.Click += new System.EventHandler(this.button1_Click);
            // 
            // AumentoPersonas
            // 
            this.AumentoPersonas.BackColor = System.Drawing.Color.DarkRed;
            this.AumentoPersonas.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AumentoPersonas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AumentoPersonas.Location = new System.Drawing.Point(316, 232);
            this.AumentoPersonas.Name = "AumentoPersonas";
            this.AumentoPersonas.Size = new System.Drawing.Size(153, 36);
            this.AumentoPersonas.TabIndex = 7;
            this.AumentoPersonas.Text = "Aumentar personas";
            this.AumentoPersonas.UseVisualStyleBackColor = false;
            this.AumentoPersonas.Click += new System.EventHandler(this.button2_Click);
            // 
            // DisminuirPersonas
            // 
            this.DisminuirPersonas.BackColor = System.Drawing.Color.DarkRed;
            this.DisminuirPersonas.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DisminuirPersonas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DisminuirPersonas.Location = new System.Drawing.Point(316, 274);
            this.DisminuirPersonas.Name = "DisminuirPersonas";
            this.DisminuirPersonas.Size = new System.Drawing.Size(153, 35);
            this.DisminuirPersonas.TabIndex = 8;
            this.DisminuirPersonas.Text = "Disminuir personas";
            this.DisminuirPersonas.UseVisualStyleBackColor = false;
            this.DisminuirPersonas.Click += new System.EventHandler(this.DisminuirPersonas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisminuirPersonas);
            this.Controls.Add(this.AumentoPersonas);
            this.Controls.Add(this.CalculoPorcentaje);
            this.Controls.Add(this.Asistencia);
            this.Controls.Add(this.CapacidadPerso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox CapacidadPerso;
        private TextBox Asistencia;
        private Button CalculoPorcentaje;
        private Button AumentoPersonas;
        private Button DisminuirPersonas;
    }
}