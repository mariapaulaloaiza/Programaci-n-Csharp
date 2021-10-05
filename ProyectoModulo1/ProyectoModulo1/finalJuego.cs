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
    public partial class finalJuego : Form
    {
        public finalJuego()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            JuegoForm juego = new JuegoForm();

            this.Hide();

            juego.ShowDialog();

            this.Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            InicioForm form1 = new InicioForm();
            this.Hide();
            form1.ShowDialog();
            this.Close();

        }
    }
}
