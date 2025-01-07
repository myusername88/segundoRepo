using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_practica_WinForm_Nombre
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

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reBoton_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            textoEnBlanco.Text = "Hola " + texto; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
