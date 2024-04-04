using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAAAAAAAAAAAAAAAAAAAAAAAAAA
{
    public partial class AAAAABBBB : Form
    {
        public AAAAABBBB()
        {
            InitializeComponent();
        }

        private void AAAAABBBB_Load(object sender, EventArgs e)
        {
            
        }
        public void Receber(string reclamacx)
        {
            label1.Text = reclamacx;
        }

        public void Urgencia (int urgente)
        {
            string urgencia;
            switch (urgente)
            {
                case 1:
                    urgencia = "URGENCIA NIVEL VERDE";
                    label2.Text = urgencia;

                break;

                case 2:
                    urgencia = "URGENCIA AMARELO ";
                    label2.Text = urgencia;

                    break;


                case 3:
                    urgencia = "URGENCIA VERDE ";
                    label2.Text = urgencia;

                    break;

            }
        }
       
        public void Regioes (int regiao)
        {
            string textreg;
            switch (regiao)
            {
                case 1:
                    textreg = "REGIÃO NORTE";
                    label3.Text = textreg;
                    break;

                case 2:
                    textreg = "REGIÃO LESTE";
                    label3.Text = textreg;
                    break;

                case 3:
                    textreg = "REGIÃO OESTE";
                    label3.Text = textreg;
                    break;

                case 4:
                    textreg = "REGIÃO SUL";
                    label3.Text = textreg;
                    break;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
