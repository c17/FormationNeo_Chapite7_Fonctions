﻿using System;

/* Il est temps de créer un système de localisation pour les héros.
 * L'idée est de localiser un héros ou qu'il soit, sur terre ou dans la mer!
*/

namespace FormationNeo_Chapite7_Fonctions_Solution3
{
    class Exo3Ch7Solution
    {
        static void Main(string[] args)
        {
            // Nous allons imaginer qu'une grille de 10 casses par 10 représente la Terre
            // Un héro est placé aléatoirement sur cette grille, ces coordonnées varient donc
            // entre (0, 0) et (9, 9).
            // La première coordonnée est sur l'axe Nord-Sud (Nord = 0, Sud = 9), la seconde sur l'axe Est-Ouest (Est = 0, Ouest = 9)
            // Votre mission est de demander à l'utilisateur une série de coordonnées,
            // puis de lui annoncer si le héro est plus au Nord, à l'Est, au Sud ou à l'Ouest.
            // Quand une coordonnée est bonne, il faut aussi le lui annoncer.
            // Quand l'utilisateur trouve les deux coordonnées, il faut lui annoncer qu'il à 
            // trouvé un héro!
            //
            // Compléter la fonction radar pour trouver le héro!
            //
            // Bonus : Modifier le code pour créer une grille de 100 par 100 (et modifier les
            // coordonnées iniiales en conséquences), puis rajouter des indices pour aider
            // l'utilisateur!

            var rnd = new Random();
            int heroCoordX = rnd.Next(0, 9); // nombre aléatoire entre 0 et 9
            int heroCoordY = rnd.Next(0, 9);

            // Ligne pour tester les coordonnées
            //Console.WriteLine("Debug en (" + heroCoordX + ", " + heroCoordY + ")");

            int userCoordX = 0;
            int userCoordY = 0;
            bool enRecherche = true;

            Console.WriteLine("En recherche d'un héro... [LOADING]...");
            while (enRecherche)
            {
                Console.WriteLine('\n' + "Coordonnée en X: ");
                int.TryParse(Console.ReadLine(), out userCoordX);
                Console.WriteLine("Coordonnée en Y: ");
                int.TryParse(Console.ReadLine(), out userCoordY);

                Console.WriteLine("Recherche en (" + userCoordX + ", " + userCoordY + ")");

                if ((userCoordX == heroCoordX) && (userCoordY == heroCoordY)) // Coordonnées exactes
                {
                    enRecherche = false; // On arrète la recherche, on a trouvé
                    Console.WriteLine('\n' + "Héro correctement localisé.");
                }
                else
                {
                    Radar(userCoordX, userCoordY, heroCoordX, heroCoordY);
                }
            }
        }

        static void Radar(int userCoordX, int userCoordY, int heroCoordX, int heroCoordY)
        {
            // Tests sur la première valeur (X)
            TestXCoord(userCoordX, heroCoordX);

            // Tests sur la seconde valeur (Y)
            TestYCoord(userCoordY, heroCoordY);
        }

        static void TestXCoord(int userX, int heroX)
        {
            if (userX == heroX)
                Console.WriteLine("Coordonnée Nord-Sud correcte");
            else if (userX > heroX)
                Console.WriteLine("Plus au Nord!");
            else // (userX < heroX)
                Console.WriteLine("Plus au Sud!");
        }

        static void TestYCoord(int userY, int heroY)
        {
            if (userY == heroY)
                Console.WriteLine("Coordonnée Est-Ouest correcte");
            else if (userY > heroY)
                Console.WriteLine("Plus a l'Est!");
            else // (userY < heroY)
                Console.WriteLine("Plus a l'Ouest!");
        }
    }
}
