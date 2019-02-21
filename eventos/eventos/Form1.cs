using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_SizeChanged(object sender, EventArgs e)
        {
MessageBox.Show("Esto es un ziz changed");
        }

        private void textBox1_FontChanged(object sender, EventArgs e)
        {
            MessageBox.Show("La font ha cambiado");
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {

        }

       

        private void textBox1_BackColorChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Su color ha cambiado");
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Pink;
        }
    }
}
