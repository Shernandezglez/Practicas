namespace monedis
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
            this.btnUn = new System.Windows.Forms.Button();
            this.btnDiez = new System.Windows.Forms.Button();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUn
            // 
            this.btnUn.Location = new System.Drawing.Point(12, 12);
            this.btnUn.Name = "btnUn";
            this.btnUn.Size = new System.Drawing.Size(92, 23);
            this.btnUn.TabIndex = 0;
            this.btnUn.Text = "Lanzar una vez";
            this.btnUn.UseVisualStyleBackColor = true;
            this.btnUn.Click += new System.EventHandler(this.btnUn_Click);
            // 
            // btnDiez
            // 
            this.btnDiez.Location = new System.Drawing.Point(143, 12);
            this.btnDiez.Name = "btnDiez";
            this.btnDiez.Size = new System.Drawing.Size(113, 23);
            this.btnDiez.TabIndex = 1;
            this.btnDiez.Text = "Diez Lanzamientos";
            this.btnDiez.UseVisualStyleBackColor = true;
            this.btnDiez.Click += new System.EventHandler(this.btnDiez_Click);
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(79, 71);
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(111, 156);
            this.txtRes.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.btnDiez);
            this.Controls.Add(this.btnUn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUn;
        private System.Windows.Forms.Button btnDiez;
        private System.Windows.Forms.TextBox txtRes;
    }
}

