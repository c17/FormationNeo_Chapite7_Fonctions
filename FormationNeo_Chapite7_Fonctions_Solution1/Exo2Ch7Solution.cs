﻿
/* Nous allons essayer de nous simplifier la vie grâce aux fonctions!
 * Les notions dont vous avez besoin sont:
 *      --> Les variables
 *      --> Les structures conditionnelles
 *      --> La logique de Boole
 *      --> Les boucles
 * 
 * Commencer par choisir ce projet au démarrage. Pour ce faire, faites un clic droit sur "FormationNeo_Chapitre7_Fonctions_Solution2",
 * et cliquer sur l'icone de roue dentée "Définir comme projet de démarrage"
 * 
 * Utiliser Ctrl + F5 pour compiler et lancer le projet
*/

using System;

namespace FormationNeo_Chapite7_Fonctions_Solution2
{
    class Exo2Ch7Solution
    {
        static void Main(string[] args)
        {
            string nom = "";
            string age = "";

            // Ecrivez une fonction qui affiche "J'aime les poney tout doux." à l'écran
            // qui ne renvoie rien et ne prends pas de paramètres
            // Appelez votre fonction ILovePoney()!
            ILovePoney();

            // Ecrivez une fonction qui affiche votre nom et votre age (vous pouvez mentir)
            // sous la forme "Je m'appel {prénom} et j'ai {age} ans!"
            // On utilisera un age sous la forme d'un string ici pour se simplifier la vie...
            Console.WriteLine("Quel est votre nom ?");
            nom = Console.ReadLine();
            Console.WriteLine("Quel est votre age ?");
            age = Console.ReadLine();

            Presentation(nom, age);

            // Ecriver une fonction ayant le même nom que la fonction précédante mais 
            // qui n'affiche que votre nom (surcharger votre fonction)
            Presentation(nom);

            // Ecrivez une fonction qui soustrait 2 double et qui renvoie le résultat
            // Astuce: pour initialiser un double, utiliser des chiffres à virgules
            //         exemple -> double a = 9.4;
            // Ne mettez pas le "Console.WriteLine(...)" dans votre fonction!
            double a = 9.4;
            double b = 1.85;
            double resultat;
            resultat = Soustraction(a, b);
            Console.WriteLine(a + " - " + b + " = " + resultat);

            // Ecrivez une fonction qui multiplie 2 int et qui renvoie le résultat
            // Appellez cette fonction "Multiplication" 
            Console.WriteLine(Multiplication(3, 17));

            // Ecriver une fonction qui ne prend qu'un int en paramètre mais qui
            // utilise votre fonction "Multiplication" pour renvoier le carré de celui-çi!
            Console.WriteLine(Carre(12));

            // Ecriver une fonction qui affiche toutes les valeurs
            // des carrés des nombres entre 1 et une valeur passée en paramètre
            AfficheCarre(10);

            // Ecrivez une fonction qui prends un age en paramètre et détermine si vous êtes majeur
            // et qui renvoie cette information sous forme de booleen
            // Utiliser la variable ageInt (un int) et pas la variable age (un string)
            int ageInt = 21;
            if (DeterminationMajeur(ageInt)) // ici, on utilise directement le retour du booléen dans une structure de controle!
            {
                Console.WriteLine("Vous êtes majeur");
            }
            else
            {
                Console.WriteLine("Vous êtes mineur");
            }
        }

        // - - - SOLUTION - - - 

        static void ILovePoney()
        {
            Console.WriteLine("J'aime les poney tout doux.");
        }

        static void Presentation(string nom, string age)
        {
            Console.WriteLine("Je m'appel "+ nom +" et j'ai "+ age +" ans!");
        }

        static void Presentation(string nom)
        {
            Console.WriteLine("Je m'appel " + nom + ".");
        }

        static double Soustraction(double a, double b)
        {
            return a - b;
        }

        static int Multiplication(int a, int b)
        {
            return a * b;
        }

        static int Carre(int carre)
        {
            int result;
            result = Multiplication(carre, carre);
            return result;
            // noter que "return Multiplication(carre, carre);" aurait été correct
        }

        static void AfficheCarre(int n)
        {
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(i + " au carré égal " + Carre(i));
            }
        }

        static bool DeterminationMajeur(int age)
        {
            bool estMajeur;
            if (age >= 18)
            {
                estMajeur = true;
            }
            else
            {
                estMajeur = false;
            }
            return estMajeur;
        }
    }
}
