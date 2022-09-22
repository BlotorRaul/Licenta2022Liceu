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
    public partial class JocRPScs : Form
    {

       
        int runde = 3;
        int timpPerRunda = 6;
        bool gameOver = false;

        string[] PClistaAlegeri = { "piatra", "foarfeca", "hartie", "hartie", "foarfeca", "piatra" };

        int numarRandom = 0;

        Random rnd = new Random();

        string PcAlegere;
        
        string JucatorAlegere;

        int JucatorScor;
        int PcScor;

        public JocRPScs()
        {
            InitializeComponent();
            numaraScadenta.Enabled = true;
            JucatorAlegere = "Nici una";
            txtScadenta.Text = "5";
        }

        private void btnPiatra_Click(object sender, EventArgs e)
        {
            picJucator.Image = Properties.Resources.rock;
            JucatorAlegere = "piatra";
        }

        private void btnFoarfeca_Click(object sender, EventArgs e)
        {
            picJucator.Image = Properties.Resources.scissors;
            JucatorAlegere = "foarfeca";
        }

        private void btnHartie_Click(object sender, EventArgs e)
        {
            picJucator.Image = Properties.Resources.paper;
            JucatorAlegere = "hartie";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

            JucatorScor = 0;
            PcScor = 0;
            runde = 3;
            txtScor.Text = "Jucator: " + JucatorScor + " - " + "PC: " + PcScor;

            JucatorAlegere = "Nici una";

            numaraScadenta.Enabled = true;

            picJucator.Image = Properties.Resources.qq;
            picPC.Image = Properties.Resources.qq;
            gameOver = false;


        }

        private void numaraScadentaEvent(object sender, EventArgs e)
        {
            timpPerRunda -= 1;
            txtScadenta.Text = timpPerRunda.ToString();
            txtRunde.Text = "Runde: " + runde;
            if(timpPerRunda < 1)
            {
                numaraScadenta.Enabled = false;
                timpPerRunda = 6;
                numarRandom = rnd.Next(0, PClistaAlegeri.Length);
                PcAlegere = PClistaAlegeri[numarRandom];

                switch(PcAlegere)
                {
                    case "piatra":
                        picPC.Image = Properties.Resources.rock;
                        break;
                    case "hartie":
                        picPC.Image = Properties.Resources.paper;
                        break;
                    case "foarfeca":
                        picPC.Image = Properties.Resources.scissors;
                        break;
                }

                if(runde>0)
                {
                    verificareJoc();
                }
                else
                {  
                    if(JucatorScor>PcScor)
                    {
                        MessageBox.Show("Jucatorul a castigat!");
                    }
                    else
                    {
                        MessageBox.Show("Calculatorul a castigat!");
                    }
                    gameOver = true;
                }

            }
        }

        private void verificareJoc()
        {
            if(JucatorAlegere=="piatra" && PcAlegere=="hartie")
            {
                PcScor += 1;
                runde -= 1;

                MessageBox.Show("Calculatorul castiga! Hartia acopera Piatra");
            }
            else if(JucatorAlegere == "foarfeca" && PcAlegere == "piatra")
            {
                PcScor += 1;
                runde -= 1;

                MessageBox.Show("Calculatorul castiga! Piatra sparge Foarfeca");
            }
            else if (JucatorAlegere == "hartie" && PcAlegere == "foarfeca")
            {
                PcScor += 1;
                runde -= 1;

                MessageBox.Show("Calculatorul castiga! Foarfeca taie Hartia");
            }
            else if (JucatorAlegere == "piatra" && PcAlegere == "foarfeca")
            {
                JucatorScor += 1;
                runde -= 1;

                MessageBox.Show("Jucatorul castiga! Piatra sparge Foarfeca");
            }
            else if (JucatorAlegere == "hartie" && PcAlegere == "piatra")
            {
                JucatorScor += 1;
                runde -= 1;

                MessageBox.Show("Jucatorul castiga! Hartia acopera Piatra");
            }
            else if (JucatorAlegere == "foarfeca" && PcAlegere == "hartie")
            {
                JucatorScor += 1;
                runde -= 1;

                MessageBox.Show("Jucatorul castiga! Foarfeca taie Hartia");
            }
            else if (JucatorAlegere == "Nici una")
            {

                MessageBox.Show("Alege!");
            }
            else
            {
                MessageBox.Show("Egalitate!");
            }

            StartUrmatoareaRunda();

        }


        private void StartUrmatoareaRunda()
        {
            if (gameOver == true)
            {
                return;
            }

            txtScor.Text = "Jucator: " + JucatorScor + " - " + "PC: " + PcScor;

            JucatorAlegere = "Nici una";

            numaraScadenta.Enabled = true;

            picJucator.Image = Properties.Resources.qq;
            picPC.Image = Properties.Resources.qq; 

        }

    }
}
