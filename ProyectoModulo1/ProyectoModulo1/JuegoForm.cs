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
    public partial class JuegoForm : Form
    {
        Dictionary<int, List<string>> preguntas = new Dictionary<int, List<string>>();
        List<string> pregunta1 = new List<string>() { "¿Cuál es el río más largo del mundo?", "Amazonas", "Misisipi", "Magdalena", "Nilo" };
        List<string> pregunta2 = new List<string>() { "¿Cuál es el país con más habitantes del mundo?", "India", "Japón", "China", "EEUU" };
        List<string> pregunta3 = new List<string>() { "¿Cuándo llegó Cristóbal Colón a América?", "1942", "1492", "1080", "1345" };
        List<string> pregunta4 = new List<string>() { "¿Cuántos lados tiene un heptágono?", "7", "6", "5", "9" };
        List<string> pregunta5 = new List<string>() { "¿Cuántos huesos tiene el cuerpo humano?", "198", "201", "126", "206" };
        int numDePregunta = 1;
        int preguntasCorrectas = 0;
        bool cincuenta = false;

        public JuegoForm()
        {
            InitializeComponent();

            preguntas.Add(1, pregunta1);  // AGG
            preguntas.Add(2, pregunta2);
            preguntas.Add(3, pregunta3);
            preguntas.Add(4, pregunta4);
            preguntas.Add(5, pregunta5);


            asignacionPregunta();
            



        }

        public void asignacionPregunta()
        {
           
            int Puntaje = 0;

            int numPreguntas = 0;

            if(numDePregunta > 5)
            {
                finalJuego fj = new finalJuego();
                if (preguntasCorrectas > 5)
                {
                    fj.label1.Text = "Respuestas correctas: " + preguntasCorrectas.ToString() + " " + "\n" + "\n" + "GANÓ! FELICIDADES";
                }
                else
                {
                    fj.label1.Text = "Respuestas correctas: " + preguntasCorrectas.ToString() + " " + "\n" + "\n" + "PERDIÓ :(";
                }
                
                this.Hide();    
                fj.ShowDialog();
                this.Close();

                //MessageBox.Show("Fin del juego" + "preguntas correctas: " + preguntasCorrectas.ToString());
            }

            else
            {
                pregunta(numDePregunta, preguntas);
            }

           

        }

        public void pregunta(int num,
            Dictionary<int, List<string>> preguntas)
        {
            List<string> pregunta_juego = new List<string>();

            pregunta_juego = preguntas[num];

            label1.Text = "Pregunta número: " + numDePregunta.ToString();

            label3.Text = pregunta_juego[0];

            if (cincuenta == true)
            {
                cincuenta_cincuenta(pregunta_juego[1], pregunta_juego[2], pregunta_juego[3], pregunta_juego[4]);
            }

            else
            {
                button1.Text = "A. " + pregunta_juego[1];

                button2.Text = "B. " + pregunta_juego[2];

                button3.Text = "C. " + pregunta_juego[3];

                button4.Text = "D. " + pregunta_juego[4];

            }


        }

        public void cincuenta_cincuenta(string a, string b, string c, string d)
        {
            switch (numDePregunta)
            {
                case 1:

                    button1.Text = "A. " + a;

                    button2.Text = " ";

                    button3.Text = " ";

                    button4.Text = "D. " + d;

                    cincuenta = false;

                    button5.Hide();

                    break;

                case 2:

                    button1.Text = "A. " + a;

                    button2.Text = " ";

                    button3.Text = "C. " + c;

                    button4.Text = " ";

                    cincuenta = false;

                    button5.Hide();

                    break;

                case 3:

                    button1.Text = " ";

                    button2.Text = "B. " + b;

                    button3.Text = " ";

                    button4.Text = "D. " + d;

                    cincuenta = false;

                    button5.Hide();

                    break;

                case 4:

                    button1.Text = "A. " + a;

                    button2.Text = " ";

                    button3.Text = " ";

                    button4.Text = "D. " + d;

                    cincuenta = false;

                    button5.Hide();

                    break;

                case 5:

                    button1.Text = " ";

                    button2.Text = "B. " + d;

                    button3.Text = " ";

                    button4.Text = "D. " + d;

                    cincuenta = false;

                    button5.Hide();

                    break;

            }
            
        }
        private void JuegoForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numDePregunta == 1 || numDePregunta == 4)
            {
                MessageBox.Show("Respuesta correcta");

                numDePregunta += 1;

                preguntasCorrectas += 1;

                asignacionPregunta();

            }
            else
            {
                MessageBox.Show("Respuesta incorrecta :(");

                numDePregunta += 1;

                asignacionPregunta();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numDePregunta == 3)
            {
                MessageBox.Show("Respuesta correcta");

                numDePregunta += 1;

                preguntasCorrectas += 1;

                asignacionPregunta();

            }
            else
            {
                MessageBox.Show("Respuesta incorrecta :(");

                numDePregunta += 1;

                asignacionPregunta();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (numDePregunta == 2)
            {
                MessageBox.Show("Respuesta correcta");

                numDePregunta += 1;

                preguntasCorrectas += 1;

                asignacionPregunta();

            }
            else
            {
                MessageBox.Show("Respuesta incorrecta :(");

                numDePregunta += 1;

                asignacionPregunta();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (numDePregunta == 5)
            {
                MessageBox.Show("Respuesta correcta");

                numDePregunta += 1;

                preguntasCorrectas += 1;

                asignacionPregunta();

            }
            else
            {
                MessageBox.Show("Respuesta incorrecta :(");

                numDePregunta += 1;

                asignacionPregunta();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cincuenta = true;
            asignacionPregunta();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Llamada formulario = new Llamada();
            formulario.ShowDialog();
            button6.Hide();
        }

       
    }
}
