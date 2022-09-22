using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo
{
    internal class Voiture
    {
        //Variables : visibilité type de retour nomVarible { get; set;}
        public string Marque { get; set; }
        public string Model { get; set; }
        public int VitesseMax { get; set; }
        public string Couleur { get; set; }

        /*Constructeur : visibilité nomDeLaClass au dessus (paramètre)
        {
            nomValeur (ayant le nom du parametre) = paramètre;
        }
        */

        public Voiture()
        {

        }
        public Voiture(string marque, string model, int vitesseMax, string couleur)
        {
            Marque = marque;
            Model = model;
            VitesseMax = vitesseMax;
            Couleur = couleur;
        }

        /*Fonction : visibilité - type de retour - nomFonction (paramètre)
        {
        instruction
        }
        */
        public void affiche ()
        {
            Console.WriteLine("Marque de la voiture : " + Marque + ", modèle de la voiture : " + Model + ", vitesse max de la voiture : " + VitesseMax + "Km/h, couleur de la voiture : " + Couleur + ".");
        }

    }
}
