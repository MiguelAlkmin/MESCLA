using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADASTROOO
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();

        }

        string usuario;
        string senha;
        public void REGISTR0(string user, string password)

        {
            usuario = user;
            senha = password;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (usercad.Text == usuario && senhacad.Text == senha)
            {
                MessageBox.Show("foi");

            }

        }

        private void usercad_TextChanged(object sender, EventArgs e)
        {

        }

        private void senhacad_TextChanged(object sender, EventArgs e)
        {

        }
         private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                senhacad.UseSystemPasswordChar = false;
            }
            else
            {
                senhacad.UseSystemPasswordChar = true;
            }

        }
    }
}
