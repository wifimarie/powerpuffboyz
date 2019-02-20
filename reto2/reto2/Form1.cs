using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reto2
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
                MessageBox.Show("Domingo");
            }
            if (Convert.ToInt32(textBox1.Text) == 2)
            {
                MessageBox.Show("Lunes");
            }
            if (Convert.ToInt32(textBox1.Text) == 3)
            {
                MessageBox.Show("Martes");
            }
            if (Convert.ToInt32(textBox1.Text) == 4)
            {
                MessageBox.Show("Miércoles");
            }
            if (Convert.ToInt32(textBox1.Text) == 5)
            {
                MessageBox.Show("Jueves");
            }
            if (Convert.ToInt32(textBox1.Text) == 6)
            {
                MessageBox.Show("Viernes");
            }
            if (Convert.ToInt32(textBox1.Text) == 7)
            {
                MessageBox.Show("Sabado");
            }
            
        }
    }
}
