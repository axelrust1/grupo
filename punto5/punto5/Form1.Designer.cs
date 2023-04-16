namespace punto5
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
            this.NombreCliente = new System.Windows.Forms.TextBox();
            this.ValorPagado = new System.Windows.Forms.TextBox();
            this.ValorCompra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NombreCliente
            // 
            this.NombreCliente.Location = new System.Drawing.Point(448, 66);
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Size = new System.Drawing.Size(100, 23);
            this.NombreCliente.TabIndex = 0;
            this.NombreCliente.TextChanged += new System.EventHandler(this.NombreCliente_TextChanged);
            // 
            // ValorPagado
            // 
            this.ValorPagado.Location = new System.Drawing.Point(448, 159);
            this.ValorPagado.Name = "ValorPagado";
            this.ValorPagado.Size = new System.Drawing.Size(100, 23);
            this.ValorPagado.TabIndex = 1;
            this.ValorPagado.TextChanged += new System.EventHandler(this.ValorPagado_TextChanged);
            // 
            // ValorCompra
            // 
            this.ValorCompra.Location = new System.Drawing.Point(448, 116);
            this.ValorCompra.Name = "ValorCompra";
            this.ValorCompra.Size = new System.Drawing.Size(100, 23);
            this.ValorCompra.TabIndex = 2;
            this.ValorCompra.TextChanged += new System.EventHandler(this.ValorCompra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(254, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el nombre del cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(254, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese el precio de la compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(254, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese con cuanto paga";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(304, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular vuelto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(304, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValorCompra);
            this.Controls.Add(this.ValorPagado);
            this.Controls.Add(this.NombreCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NombreCliente;
        private TextBox ValorPagado;
        private TextBox ValorCompra;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}