namespace AAAAAAAAAAAAAAAAAAAAAAAAAAA
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
            this.Urgencia = new System.Windows.Forms.TextBox();
            this.iiii = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.regiaoo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reclamacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Urgencia
            // 
            this.Urgencia.Location = new System.Drawing.Point(50, 84);
            this.Urgencia.Name = "Urgencia";
            this.Urgencia.Size = new System.Drawing.Size(100, 22);
            this.Urgencia.TabIndex = 0;
            this.Urgencia.TextChanged += new System.EventHandler(this.Urgencia_TextChanged);
            // 
            // iiii
            // 
            this.iiii.AutoSize = true;
            this.iiii.Location = new System.Drawing.Point(37, 56);
            this.iiii.Name = "iiii";
            this.iiii.Size = new System.Drawing.Size(214, 16);
            this.iiii.TabIndex = 1;
            this.iiii.Text = "insira o nivel de urgencia (1, 2 ou 3)";
            this.iiii.Click += new System.EventHandler(this.iiii_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // regiaoo
            // 
            this.regiaoo.Location = new System.Drawing.Point(50, 170);
            this.regiaoo.Name = "regiaoo";
            this.regiaoo.Size = new System.Drawing.Size(100, 22);
            this.regiaoo.TabIndex = 3;
            this.regiaoo.TextChanged += new System.EventHandler(this.regiaoo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "insira a sua região (em MAIÚSCULO)";
            // 
            // reclamacao
            // 
            this.reclamacao.Location = new System.Drawing.Point(388, 118);
            this.reclamacao.Name = "reclamacao";
            this.reclamacao.Size = new System.Drawing.Size(100, 22);
            this.reclamacao.TabIndex = 5;
            this.reclamacao.TextChanged += new System.EventHandler(this.reclamacao_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.reclamacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regiaoo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iiii);
            this.Controls.Add(this.Urgencia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Urgencia;
        private System.Windows.Forms.Label iiii;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox regiaoo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reclamacao;
    }
}

