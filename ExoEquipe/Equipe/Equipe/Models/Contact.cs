using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Equipe.Models
{
    internal class Contact
    {
        // Variable
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public char Sex { get; set; }
        public string TelephonePortable { get; set; }
        public string TelephoneFixe { get; set; }
        public string AdresseMail { get; set; }
        public string AdressePostale { get; set; }


        // Constructeur
        public Contact(int id, string nom, string prenom, DateTime dateDeNaissance, char sex,
            string telephonePortable, string telephoneFixe, string adresseMail, string adressePostale)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            DateDeNaissance = dateDeNaissance;
            Sex = sex;
            TelephonePortable = telephonePortable;
            TelephoneFixe = telephoneFixe;
            AdresseMail = adresseMail;
            AdressePostale = adressePostale;
        }

        // Fonction

        public void créer()
        {
            SqlConnection con = null;
            try
            {
                // Creation de la connexion
                con = new SqlConnection("data source=51.79.69.136,1433; database=ExoTestCoco; User ID = coco; Password = cocoPassEw0rd!");
               
                // la requete sql
                string requete = string.Format("INSERT INTO Contact (Id, Nom, Prenom, DateDeNaissance, Sex, TelephonePortable, TelephoneFixz, AdresseMail, AdressePostale) " +
                    "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}', '{8}')", Id, Nom, Prenom, DateDeNaissance, Sex, TelephonePortable, TelephoneFixe, AdresseMail, AdressePostale);

                SqlCommand cm = new SqlCommand(requete, con);
                // Ouvrir la connexion  
                con.Open();
                // Executer la requete  
                cm.ExecuteNonQuery();
                Console.WriteLine("Ligne inseree");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs,Erreur" + e);
            }
            // Fermer la connexion  
            finally
            {
                con.Close();
            }
        }
    }
}
