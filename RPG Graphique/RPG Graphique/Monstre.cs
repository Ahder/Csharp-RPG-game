using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /*cette classe consiste a creer des monstres */

    public class Monstre
    {
        private string name = "Prof du Rizomm";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int pv = 5;
        public int Pv
        {
            get { return pv; }
            set { pv = value; }
        }

        private int degat = 1;
        public int Degat
        {
            get { return degat; }
            set { degat = value; }
        }

        private bool alive = true;
        public bool Alive
        {
            get { return alive; }
            set { alive = value; }
        }
        //-----------//Constructors//-----------//
        public Monstre()
        {

        }

        public Monstre(string name, int pv, int degat)
        {
            this.name = name;
            this.pv = pv;
            this.degat = degat;
        }
        ///////////////////////////////////////////


        public void Attacked(int degatRecu)
        {
            pv = pv - degatRecu;
            Console.WriteLine(name + " reçoit " + degatRecu + " dégats ! NICE !");
            if (pv <= 0)
            {
                alive = false;
                Console.WriteLine(name + " est mort YAAAY ! ;D");
            }

        }

        public int TourMonstre()
        {
            if (alive == true)
            {
                Console.WriteLine(name + " utilise 'DEVOIR MAISON' et vous inflige " + degat + " OUCH !");
            }

            return degat;
        }


    }
}
