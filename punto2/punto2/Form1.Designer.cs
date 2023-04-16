namespace punto2
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
            this.VelocidadConstante = new System.Windows.Forms.Label();
            this.LugarViaje = new System.Windows.Forms.TextBox();
            this.DistanciaKM = new System.Windows.Forms.TextBox();
            this.VelConstante = new System.Windows.Forms.TextBox();
            this.TiempoDuracion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(250, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese a donde quiere viajar: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(250, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la distancia a recorrer en kilometros:";
            // 
            // VelocidadConstante
            // 
            this.VelocidadConstante.AutoSize = true;
            this.VelocidadConstante.BackColor = System.Drawing.Color.Transparent;
            this.VelocidadConstante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VelocidadConstante.Location = new System.Drawing.Point(250, 124);
            this.VelocidadConstante.Name = "VelocidadConstante";
            this.VelocidadConstante.Size = new System.Drawing.Size(248, 15);
            this.VelocidadConstante.TabIndex = 2;
            this.VelocidadConstante.Text = "Ingrese la velocidad constante del vehiculo:";
            // 
            // LugarViaje
            // 
            this.LugarViaje.Location = new System.Drawing.Point(510, 52);
            this.LugarViaje.Name = "LugarViaje";
            this.LugarViaje.Size = new System.Drawing.Size(100, 23);
            this.LugarViaje.TabIndex = 3;
            this.LugarViaje.TextChanged += new System.EventHandler(this.LugarViaje_TextChanged);
            // 
            // DistanciaKM
            // 
            this.DistanciaKM.Location = new System.Drawing.Point(510, 81);
            this.DistanciaKM.Name = "DistanciaKM";
            this.DistanciaKM.Size = new System.Drawing.Size(100, 23);
            this.DistanciaKM.TabIndex = 4;
            this.DistanciaKM.TextChanged += new System.EventHandler(this.DistanciaKM_TextChanged);
            // 
            // VelConstante
            // 
            this.VelConstante.Location = new System.Drawing.Point(510, 121);
            this.VelConstante.Name = "VelConstante";
            this.VelConstante.Size = new System.Drawing.Size(100, 23);
            this.VelConstante.TabIndex = 5;
            this.VelConstante.TextChanged += new System.EventHandler(this.VelConstante_TextChanged);
            // 
            // TiempoDuracion
            // 
            this.TiempoDuracion.BackColor = System.Drawing.Color.Transparent;
            this.TiempoDuracion.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TiempoDuracion.Location = new System.Drawing.Point(284, 180);
            this.TiempoDuracion.Name = "TiempoDuracion";
            this.TiempoDuracion.Size = new System.Drawing.Size(238, 82);
            this.TiempoDuracion.TabIndex = 6;
            this.TiempoDuracion.Text = "CALCULAR DURACION DEL VIAJE";
            this.TiempoDuracion.UseVisualStyleBackColor = false;
            this.TiempoDuracion.Click += new System.EventHandler(this.TiempoDuracion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "CERRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TiempoDuracion);
            this.Controls.Add(this.VelConstante);
            this.Controls.Add(this.DistanciaKM);
            this.Controls.Add(this.LugarViaje);
            this.Controls.Add(this.VelocidadConstante);
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
        private Label VelocidadConstante;
        private TextBox LugarViaje;
        private TextBox DistanciaKM;
        private TextBox VelConstante;
        private Button TiempoDuracion;
        private Button button1;
    }
}