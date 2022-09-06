using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Connexion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string idConnexion = "Coca";
        string motDePasse = "Cola";
        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtIdConnexion.Text) || String.IsNullOrWhiteSpace(txtMotDePasseConnexion.Password))
            {
                MessageBox.Show("Merci de renseigner les champs 'Identification' et/ou 'Motde passe'");
            }
            else
            {
                if (txtIdConnexion.Text == idConnexion && txtMotDePasseConnexion.Password == motDePasse)
                {
                    MessageBox.Show("Bonjour,\nMerci de patienter,la connexion est en cours.");

                    PageReservation page = new PageReservation();
                    page.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Les champs 'identification' et ou 'mot de passe' sont incorrecte.\nMerci de resaisir les champs.");
                }
            }   
        }

        private void txtMotDePasseConnexion_KeyDown(object sender, KeyEventArgs e)
        {
           // e.Key = Key.Enter;
        }
    }
}
