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
    public partial class JocJS : Form
    {

        bool mergeStanga, mergeDreapta, impuscat, isGameOver;
        int scor;
        int jucatorViteza=12;
        int dusmanViteza;
        int glontViteza;
        Random rnd = new Random();


        public JocJS()
        {
            InitializeComponent();
            resetGame();
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            txtScor.Text = scor.ToString();

            Dusman1.Top += dusmanViteza;
            Dusman2.Top += dusmanViteza;
            Dusman3.Top += dusmanViteza;

            if(Dusman1.Top> 710 || Dusman2.Top > 710|| Dusman2.Top > 710)
            {
                gameOver();
            }

            //startul miscarii jucatorului 
            if (mergeStanga== true && Jucator.Left>0)
            {
                Jucator.Left -= jucatorViteza;
            }

            if(mergeDreapta == true && Jucator.Left<490)
            {
                Jucator.Left += jucatorViteza;
            }
            // finish miscarii jucatorului

            if(impuscat== true)
            {
                glontViteza = 20;
                Glont.Top -= glontViteza;

            }
            else
            {
                Glont.Left = -300;
                glontViteza = 0;
            }

            if(Glont.Top<-30)
            {
                impuscat = false;
            }

            if(Glont.Bounds.IntersectsWith(Dusman1.Bounds))
            {
                scor += 1;
                Dusman1.Top = -450;
                Dusman1.Left = rnd.Next(20, 490);
                impuscat = false;
            }
            if (Glont.Bounds.IntersectsWith(Dusman2.Bounds))
            {
                scor += 1;
                Dusman2.Top = -650;
                Dusman2.Left = rnd.Next(20, 490);
                impuscat = false;
            }
            if (Glont.Bounds.IntersectsWith(Dusman3.Bounds))
            {
                scor += 1;
                Dusman3.Top = -750;
                Dusman3.Left = rnd.Next(20, 490);
                impuscat = false;
            }

            if(scor==10)
            {
                dusmanViteza = 10;
            }

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                mergeStanga = true;
            }
            if(e.KeyCode == Keys.Right)
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

            if(e.KeyCode == Keys.Space && impuscat == false)
            {
                impuscat = true;

                Glont.Top = Jucator.Top - 30;
                Glont.Left = Jucator.Left + (Jucator.Width / 2);
            }

            if(e.KeyCode == Keys.Enter && isGameOver == true)
            {
                resetGame();

            }
        }

        private void resetGame()
        {
            gameTimer.Start();
            dusmanViteza = 6;

            Dusman1.Left = rnd.Next(20, 490);
            Dusman2.Left = rnd.Next(20, 490);
            Dusman3.Left = rnd.Next(20, 490);

            Dusman1.Top = rnd.Next(0, 200) * -1;
            Dusman2.Top = rnd.Next(0, 500) * -1;
            Dusman3.Top = rnd.Next(0, 900) * -1;

            scor = 0;
            glontViteza = 0;
            Glont.Left = -300;
            impuscat = false;


            txtScor.Text = scor.ToString();
            txtScor.SendToBack();
        }

        private void gameOver()
        {
            isGameOver = true;
            gameTimer.Stop();
            txtScor.Text += Environment.NewLine + "Sfarsitul Jocului!!" + Environment.NewLine + "Apasa Enter ca sa reincepi.";
            txtScor.BringToFront();
        }
    }
}
