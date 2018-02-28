namespace Procesos
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
            this.btnCalcFCFS = new System.Windows.Forms.Button();
            this.txtTotalProcesos = new System.Windows.Forms.TextBox();
            this.btnCalcSJF = new System.Windows.Forms.Button();
            this.btnCalcLJF = new System.Windows.Forms.Button();
            this.btnCalcLSF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcFCFS
            // 
            this.btnCalcFCFS.Location = new System.Drawing.Point(179, 92);
            this.btnCalcFCFS.Name = "btnCalcFCFS";
            this.btnCalcFCFS.Size = new System.Drawing.Size(75, 23);
            this.btnCalcFCFS.TabIndex = 0;
            this.btnCalcFCFS.Text = "FCFS";
            this.btnCalcFCFS.UseVisualStyleBackColor = true;
            this.btnCalcFCFS.Click += new System.EventHandler(this.btnCalcFCFS_Click);
            // 
            // txtTotalProcesos
            // 
            this.txtTotalProcesos.Location = new System.Drawing.Point(12, 43);
            this.txtTotalProcesos.Name = "txtTotalProcesos";
            this.txtTotalProcesos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalProcesos.TabIndex = 1;
            // 
            // btnCalcSJF
            // 
            this.btnCalcSJF.Location = new System.Drawing.Point(179, 139);
            this.btnCalcSJF.Name = "btnCalcSJF";
            this.btnCalcSJF.Size = new System.Drawing.Size(75, 23);
            this.btnCalcSJF.TabIndex = 2;
            this.btnCalcSJF.Text = "SJF";
            this.btnCalcSJF.UseVisualStyleBackColor = true;
            this.btnCalcSJF.Click += new System.EventHandler(this.btnCalcSJF_Click);
            // 
            // btnCalcLJF
            // 
            this.btnCalcLJF.Location = new System.Drawing.Point(179, 185);
            this.btnCalcLJF.Name = "btnCalcLJF";
            this.btnCalcLJF.Size = new System.Drawing.Size(75, 23);
            this.btnCalcLJF.TabIndex = 3;
            this.btnCalcLJF.Text = "LJF";
            this.btnCalcLJF.UseVisualStyleBackColor = true;
            this.btnCalcLJF.Click += new System.EventHandler(this.btnCalcLJF_Click);
            // 
            // btnCalcLSF
            // 
            this.btnCalcLSF.Location = new System.Drawing.Point(179, 226);
            this.btnCalcLSF.Name = "btnCalcLSF";
            this.btnCalcLSF.Size = new System.Drawing.Size(75, 23);
            this.btnCalcLSF.TabIndex = 4;
            this.btnCalcLSF.Text = "LSF";
            this.btnCalcLSF.UseVisualStyleBackColor = true;
            this.btnCalcLSF.Click += new System.EventHandler(this.btnCalcLSF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCalcLSF);
            this.Controls.Add(this.btnCalcLJF);
            this.Controls.Add(this.btnCalcSJF);
            this.Controls.Add(this.txtTotalProcesos);
            this.Controls.Add(this.btnCalcFCFS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcFCFS;
        private System.Windows.Forms.TextBox txtTotalProcesos;
        private System.Windows.Forms.Button btnCalcSJF;
        private System.Windows.Forms.Button btnCalcLJF;
        private System.Windows.Forms.Button btnCalcLSF;
    }
}

