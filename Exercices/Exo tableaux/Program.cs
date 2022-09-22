// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




string[] tabNom = new string[7] { "titi", "tata", "tutu", "tete", "tyty", "toto", "tito" };


//prendre chaque element et comparer avec toto 
//si on trouve dire oui 
//sinon dire non 

//tabNom[0] == "toto"
//tabNom[1] == "toto"
//tabNom[2] == "toto"
//    ...
//tabNom[6] == "toto"

//bool totoExiste = false;
int Existe = -1;

for (int index = 0; index < tabNom.Length; index++)
    if (tabNom[index] == "toto")
        //totoExiste = true;
        Existe = 1;
//}

/*if (totoExiste==true)
    { 
    Console.WriteLine("Oui"); 
    }
else
    Console.WriteLine("Non");
*/

if (Existe == 1)
    Console.WriteLine("Oui");
else
    Console.WriteLine("Non");


