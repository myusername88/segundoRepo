namespace U4_practica_WinForm_Nombre
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.reBoton = new System.Windows.Forms.Button();
            this.textoEnBlanco = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reBoton
            // 
            this.reBoton.BackColor = System.Drawing.Color.Red;
            this.reBoton.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reBoton.ForeColor = System.Drawing.Color.White;
            this.reBoton.Location = new System.Drawing.Point(359, 197);
            this.reBoton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.reBoton.Name = "reBoton";
            this.reBoton.Size = new System.Drawing.Size(150, 67);
            this.reBoton.TabIndex = 0;
            this.reBoton.Text = "Saludar";
            this.reBoton.UseVisualStyleBackColor = false;
            this.reBoton.Click += new System.EventHandler(this.reBoton_Click);
            // 
            // textoEnBlanco
            // 
            this.textoEnBlanco.AutoSize = true;
            this.textoEnBlanco.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoEnBlanco.ForeColor = System.Drawing.Color.Black;
            this.textoEnBlanco.Location = new System.Drawing.Point(353, 286);
            this.textoEnBlanco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoEnBlanco.Name = "textoEnBlanco";
            this.textoEnBlanco.Size = new System.Drawing.Size(0, 34);
            this.textoEnBlanco.TabIndex = 1;
            this.textoEnBlanco.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(346, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 39);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(308, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese su nombre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textoEnBlanco);
            this.Controls.Add(this.reBoton);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Nombre de la ventana";
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reBoton;
        private System.Windows.Forms.Label textoEnBlanco;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

