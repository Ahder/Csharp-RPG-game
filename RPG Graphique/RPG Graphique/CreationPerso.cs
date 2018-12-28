using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Graphique
{
    public partial class CreaPerso : Form
    {
        public CreaPerso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CreaPerso_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartingWindow menu = new StartingWindow();
            menu.Show();
            this.Close();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            String Nom = textNom.Text;
            String race = "";
            String arme = "";

            foreach (Control c in gbRace.Controls)
            {
                RadioButton rb = c as RadioButton;
                if (rb != null && rb.Checked)
                {

                    race = rb.Text;
                    break;
                }
            }

            foreach (Control c in gbArme.Controls)
            {
                RadioButton rb = c as RadioButton;
                if (rb != null && rb.Checked)
                {

                    arme = rb.Text;
                    break;
                }
            }

            
            

            DialogResult result = MessageBox.Show("Parfait ! Votre nom est: " + Nom + ", vous etes un " + race +
                " et vous etes équipé d'une " + arme + " !! Vous etes pret a affronter tous les dangers !", "The Dungeon", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // ouvrir next window
                this.Close();
                Personnage perso = new Personnage(Nom, race, arme);
                CombatWindow cb = new CombatWindow(perso);
                cb.Show();
            }

            else if (result == DialogResult.No)
            {
                textNom.Clear();

                foreach (Control c in gbRace.Controls)
                {
                    RadioButton rb = c as RadioButton;
                    if (rb != null && rb.Checked)
                    {

                        rb.Checked = false;
                        break;
                    }

                }

                foreach (Control c in gbArme.Controls)
                {
                    RadioButton rb = c as RadioButton;
                    if (rb != null && rb.Checked)
                    {
                        rb.Checked = false;
                        break;
                    }

                }

            }


        }

        private void rbHuman_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}

