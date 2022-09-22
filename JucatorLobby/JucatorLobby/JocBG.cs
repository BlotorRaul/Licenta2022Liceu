using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JucatorLobby
{
    public partial class JocBG : Form
    {
        //26:00 ptr versiunea urmatoare


        bool mergeStanga;
        bool mergeDreapta;
        bool isGameOver;

        int scor;
        int mingex;
        int mingey;
        int jucatorViteza;

        Random rnd = new Random();

        public JocBG()
        {
            InitializeComponent();

            setupGame();
        }

        private void setupGame()
        {
            scor = 0;
            mingex = 5;
            mingey = 5;
            jucatorViteza = 12;
            txtScor.Text = "Scor: " + scor;


            gameTimer.Start();

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "blocks")
                {
                    x.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }
            }

        }

        private void gameOver(string mesaj)
        {
            isGameOver = true;
            gameTimer.Stop();

            txtScor.Text = "Scor: " + scor + " " + mesaj; 
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            txtScor.Text = "Scor: " + scor;
            if (mergeStanga == true && jucator.Left>0)
            {
                jucator.Left -= jucatorViteza;
            }
            if (mergeDreapta ==true && jucator.Left< 525)
            {
                jucator.Left += jucatorViteza;
            }

            minge.Left += mingex;
            minge.Top += mingey;

            if (minge.Left < 0 || minge.Left > 580)
            {
                mingex = -mingex;
            }
            if(minge.Top < 0)
            {
                mingey = -mingey;
            }

            if (minge.Bounds.IntersectsWith(jucator.Bounds))
            {
                mingey = rnd.Next(5, 12) * -1;

                if (mingex<0)
                {
                    mingex = rnd.Next(5, 12) * -1;
                }
                else
                {
                    mingex = rnd.Next(5, 12);
                }    
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    if (minge.Bounds.IntersectsWith(x.Bounds))
                    {
                        scor += 1;

                        mingey = -mingey;

                        this.Controls.Remove(x);
                    }
                }
            }


            if (scor==28)
            {
                gameOver("Ai castigat!");
            }

            if(minge.Top> 500)
            {
                gameOver("Ai pierdut!");
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Left)
            {
                mergeStanga = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                mergeDreapta = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                mergeStanga = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                mergeDreapta = false;
            }
        }
    }
}
