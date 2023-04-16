namespace punto3
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
            this.label3 = new System.Windows.Forms.Label();
            this.AnchoPared = new System.Windows.Forms.TextBox();
            this.AltoPared = new System.Windows.Forms.TextBox();
            this.m3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(197, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el ancho de la pared: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(197, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el alto de la pared: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(197, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese los m3 por metros cuadrados:";
            // 
            // AnchoPared
            // 
            this.AnchoPared.Location = new System.Drawing.Point(477, 52);
            this.AnchoPared.Name = "AnchoPared";
            this.AnchoPared.Size = new System.Drawing.Size(100, 23);
            this.AnchoPared.TabIndex = 3;
            this.AnchoPared.TextChanged += new System.EventHandler(this.AnchoPared_TextChanged);
            // 
            // AltoPared
            // 
            this.AltoPared.Location = new System.Drawing.Point(477, 97);
            this.AltoPared.Name = "AltoPared";
            this.AltoPared.Size = new System.Drawing.Size(100, 23);
            this.AltoPared.TabIndex = 4;
            this.AltoPared.TextChanged += new System.EventHandler(this.AltoPared_TextChanged);
            // 
            // m3
            // 
            this.m3.Location = new System.Drawing.Point(477, 138);
            this.m3.Name = "m3";
            this.m3.Size = new System.Drawing.Size(100, 23);
            this.m3.TabIndex = 5;
            this.m3.TextChanged += new System.EventHandler(this.m3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 135);
            this.button1.TabIndex = 6;
            this.button1.Text = "CALCULAR LOS M3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "CERRAR";
            this.button2.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.m3);
            this.Controls.Add(this.AltoPared);
            this.Controls.Add(this.AnchoPared);
            this.Controls.Add(this.label3);
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
        private Label label3;
        private TextBox AnchoPared;
        private TextBox AltoPared;
        private TextBox m3;
        private Button button1;
        private Button button2;
    }
}