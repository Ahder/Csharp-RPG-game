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
    public partial class QuizWindow : Form
    {

        private Personnage perso;

        public QuizWindow()
        {
            InitializeComponent();
        }

        public QuizWindow(Personnage perso)
        {
            InitializeComponent();
            this.perso = perso;

            MessageBox.Show("Après votre triomphe sur le monstre, vous poursuivez votre chemin dans les ténèbres" +
                " du donjon ... Soudain, Deux chemins se présentent devant vous, le quel choisir ? ", "The Dungeon");

            pvPerso.Text += perso.Pv; 
        }


        private void QuizWindow_Load(object sender, EventArgs e)
        {
         
            
        }

        private void btnDroite_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Vous prenez le chemin de droite ... vous faites face a un mur avec une inscription " +
                "dessus ... Vous lisez l'inscription : 'Réponds a la question suivante pour poursuivre ton chemin !'", "The Dungeon");
           

            groupBox1.Visible = true;
            btnDroite.Enabled = false;
            btnGauche.Enabled = false;

            
            question.Text = "En quelle année le premier jeu The Legend of Zelda est sorti au Japon ? (SANS UTILISER GOOGLE PLZ :))";

            rb1.Text = "2018";
            rb2.Text = "1850";
            rb3.Text = "1986";
            rb4.Text = "La reponse 4";
         
        }

        private void btnGauche_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Vous prenez le chemin de gauche ... vous faites face a un mur avec une inscription " +
                "dessus ... Vous lisez l'inscription : 'Réponds a la question suivante pour poursuivre ton chemin !'", "The Dungeon");

            groupBox1.Visible = true;
            btnDroite.Enabled = false;
            btnGauche.Enabled = false;


            question.Text = "En quelle année est sorti le premier album de Nirvana(Live on Air) ? (SANS UTILISER GOOGLE PLZ :))";
      

            rb1.Text = "2018";
            rb2.Text = "2020";
            rb3.Text = "1987";
            rb4.Text = "La reponse 4";
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
      
     
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                RadioButton rb = c as RadioButton;
                if (rb != null && rb.Checked)
                {
                    if (!rb.Equals(rb3))
                    {
                        MessageBox.Show("Mauvaise reponse ! vous recevez 1 Dégat :( try again", "The Dungeon");
                        perso.Pv = perso.Pv - 1;
                        pvPerso.Text = "PV : " + perso.Pv;
                    }
                    else
                    {
                        MessageBox.Show("Victoire vous etes un génie ^^ ", "The Dungeon");
                        this.Close();
                        MessageBox.Show("Le mur tremble et un passage s'ouvre devant vous ! Vous vous précipitez vers la sortie ...", "The Dungeon");
                        MessageBox.Show("Féliciatation ! Vous venez de sortir du donjon ^_^ Vous venez de perdre 2 minutes de votre vie !" +
                            " Have a nice Day <3 \n ******************************The End******************************", "Congrat !");
                        return;

                    }
                    if (perso.isDead())
                    {
                        MessageBox.Show("Vous etes mort x( !", "RIP !");
                        this.Close();
                        return;

                    }
                    break;
                }
            }
        }


    }
}
