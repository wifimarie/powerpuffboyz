using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox2.Text)>= 18)
            {
                MessageBox.Show("Usted es mayor de edad");

            }
            else
            {
                MessageBox.Show("Usted es menor");
            }
        }
    }
}
