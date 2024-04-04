using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhomosca
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            principal ob = new principal();
            if (ob == null)
            {
                ob.Parent = this;
            }
            ob.Show();
            this.Hide();
        }
    }
}
