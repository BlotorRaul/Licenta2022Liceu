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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }


        private void customizeDesign()//ascundem submeniurile
        {
            panelSubmeniuPuzzle.Visible = false;
            panelSubmeniuActiune.Visible = false;
            panelSubmeniuAventura.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubmeniuPuzzle.Visible == true)
                panelSubmeniuPuzzle.Visible = false;
            if (panelSubmeniuActiune.Visible == true)
                panelSubmeniuActiune.Visible = false;
            if (panelSubmeniuAventura.Visible == true)
                panelSubmeniuAventura.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #region Puzzle Game
        private void btnPuzzleGame_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmeniuPuzzle);
        }

        private void btnRockPaperScissors_Click(object sender, EventArgs e)
        {
            openChildForm(new RockPaperScissors());
            hideSubMenu();
        }

        private void btnBreakoutGame_Click(object sender, EventArgs e)
        {
            openChildForm(new Breakout_Game());
            hideSubMenu();
        }
        #endregion
        #region Actiune Game
        private void btnActiune_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmeniuActiune);
        }

        

        private void btnJetShooter_Click(object sender, EventArgs e)
        {
            openChildForm(new JetShooter());
            hideSubMenu();
        }

        private void btnSpaceInvader_Click(object sender, EventArgs e)
        {
            openChildForm(new SpaceInvader());
            hideSubMenu();
        }
        #endregion
        #region Aventura Game
        private void btnAventura_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmeniuAventura);
        }

        private void btnCarRacing_Click(object sender, EventArgs e)
        {
            openChildForm(new CarRacing());
            hideSubMenu();
        }

        private void btnTRex_Click(object sender, EventArgs e)
        {
            openChildForm(new TRex());
            hideSubMenu();
        }
        #endregion
        #region Copil form
        private Form FormActiv = null;
        private void openChildForm(Form childForm)
        {
            if (FormActiv != null)
                FormActiv.Close();
            FormActiv = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        #endregion
        #region Ceas
        Timer t = new Timer();
        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);

            t.Start();

        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if(hh <10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if(mm<10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            label1.Text = time;

        }
        #endregion

        
    }
}
