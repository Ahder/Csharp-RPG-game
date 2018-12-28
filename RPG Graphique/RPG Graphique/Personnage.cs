using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /*cette classe consiste a creer des personnages */



    public class Personnage
    {
        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }

        }

        private string race;
        public string Race
        {
            get { return race; }
            set { race = value; }
        }

        private string arme;
        public string Arme
        {
            get { return arme; }
            set { arme = value; }
        }

        private int pv = 5;
        public int Pv
        {
            get { return pv; }
            set { pv = value; }
        }

        private int degat = 2;
        public int Degat
        {
            get { return degat; }
            set { degat = value; }
        }



//-----------//Constructors//-----------//
        public Personnage()
        {
            // Default const.
        }

        public Personnage(string nom, string race, string arme)
        {
            this.nom = nom;
            this.race = race;
            this.arme = arme;
        
            switch (arme)
            {
                case "Hache":
                    degat = degat + 0;
                    break;

                case "Baguette magique":
                    degat = degat -2;
                    break;

                case "Epée en mousse":
                    degat = degat + 2;
                    break;
            }

        }
        //////////////////////////////////////////

       
        public bool isDead()
        {
            if (pv <= 0)
            {
                Console.WriteLine("Vous etes mort x( !");
                return true;
                
            }
            else
            {
                return false;
            }
        }

        
      


    }
}
