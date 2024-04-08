namespace CADASTROOO
{
    partial class LOGIN
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
            this.usercad = new System.Windows.Forms.TextBox();
            this.senhacad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // usercad
            // 
            this.usercad.Location = new System.Drawing.Point(138, 142);
            this.usercad.Name = "usercad";
            this.usercad.Size = new System.Drawing.Size(100, 22);
            this.usercad.TabIndex = 0;
            this.usercad.TextChanged += new System.EventHandler(this.usercad_TextChanged);
            // 
            // senhacad
            // 
            this.senhacad.Location = new System.Drawing.Point(138, 206);
            this.senhacad.Name = "senhacad";
            this.senhacad.Size = new System.Drawing.Size(100, 22);
            this.senhacad.TabIndex = 1;
            this.senhacad.UseSystemPasswordChar = true;
            this.senhacad.UseWaitCursor = true;
            this.senhacad.TextChanged += new System.EventHandler(this.senhacad_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(138, 244);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "mostrar senha";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.senhacad);
            this.Controls.Add(this.usercad);
            this.Name = "LOGIN";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usercad;
        private System.Windows.Forms.TextBox senhacad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}