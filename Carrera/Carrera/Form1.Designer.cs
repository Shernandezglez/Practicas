namespace Carrera
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorredorUno = new System.Windows.Forms.TextBox();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.txtCorredorDos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Corredor #1";
            // 
            // txtCorredorUno
            // 
            this.txtCorredorUno.Location = new System.Drawing.Point(12, 42);
            this.txtCorredorUno.Name = "txtCorredorUno";
            this.txtCorredorUno.Size = new System.Drawing.Size(100, 20);
            this.txtCorredorUno.TabIndex = 1;
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(126, 71);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(75, 23);
            this.btnComenzar.TabIndex = 2;
            this.btnComenzar.Text = "Comenzar!";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // txtCorredorDos
            // 
            this.txtCorredorDos.Location = new System.Drawing.Point(217, 42);
            this.txtCorredorDos.Name = "txtCorredorDos";
            this.txtCorredorDos.Size = new System.Drawing.Size(100, 20);
            this.txtCorredorDos.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Corredor #2";
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(71, 100);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(191, 211);
            this.txtResultados.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 323);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.txtCorredorDos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.txtCorredorUno);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorredorUno;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.TextBox txtCorredorDos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultados;
    }
}

