using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoModulo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void inicio_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            InicioForm Inicioform = new InicioForm();

            Inicioform.ShowDialog();

           

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
