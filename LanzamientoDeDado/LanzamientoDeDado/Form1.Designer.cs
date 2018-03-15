namespace LanzamientoDeDado
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLanzarUnaVez = new System.Windows.Forms.Button();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.btnCienLanzamientos = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLanzarUnaVez
            // 
            this.btnLanzarUnaVez.Location = new System.Drawing.Point(2, 12);
            this.btnLanzarUnaVez.Name = "btnLanzarUnaVez";
            this.btnLanzarUnaVez.Size = new System.Drawing.Size(75, 23);
            this.btnLanzarUnaVez.TabIndex = 0;
            this.btnLanzarUnaVez.Text = "1L";
            this.btnLanzarUnaVez.UseVisualStyleBackColor = true;
            this.btnLanzarUnaVez.Click += new System.EventHandler(this.btnLanzarUnaVez_Click);
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(57, 63);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(150, 186);
            this.txtResultados.TabIndex = 1;
            // 
            // btnCienLanzamientos
            // 
            this.btnCienLanzamientos.Location = new System.Drawing.Point(93, 12);
            this.btnCienLanzamientos.Name = "btnCienLanzamientos";
            this.btnCienLanzamientos.Size = new System.Drawing.Size(75, 23);
            this.btnCienLanzamientos.TabIndex = 2;
            this.btnCienLanzamientos.Text = "100 L";
            this.btnCienLanzamientos.UseVisualStyleBackColor = true;
            this.btnCienLanzamientos.Click += new System.EventHandler(this.btnCienLanzamientos_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(184, 12);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 3;
            this.btnSuma.Text = "1*2*100";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnCienLanzamientos);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.btnLanzarUnaVez);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLanzarUnaVez;
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Button btnCienLanzamientos;
        private System.Windows.Forms.Button btnSuma;
    }
}

