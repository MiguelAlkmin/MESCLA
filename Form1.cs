using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAAAAAAAAAAAAAAAAAAAAAAAAAA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iiii_Click(object sender, EventArgs e)
        {

        }

        private void Urgencia_TextChanged(object sender, EventArgs e)
        {

        }
       
        public void button1_Click(object sender, EventArgs e)
        {
            int urgente = 0;
            string regiao = regiaoo.Text;
            int reg = 0;
            Int32.TryParse(Urgencia.Text, out urgente);

            AAAAABBBB ob = new AAAAABBBB();    
                      ob.Urgencia(urgente);
              
            switch (regiao)
            {
                case "NORTE":
                    reg = 1;
      
                    break;

                case "LESTE":
                    reg = 2;
            
                    break;

                case "OESTE":
                    reg = 3;
                    break;

                case "SUL":
                    reg = 4;
                    break;
            }
            ob.Regioes(reg);

            MessageBox.Show("ADICIONADO COM SUCESSO");
            string reclamaco = reclamacao.Text;

           
            ob.Receber(reclamaco);
            ob.Show();


        }

        private void regiaoo_TextChanged(object sender, EventArgs e)
        {

        }

        private void reclamacao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
