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
    public partial class CombatWindow : Form
    {
        private Personnage perso;
        private Monstre monstre;

        public CombatWindow()
        {

            InitializeComponent();

        }

        public CombatWindow(Personnage perso)
        {
            InitializeComponent();
            this.perso = perso;
            this.monstre = new Monstre();
            MessageBox.Show("Un "+monstre.Name+" se présente devant vous ! FIGHT !", "The Dungeon");

            nameMonstre.Text = monstre.Name;
            pvMonstre.Text = "PV : "+ monstre.Pv;
            degatsMonstre.Text = "Dégats : " + monstre.Degat;

            pvPerso.Text = "PV : " + perso.Pv;
            degatsPerso.Text = "Dégats : " + perso.Degat;

        }

        internal Personnage Perso { get => perso; set => perso = value; }

        private void CombatWindow_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            
                monstre.Attacked(perso.Degat);
                MessageBox.Show(monstre.Name + " reçoit " + perso.Degat + " dégats !NICE !", "The Dungeon");


                if (!monstre.Alive)
                {
                    this.Close();
                    MessageBox.Show( monstre.Name + " est mort YAAAY ! ;D", "The Dungeon");
                    QuizWindow quiz = new QuizWindow(perso);
                    quiz.Show();
                    return;
                }


            pvMonstre.Text = "PV : " + monstre.Pv;
            degatsMonstre.Text = "Dégats : " + monstre.Degat;



            monstre.TourMonstre();
            perso.Pv = perso.Pv - monstre.Degat;

                MessageBox.Show(monstre.Name + " utilise 'DEVOIR MAISON' et vous inflige " + monstre.Degat + " OUCH !", "The Dungeon");

           
                if (perso.isDead())
                {
                    this.Close();
                    MessageBox.Show("Vous etes mort ! x(", "RIP");
                    return;

                }


            pvPerso.Text = "PV : " + perso.Pv;
            degatsPerso.Text = "Dégats : " + perso.Degat;


        }
    }
}
