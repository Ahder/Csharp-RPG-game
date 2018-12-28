using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /*cette classe est le coeur du programme */
    class Start
    {
        public void Starter ()
        {
            Scenario sn = new Scenario();
            Personnage p1 = new Personnage();
            Monstre m1 = new Monstre();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\introMusic.wav";

            
            player.Play();
            sn.CreationPerso(p1);
            Console.Clear();

         
            Console.WriteLine("Vous entrez dans un sombre donjon ... vous vous avancez sans faire de bruit quand soudain ..");
            Console.ReadLine();
            sn.Combat(p1, m1);
            Console.Clear();

            Console.WriteLine("Après votre triomphe sur le monstre, vous poursuivez votre chemin dans les ténèbres" +
                " du donjon ...");
            Console.ReadLine();
            Console.WriteLine("Aie ! Deux chemin se présentent devant vous, le quel choisir ? ");

            int rep1 = 0;
            while (rep1 <= 0 || rep1 > 2)
            {

                Console.WriteLine(
                    "1 : Droite \n" +
                    "2 : Gauche \n" );

                rep1 = Int32.Parse(Console.ReadLine());

            }

            if (rep1 == 1)
            {
                Console.WriteLine("vous prenez le chemin de droite ... vous faites face a un mur avec une inscription " +
                    "dessus ...");
                Console.WriteLine("Vous lisez l'inscription : 'Réponds a la question suivante pour poursuivre ton chemin !'");
                sn.Quiz1(p1);

            }
            else
            {
                Console.WriteLine("vous prenez le chemin de gauche ... vous faites face a un mur avec une inscription " +
                "dessus ...");
                Console.WriteLine("Vous lisez l'inscription : 'Réponds a la question suivante pour poursuivre ton chemin !'");
                sn.Quiz2(p1);

            }

            Console.ReadLine();
            Console.WriteLine("Le mur tremble et un passage s'ouvre devant vous ! Vous vous précipitez vers la sortie ...");
            Console.WriteLine("Féliciatation ! Vous venez de sortir du donjon ^_^ Vous venez de perdre 2 minutes de votre vie !" +
                " Have a nice Day <3 \n ******************************The End******************************");
            Console.ReadLine();

        }

    }
}
