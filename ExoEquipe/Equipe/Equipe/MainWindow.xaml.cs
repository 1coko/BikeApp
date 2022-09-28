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
using Equipe.Models;

namespace Equipe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Models.Contact client = new Contact (5, "'LaSaumure'", "'Dido'", 1951 - 12 - 25, "'F'", 96857422)
            {
             
            }

        }

        private void Inscription_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
