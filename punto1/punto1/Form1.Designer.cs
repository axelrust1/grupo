namespace punto1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IngresoDatos = new System.Windows.Forms.TextBox();
            this.CalcularPerimetro = new System.Windows.Forms.Button();
            this.CalcularArea = new System.Windows.Forms.Button();
            this.Expresion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // IngresoDatos
            // 
            resources.ApplyResources(this.IngresoDatos, "IngresoDatos");
            this.IngresoDatos.Name = "IngresoDatos";
            this.IngresoDatos.TextChanged += new System.EventHandler(this.IngresoDatos_TextChanged);
            // 
            // CalcularPerimetro
            // 
            resources.ApplyResources(this.CalcularPerimetro, "CalcularPerimetro");
            this.CalcularPerimetro.Name = "CalcularPerimetro";
            this.CalcularPerimetro.UseVisualStyleBackColor = true;
            this.CalcularPerimetro.Click += new System.EventHandler(this.CalcularPerimetro_Click);
            // 
            // CalcularArea
            // 
            resources.ApplyResources(this.CalcularArea, "CalcularArea");
            this.CalcularArea.Name = "CalcularArea";
            this.CalcularArea.UseVisualStyleBackColor = true;
            this.CalcularArea.Click += new System.EventHandler(this.CalcularArea_Click);
            // 
            // Expresion
            // 
            resources.ApplyResources(this.Expresion, "Expresion");
            this.Expresion.Name = "Expresion";
            this.Expresion.TextChanged += new System.EventHandler(this.Expresion_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.Expresion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalcularArea);
            this.Controls.Add(this.CalcularPerimetro);
            this.Controls.Add(this.IngresoDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox IngresoDatos;
        private Button CalcularPerimetro;
        private Button CalcularArea;
        private TextBox Expresion;
        private Label label2;
    }
}