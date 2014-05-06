using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica2
{
    public partial class Form1 : Form
    {
        // Create a Random object to generate random numbers
        Random randomizer = new Random();

        // These ints will store the numbers
        // for the addition problem.
        int addend1;
        int addend2;
        // this int will keep track of the time left.
        int timeLeft;



        public Form1()
        {
          
            InitializeComponent();
        }


        private void iniciarQuiz(){
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            plusLeftLabel.Text = addend1.ToString();
            PlusRightLabel.Text = addend2.ToString();

            Suma.Value = 0;

            timeLeft = 30;
            this.timeLabel.Text = "30 segundos";
            timer1.Start();





        }

        private void StartButtom_Click(object sender, EventArgs e)
        {
                         
            
           
           this.iniciarQuiz();
            this.StartButtom.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkearRespuesta())
            {
                timer1.Stop();
                MessageBox.Show("todas las respuestas correctas¡", " Completado¡");
                StartButtom.Enabled = true;
            }

            else  if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry");
                Suma.Value = addend1 + addend2;
                this.StartButtom.Enabled = true;

            }
        }

        private bool checkearRespuesta()
        {

            if (addend1 + addend2 == Suma.Value)
            {
                return true;

            }

            else
            {

                return false;

            }
        }

        private void Suma_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }

        }
    }
}