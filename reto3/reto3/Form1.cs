using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reto3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) == 1)
            {
                MessageBox.Show("Enero");
            }
            if (Convert.ToInt32(textBox1.Text) == 2)
            {
                MessageBox.Show("Febrero");
            }
            if (Convert.ToInt32(textBox1.Text) == 3)
            {
                MessageBox.Show("Marzo");
            }
            if (Convert.ToInt32(textBox1.Text) == 4)
            {
                MessageBox.Show("Abril");
            }
            if (Convert.ToInt32(textBox1.Text) == 5)
            {
                MessageBox.Show("Mayo");
            }
            if (Convert.ToInt32(textBox1.Text) == 6)
            {
                MessageBox.Show("Junio");
            }
            if (Convert.ToInt32(textBox1.Text) == 7)
            {
                MessageBox.Show("Julio");
            }
            if (Convert.ToInt32(textBox1.Text) == 8)
            {
                MessageBox.Show("Agosto");
            }
            if (Convert.ToInt32(textBox1.Text) == 9)
            {
                MessageBox.Show("Septiembre");
            }
            if (Convert.ToInt32(textBox1.Text) == 10)
            {
                MessageBox.Show("Octubre");
            }
            if (Convert.ToInt32(textBox1.Text) == 11)
            {
                MessageBox.Show("Noviembre");
            }
            if (Convert.ToInt32(textBox1.Text) == 12)
            {
                MessageBox.Show("Diciembre");
            }
        }
    }
}
