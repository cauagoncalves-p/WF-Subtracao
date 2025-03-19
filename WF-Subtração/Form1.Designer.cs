namespace WF_Subtração
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
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnClique = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero2.Location = new System.Drawing.Point(12, 93);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(144, 18);
            this.lblNumero2.TabIndex = 14;
            this.lblNumero2.Text = "Informe o 2° numero";
            // 
            // txtNumero2
            // 
            this.txtNumero2.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNumero2.Location = new System.Drawing.Point(12, 124);
            this.txtNumero2.Multiline = true;
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(242, 38);
            this.txtNumero2.TabIndex = 13;
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero1.Location = new System.Drawing.Point(12, 10);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(148, 18);
            this.lblNumero1.TabIndex = 12;
            this.lblNumero1.Text = "Informe o 1°  numero";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNumero.Location = new System.Drawing.Point(12, 41);
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(242, 38);
            this.txtNumero.TabIndex = 11;
            // 
            // btnClique
            // 
            this.btnClique.BackColor = System.Drawing.Color.Lime;
            this.btnClique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClique.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClique.Location = new System.Drawing.Point(12, 180);
            this.btnClique.Name = "btnClique";
            this.btnClique.Size = new System.Drawing.Size(242, 42);
            this.btnClique.TabIndex = 10;
            this.btnClique.Text = "Subtração";
            this.btnClique.UseVisualStyleBackColor = false;
            this.btnClique.Click += new System.EventHandler(this.btnClique_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 236);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnClique);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnClique;
    }
}

