namespace punto_8
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
            this.button1 = new System.Windows.Forms.Button();
            this.NumA = new System.Windows.Forms.TextBox();
            this.NumB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "INTERCAMBIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumA
            // 
            this.NumA.Location = new System.Drawing.Point(349, 65);
            this.NumA.Name = "NumA";
            this.NumA.Size = new System.Drawing.Size(100, 23);
            this.NumA.TabIndex = 1;
            // 
            // NumB
            // 
            this.NumB.Location = new System.Drawing.Point(349, 106);
            this.NumB.Name = "NumB";
            this.NumB.Size = new System.Drawing.Size(100, 23);
            this.NumB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese numero A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese numero B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumB);
            this.Controls.Add(this.NumA);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Ingrese numero A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox NumA;
        private TextBox NumB;
        private Label label1;
        private Label label2;
    }
}