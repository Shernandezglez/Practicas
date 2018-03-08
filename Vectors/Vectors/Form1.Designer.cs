namespace Vectors
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
            this.btnCrearVector = new System.Windows.Forms.Button();
            this.txtTamanioVector = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnLlenarVector = new System.Windows.Forms.Button();
            this.btnLlenarAleatorio = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnMostrarInverso = new System.Windows.Forms.Button();
            this.btnSumarVector = new System.Windows.Forms.Button();
            this.btnPromediar = new System.Windows.Forms.Button();
            this.btnGirarArriba = new System.Windows.Forms.Button();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCrearVector
            // 
            this.btnCrearVector.Location = new System.Drawing.Point(189, 30);
            this.btnCrearVector.Name = "btnCrearVector";
            this.btnCrearVector.Size = new System.Drawing.Size(75, 23);
            this.btnCrearVector.TabIndex = 0;
            this.btnCrearVector.Text = "Convertir";
            this.btnCrearVector.UseVisualStyleBackColor = true;
            this.btnCrearVector.Click += new System.EventHandler(this.btnCrearVector_Click);
            // 
            // txtTamanioVector
            // 
            this.txtTamanioVector.Location = new System.Drawing.Point(12, 30);
            this.txtTamanioVector.Name = "txtTamanioVector";
            this.txtTamanioVector.Size = new System.Drawing.Size(100, 20);
            this.txtTamanioVector.TabIndex = 1;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(12, 91);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(141, 269);
            this.txtInfo.TabIndex = 2;
            // 
            // btnLlenarVector
            // 
            this.btnLlenarVector.Location = new System.Drawing.Point(189, 91);
            this.btnLlenarVector.Name = "btnLlenarVector";
            this.btnLlenarVector.Size = new System.Drawing.Size(75, 23);
            this.btnLlenarVector.TabIndex = 3;
            this.btnLlenarVector.Text = "Llenar";
            this.btnLlenarVector.UseVisualStyleBackColor = true;
            this.btnLlenarVector.Click += new System.EventHandler(this.btnLlenarVector_Click);
            // 
            // btnLlenarAleatorio
            // 
            this.btnLlenarAleatorio.Location = new System.Drawing.Point(189, 139);
            this.btnLlenarAleatorio.Name = "btnLlenarAleatorio";
            this.btnLlenarAleatorio.Size = new System.Drawing.Size(107, 23);
            this.btnLlenarAleatorio.TabIndex = 4;
            this.btnLlenarAleatorio.Text = "Llenar Aleatorio";
            this.btnLlenarAleatorio.UseVisualStyleBackColor = true;
            this.btnLlenarAleatorio.Click += new System.EventHandler(this.btnLlenarAleatorio_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(189, 189);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnMostrarInverso
            // 
            this.btnMostrarInverso.Location = new System.Drawing.Point(189, 237);
            this.btnMostrarInverso.Name = "btnMostrarInverso";
            this.btnMostrarInverso.Size = new System.Drawing.Size(107, 23);
            this.btnMostrarInverso.TabIndex = 6;
            this.btnMostrarInverso.Text = "Mostar Inverso";
            this.btnMostrarInverso.UseVisualStyleBackColor = true;
            this.btnMostrarInverso.Click += new System.EventHandler(this.btnMostrarInverso_Click);
            // 
            // btnSumarVector
            // 
            this.btnSumarVector.Location = new System.Drawing.Point(189, 283);
            this.btnSumarVector.Name = "btnSumarVector";
            this.btnSumarVector.Size = new System.Drawing.Size(75, 23);
            this.btnSumarVector.TabIndex = 7;
            this.btnSumarVector.Text = "Sumar";
            this.btnSumarVector.UseVisualStyleBackColor = true;
            this.btnSumarVector.Click += new System.EventHandler(this.btnSumarVector_Click);
            // 
            // btnPromediar
            // 
            this.btnPromediar.Location = new System.Drawing.Point(189, 328);
            this.btnPromediar.Name = "btnPromediar";
            this.btnPromediar.Size = new System.Drawing.Size(75, 23);
            this.btnPromediar.TabIndex = 8;
            this.btnPromediar.Text = "Promediar";
            this.btnPromediar.UseVisualStyleBackColor = true;
            this.btnPromediar.Click += new System.EventHandler(this.btnPromediar_Click);
            // 
            // btnGirarArriba
            // 
            this.btnGirarArriba.Location = new System.Drawing.Point(189, 372);
            this.btnGirarArriba.Name = "btnGirarArriba";
            this.btnGirarArriba.Size = new System.Drawing.Size(75, 23);
            this.btnGirarArriba.TabIndex = 9;
            this.btnGirarArriba.Text = "girar";
            this.btnGirarArriba.UseVisualStyleBackColor = true;
            this.btnGirarArriba.Click += new System.EventHandler(this.btnGirarArriba_Click);
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(286, 286);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(100, 20);
            this.txtSuma.TabIndex = 10;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(286, 328);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(100, 20);
            this.txtPromedio.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 438);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.btnGirarArriba);
            this.Controls.Add(this.btnPromediar);
            this.Controls.Add(this.btnSumarVector);
            this.Controls.Add(this.btnMostrarInverso);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnLlenarAleatorio);
            this.Controls.Add(this.btnLlenarVector);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtTamanioVector);
            this.Controls.Add(this.btnCrearVector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearVector;
        private System.Windows.Forms.TextBox txtTamanioVector;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnLlenarVector;
        private System.Windows.Forms.Button btnLlenarAleatorio;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnMostrarInverso;
        private System.Windows.Forms.Button btnSumarVector;
        private System.Windows.Forms.Button btnPromediar;
        private System.Windows.Forms.Button btnGirarArriba;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.TextBox txtPromedio;
    }
}

