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
    public partial class JocTR : Form
    {

        bool saritura = false;
        int vitezaSaritura ;
        int forta = 12;
        int scor = 0;
        int vitezaObstacol = 10;
        Random rand = new Random();
        int pozitie;
        bool gameOver = false;

        public JocTR()
        {
            InitializeComponent();
            ResetJoc();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            Trex.Top += vitezaSaritura;

            txtScor.Text = "Scor: " + scor;
            if(saritura == true && forta<0)
            {
                saritura = false;
            }

            if(saritura==true)
            {
                vitezaSaritura = -12;
                forta -= 1;
            }
            else
            {
                vitezaSaritura = 12;
            }

            if(Trex.Top> 289 && saritura== false)
            {
                forta = 12;
                Trex.Top = 290;
                vitezaSaritura = 0;
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag== "obstacol")
                {
                    x.Left -= vitezaObstacol;
                    if (x.Left< -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        scor++;
                    }

                    if(Trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        Trex.Image = Properties.Resources.dead;
                        txtScor.Text += " Apasa R pentru a restarta jocul!";
                        gameOver = true;
                    }
                }
            }

            if(scor > 10)
            { vitezaObstacol = 15; }


        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && saritura == false)
                saritura = true;
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (saritura == true)
                saritura = false;

            if(e.KeyCode==Keys.R && gameOver== true)
            {
                ResetJoc();
            }
        }

        private void ResetJoc()
        {
            forta = 12;
            vitezaSaritura = 0;
            saritura = false;
            scor = 0;
            vitezaObstacol = 10;
            txtScor.Text = "Scor: " + scor;
            Trex.Image = Properties.Resources.running;
            gameOver = false;
            Trex.Top = 290;

            foreach (Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "obstacol")
                {
                    pozitie = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);

                    x.Left = pozitie;
                }
            }

            gameTimer.Start();


        }
    }
}
