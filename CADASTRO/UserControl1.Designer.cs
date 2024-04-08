namespace CADASTROOO
{
    partial class UserControl1
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

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.usuario = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.senha2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(56, 120);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(100, 22);
            this.usuario.TabIndex = 0;
            this.usuario.TextChanged += new System.EventHandler(this.usuario_TextChanged);
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(56, 158);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(100, 22);
            this.senha.TabIndex = 1;
            this.senha.UseSystemPasswordChar = true;
            this.senha.TextChanged += new System.EventHandler(this.senha_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "cadastro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // senha2
            // 
            this.senha2.Location = new System.Drawing.Point(56, 203);
            this.senha2.Name = "senha2";
            this.senha2.Size = new System.Drawing.Size(100, 22);
            this.senha2.TabIndex = 3;
            this.senha2.UseSystemPasswordChar = true;
            this.senha2.TextChanged += new System.EventHandler(this.senha2_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(46, 240);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "mostrar senhas";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.senha2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.usuario);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(422, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox senha2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
