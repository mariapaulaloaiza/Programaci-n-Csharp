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
    public partial class Llamada : Form
    {
        int contador = 30;
        public Llamada()
        {
            InitializeComponent();

            this.label2.Text = contador.ToString();
            this.timer1.Interval = 1000;
            this.timer1.Start();
            this.timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            contador--;

            if (contador == 0)
            {
                this.timer1.Stop();
                string[] opciones = new string[] { "A", "B", "C", "D","No responde" };
                Random rnd = new Random();
                int index = rnd.Next(opciones.Length);
                MessageBox.Show("Amigo dice : " + opciones[index]);
                this.Close();
            }

            this.label2.Text = contador.ToString();
            this.label2.Refresh();
        }

        private void Llamada_Load(object sender, EventArgs e)
        {

        }
    }
}
