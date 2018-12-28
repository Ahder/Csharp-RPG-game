using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /*cette classe est la creation du scenario dunjon  */
    public class Scenario
    {
        public void CreationPerso(Personnage perso)
        {
            Console.WriteLine("************************Welcome to the Dunjeon !*************************");
            Console.WriteLine("Avant de commancer ton aventure, il faut créer ton pero ! ");

            Console.WriteLine("D'abbord choisis le nom que tu veux donner a ton pero (Sois original pls ...)");
            string name = Console.ReadLine();

            Console.WriteLine("Il faut choisir la race de ton perso : \n");

            int r = 0;

            while (r <= 0 || r > 3)
            {
                Console.WriteLine(
                    "1 : Humain ( tout pourri !) \n" +
                    "2 : Elfe du Rizomm ( Cool ;D *^* ) \n" +
                    "3 : Devil (MOUAHAHAHAHAHAHAHA 3:) ... ok)");

                r = Int32.Parse(Console.ReadLine());
            }

            string race = "";
            switch (r)
            {
                case 1:
                    race = "Humain";
                    break;

                case 2:
                    race = "Elfe du Rizom";
                    break;

                case 3:
                    race = "Devil";
                    break;

            }

            Console.WriteLine("Il ne reste plus qu'choisir l'arme qu'utilisera ton perso : \n");

            int a = 0;

            while (a <= 0 || a > 3)
            {
                Console.WriteLine(
                    "1 : Hache ( +0 Dégat ) \n" +
                    "2 : Baguette magique ( -1 Dégat ) \n" +
                    "3 : Epée en mousse ( +2 Dégat )");

                a = Int32.Parse(Console.ReadLine());

            }

            string arme = "";
            switch (a)
            {
                case 1:
                    arme = "Hache";
                    break;

                case 2:
                    arme = "Baguette magique";
                    break;

                case 3:
                    arme = "Epée en mousse";
                    break;

            }

            perso = new Personnage(name, race, arme);


            Console.WriteLine("Parfait ! Votre nom est :" + perso.Nom + ", vous etes un " + perso.Race +
                " et vous etes équipé d'une " + perso.Arme + " !! Vous etes pret a affronter tous les dangers !");
            Console.ReadLine();

        }

        public void Combat(Personnage character, Monstre mob)
        {
            Console.WriteLine("Un " + mob.Name + " Apparait ! \n");

            while (mob.Alive)
            {
               
        
                Console.WriteLine(mob.Name + "(" + " PV = " + mob.Pv + "  Degat = " + mob.Degat + " )");
                Console.WriteLine("Vos PV = " + character.Pv);

                // Tour du joueur
                Console.WriteLine("Tapez 1 pour attaquer !");
                int reponse = Int32.Parse(Console.ReadLine());
                while (reponse != 1)
                {
                    reponse = Int32.Parse(Console.ReadLine());
                }

                mob.Attacked(character.Degat);

                if (!mob.Alive)
                {
                    Console.ReadLine();
                    return;
                }

                //Tour du monstre
                character.Pv = character.Pv - mob.TourMonstre();

                if (character.isDead())
                {
                    Console.ReadLine();
                    return;
                }



            }


        }
        public void Quiz1(Personnage per)
        {
            int rep = 0;
            Console.WriteLine("En quelle année le premier jeu The Legend of Zelda est sorti au Japon? (SANS UTILISER GOOGLE PLZ :)) \n" +
                " 1 : 2018 \n 2 : 1850 \n 3 : 1986 \n 4 : la reponse 4");

            while (rep != 3)
            {
                Console.WriteLine("Vos PV = " + per.Pv);

                rep = Int32.Parse(Console.ReadLine());
            if (rep != 3)
                {
                    per.Pv = per.Pv - 1;
                    Console.WriteLine("Mauvaise reponse ! vous recevez 1 Dégat :( try again");
                    
                }
                else
                {
                    Console.WriteLine("Victoire vous etes un génie ^^ ");
                    return;
                }

            if(per.isDead())
                {
                    return;
                }
            }
     
        }

        public void Quiz2(Personnage per)
        {
            int rep = 0;
            Console.WriteLine("En quelle année est sorti le premier album de Nirvana(Live on Air) ? (SANS UTILISER GOOGLE PLZ :)) \n" +
                " 1 : 2018 \n 2 : 2020 \n 3 : 1987 \n 4 : la reponse 4");

            while (rep != 3)
            {
                Console.WriteLine("Vos PV = " + per.Pv);

                rep = Int32.Parse(Console.ReadLine());
                if (rep != 3)
                {
                    per.Pv = per.Pv - 1;
                    Console.WriteLine("Mauvaise reponse ! vous recevez 1 Dégat :( try again");

                }
                else
                {
                    Console.WriteLine("Victoire vous etes un génie ^^ ");
                    return;
                }

                if (per.isDead())
                {
                    return ;
                }
            }

        }


    }
}
