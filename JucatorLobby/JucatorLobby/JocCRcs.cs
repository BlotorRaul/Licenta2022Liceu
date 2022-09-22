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
    public partial class JocCRcs : Form
    {

       
        int vitezaStrada;
        int vitezaTrafic;
        int vitezaJucator = 12;
        int scor;
        int imagineMasina;

        Random rand = new Random();
        Random pozitieMasina = new Random();

        bool mergeStanga, mergeDreapta;

        public JocCRcs()
        {
            InitializeComponent();
            resetGame();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Left)
            {
                mergeStanga = true;
            }
            if (e.KeyCode==Keys.Right)
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

        private void gameTimerEvent(object sender, EventArgs e)
        {
            txtScor.Text = "Scor: " + scor;
            scor++;


            if (mergeStanga== true && jucator.Left>5)
            {
                jucator.Left -= vitezaJucator;
            }
            if (mergeDreapta== true && jucator.Left <310)
            {
                jucator.Left += vitezaJucator;
            }

            roadTrack1.Top += vitezaStrada;
            roadTrack2.Top += vitezaStrada;

            if (roadTrack2.Top > 519)
            {
                roadTrack2.Top = -519;
            }
            if(roadTrack1.Top> 519)
            {
                roadTrack1.Top=-519;
            }
            AI1.Top += vitezaTrafic;
            AI2.Top += vitezaTrafic;

            if(AI1.Top> 530)
            {
                schimbaAIMasina(AI1);
            }
            if (AI2.Top > 530)
            {
                schimbaAIMasina(AI2);
            }


            if(jucator.Bounds.IntersectsWith(AI1.Bounds)||jucator.Bounds.IntersectsWith(AI2.Bounds) )
            {
                gameOver();
            }
            if(scor>40 && scor<500)
            {
                premiu.Image = Properties.Resources.bronze;
            }

            if (scor > 500 && scor < 2000)
            {
                premiu.Image = Properties.Resources.silver;
                vitezaStrada = 20;
                vitezaTrafic = 22;
            }
            if (scor > 2000)
            {
                premiu.Image = Properties.Resources.gold;
                vitezaStrada = 25;
                vitezaTrafic = 27;
            }

        }

        private void schimbaAIMasina(PictureBox tempMasina)
        {
            imagineMasina = rand.Next(1, 9);

            switch (imagineMasina)
            {
                case 1:
            tempMasina.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    tempMasina.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    tempMasina.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    tempMasina.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    tempMasina.Image = Properties.Resources.carPink;
                    break;
                case 6:
                    tempMasina.Image = Properties.Resources.CarRed;
                    break;
                case 7:
                    tempMasina.Image = Properties.Resources.carYellow;
                    break;
                case 8:
                    tempMasina.Image = Properties.Resources.TruckBlue;
                    break;
                case 9:
                    tempMasina.Image = Properties.Resources.TruckWhite;
                    break;
            }
            //fghfghfghfghf
            tempMasina.Top = pozitieMasina.Next(100, 400) * -1;


            if ((string)tempMasina.Tag=="masinaStanga")
            {
                tempMasina.Left = pozitieMasina.Next(5, 200);
            }
            if ((string)tempMasina.Tag == "masinaDreapta")
            {
                tempMasina.Left = pozitieMasina.Next(200, 350);
            }


        }

        private void gameOver()
        {
            pornesteSunetu();
            gameTimer.Stop();
            explozie.Visible = true;
            //parenting
            jucator.Controls.Add(explozie);
            explozie.Location = new Point(-8, 5);


            explozie.BackColor = Color.Transparent;
            premiu.Visible = true;
            premiu.BringToFront();

            btnStart.Enabled = true;


        }
        private void resetGame()
        {
            btnStart.Enabled = false;
            explozie.Visible = false;
            premiu.Visible = false;
            mergeStanga = false;
            mergeDreapta = false;
            scor = 0;
            premiu.Image = Properties.Resources.bronze;

            vitezaStrada = 12;
            vitezaTrafic = 15;
            //dfgdfgdfgd
            AI1.Top = pozitieMasina.Next(200, 500) * -1;
            AI1.Left = pozitieMasina.Next(5, 200);

            AI2.Top = pozitieMasina.Next(200, 500) * -1;
            AI2.Left = pozitieMasina.Next(200,350);


            gameTimer.Start();
        }

        private void restartGame(object sender, EventArgs e)
        {
            resetGame();
        }

        private void pornesteSunetu()
        {
            System.Media.SoundPlayer incepeSunetul = new System.Media.SoundPlayer(Properties.Resources.hit);
            incepeSunetul.Play();
        }
    }
}
