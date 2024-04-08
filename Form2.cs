using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Trabalho_mosca
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.DateTime dt1 = dateTimePicker1.Value;
            System.DateTime dt2 = dateTimePicker2.Value;
            System.TimeSpan dias = dt2.Subtract(dt1);
           // var total_dias = (int)Math.Round(dias);

            textBox2.Text = "DIAS: " + dias;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          /*  int id = int.Parse(textBox3.Text);
            int contador=5
            do
            {
                id 

                contador--;
            }while (contador > 0);
*/
        }
    }
}
