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
    public partial class JocSI : Form
    {
        bool mergeStanga, mergeDreapta;
        int jucatorViteza = 12;
        int dusmanViteza = 5;
        int scor = 0;
        int glontDusmanTimer = 300;

        PictureBox[] Invazie;

        bool impuscare;
        bool isGameOver;
        public JocSI()
        {
            InitializeComponent();
            gameSetup();

        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            txtScor.Text = "Scor: " + scor;

            if (mergeStanga)
            {
                jucator.Left -= jucatorViteza;
            }

            if (mergeDreapta)
            {
                jucator.Left += jucatorViteza;
            }

            glontDusmanTimer -= 10;

            if(glontDusmanTimer<1)
            {
                glontDusmanTimer = 300;
                facereGlont("glontinamic");
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag=="invazie")
                {
                    x.Left += dusmanViteza;

                    if (x.Left > 630)
                    {
                        x.Top += 65;
                        x.Left = -80;
                    }


                    if (x.Bounds.IntersectsWith(jucator.Bounds))
                    {
                        gameOver("Ai fost invadat de extraterestrii!");
                    }


                    foreach (Control y in this.Controls)
                    {
                        if (y is PictureBox && (string)y.Tag== "glont")
                        {
                            if(y.Bounds.IntersectsWith(x.Bounds))
                            {
                                this.Controls.Remove(x);
                                this.Controls.Remove(y);

                                scor += 1;
                                impuscare = false;
                            }
                        }
                    }
                }

                if(x is PictureBox && (string) x.Tag=="glont")
                {
                    x.Top -= 20;

                    if(x.Top<15)
                    {
                        this.Controls.Remove(x);
                        impuscare = false;
                    }
                }

                if(x is PictureBox && (string)x.Tag=="glontinamic")
                {
                    x.Top += 20;

                    if(x.Top>520)
                    {
                        this.Controls.Remove(x);
                    }
                    if(x.Bounds.IntersectsWith(jucator.Bounds))
                    {
                        this.Controls.Remove(x);
                        gameOver("Ai fost omorat de catre Glontul Inamic!");
                    }

                }

            }

            if(scor>12)
            {
                dusmanViteza = 12;
            }
            if (scor== Invazie.Length)
            {
                gameOver("Ai castigat!!");
            }
            
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                mergeStanga = true;
            }
            if (e.KeyCode== Keys.Right)
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
            if(e.KeyCode== Keys.Space && impuscare==false)
            {
                impuscare = true;
                facereGlont("glont");
            }
            if(e.KeyCode== Keys.Enter && isGameOver == true)
            {
                stergeTot();
                gameSetup();
            }
        }

        private void facereInvazie()
        {
            Invazie = new PictureBox[15];
            int stanga = 0;
            for(int i=0;i<Invazie.Length;i++)
            {
                Invazie[i] = new PictureBox();
                Invazie[i].Size = new Size(60, 50);
                Invazie[i].Image = Properties.Resources.inavders;
                Invazie[i].Top = 5;
                Invazie[i].Tag = "invazie";
                Invazie[i].Left = stanga;
                Invazie[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(Invazie[i]);
                stanga = stanga - 80;
            }
        }
        private void gameSetup()
        {
            txtScor.Text = "Scor: 0";
            scor = 0;
            isGameOver = false;

            glontDusmanTimer = 300;
            dusmanViteza = 5;
            impuscare = false;

            facereInvazie();
            gameTimer.Start();
        }

        private void gameOver(string mesaj)
        {
            isGameOver = true;
            gameTimer.Stop();
            txtScor.Text = "Scor: " + scor + " " + mesaj;
        }

        private void stergeTot()
        {
            foreach(PictureBox i in Invazie)
            {
                this.Controls.Remove(i);
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if((string)x.Tag == "glont" || (string)x.Tag == "glontinamic")
                    {
                        this.Controls.Remove(x);
                    }
                }
            }

        }

        private void facereGlont(string glontTag)
        {
            PictureBox glont = new PictureBox();
            glont.Image = Properties.Resources.bullet;
            glont.Size = new Size(5,20);
            glont.Tag = glontTag;
            glont.Left = jucator.Left + jucator.Width / 2;
            
            if ((string) glont.Tag =="glont")
            {
                glont.Top = jucator.Top - 20;
            }
            else
                if((string)glont.Tag== "glontinamic")
                {
                    glont.Top = -100;
                }
            this.Controls.Add(glont);
            glont.BringToFront();

        }
    }
}
