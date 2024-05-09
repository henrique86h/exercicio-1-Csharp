namespace exercicio_1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOiTudoBem = new System.Windows.Forms.Button();
            this.lblOi = new System.Windows.Forms.Label();
            this.lblTudoBem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClick.Location = new System.Drawing.Point(26, 170);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(214, 68);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // btnOiTudoBem
            // 
            this.btnOiTudoBem.BackColor = System.Drawing.Color.IndianRed;
            this.btnOiTudoBem.Location = new System.Drawing.Point(440, 170);
            this.btnOiTudoBem.Name = "btnOiTudoBem";
            this.btnOiTudoBem.Size = new System.Drawing.Size(212, 68);
            this.btnOiTudoBem.TabIndex = 3;
            this.btnOiTudoBem.Text = "Clique";
            this.btnOiTudoBem.UseVisualStyleBackColor = false;
            this.btnOiTudoBem.Click += new System.EventHandler(this.btnOiTudoBem_Click);
            // 
            // lblOi
            // 
            this.lblOi.AutoSize = true;
            this.lblOi.Location = new System.Drawing.Point(538, 265);
            this.lblOi.Name = "lblOi";
            this.lblOi.Size = new System.Drawing.Size(0, 13);
            this.lblOi.TabIndex = 4;
            // 
            // lblTudoBem
            // 
            this.lblTudoBem.AutoSize = true;
            this.lblTudoBem.Location = new System.Drawing.Point(522, 303);
            this.lblTudoBem.Name = "lblTudoBem";
            this.lblTudoBem.Size = new System.Drawing.Size(0, 13);
            this.lblTudoBem.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTudoBem);
            this.Controls.Add(this.lblOi);
            this.Controls.Add(this.btnOiTudoBem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOiTudoBem;
        private System.Windows.Forms.Label lblOi;
        private System.Windows.Forms.Label lblTudoBem;
    }
}

