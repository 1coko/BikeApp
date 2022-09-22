// See https://aka.ms/new-console-template for more information
using Exo;
using System.Reflection;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Hello, World!");

//"kia", "Sportage", 175, "Bleu nuit"
//Voiture V = new Voiture();
Voiture V = new Voiture ("Kia", "Sportage",175, "Bleu nuit");
/*V.Marque = "Kia";
V.Model = "Sportage";
V.VitesseMax = 175;
V.Couleur = "Bleu nuit";
*/



V.affiche();


