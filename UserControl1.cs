using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADASTROOO
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        LOGIN oi = new LOGIN();
        private void button1_Click(object sender, EventArgs e)
        {

            string user = usuario.Text;
            string senhaa = senha.Text;
            string senhaa2 = senha2.Text;
            int numerosenha = 0;
            int numerosenha2 = 0;

            Int32.TryParse(senhaa, out numerosenha);
            Int32.TryParse(senhaa2, out numerosenha2);

            if (user == "" || senhaa == "")
            {
                MessageBox.Show("usuário ou senha inválidos");
            }
            else if (numerosenha < 10000 || numerosenha > 99999)
            {
                MessageBox.Show("senha inválida");
            }
            else if (senhaa != senhaa2)
            {
                MessageBox.Show("senhas não se condizem");
            }
            else
            {
                oi.REGISTR0(user, senhaa);

                MessageBox.Show("registrado com sucesso");

                oi.Show();
                this.Hide();
            }


        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void senha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void senha2_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                senha.UseSystemPasswordChar = false;
                senha2.UseSystemPasswordChar = false;
            }
            else
            {
                senha.UseSystemPasswordChar = true;
                senha2.UseSystemPasswordChar = true;
            }
        }
    }
    }

