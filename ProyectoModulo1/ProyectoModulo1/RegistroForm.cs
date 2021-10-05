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
    public partial class RegistroForm : Form

    {
        public DataTable dtPersona = new DataTable();
        

        public RegistroForm()
        {
            InitializeComponent();

            
        }

        public void registro()
        {
            int resultado = 0;
            if(textBox1.Text!="" && textBox2.Text != "" && textBox3.Text != ""
                && textBox4.Text != "")
            {
                if (!Int32.TryParse(textBox1.Text, out resultado) && !Int32.TryParse(textBox4.Text, out resultado))
                {
                    if(textBox2.Text == textBox3.Text)
                    {
                        DataTable dtp = new DataTable();
                        dtp.Columns.Add("Usuario", typeof(string));  /// string 
                        dtp.Columns.Add("Contraseña");
                        dtp.Columns.Add("Correo");
                        DataRow fila = dtp.NewRow();
                        fila["Usuario"] = textBox1.Text;
                        fila["Contraseña"] = textBox2.Text;
                        fila["Correo"] = textBox4.Text;

                        dtp.Rows.Add(fila);
                        dtPersona = dtp;
                        MessageBox.Show("Información guardada");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                    }

                    else
                    {
                        MessageBox.Show("Las contraseñas con coinciden");
                    }
                }

                else
                {
                    MessageBox.Show("Solo puede ingresar cadenas de texto");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
           

            

           

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            registro();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InicioForm inicio = new InicioForm();

            inicio.data = dtPersona;

            this.Hide();
            inicio.ShowDialog();
            this.Close();


        }
    }

}

