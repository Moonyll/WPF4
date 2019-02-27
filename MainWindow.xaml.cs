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

namespace WPF4
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         public string name_value { get; set; }
         delegate void Delegate(string str);
         event Delegate Evenement;
         public MainWindow()
         {
         InitializeComponent();
         DataContext = this;
         var phrase = "Bonjour ";
         Evenement += (name_value) => {label.Content = phrase + name_value + " bienvenue !";};
         }
        private void Bouton_Click(object sender, RoutedEventArgs e)
        {
        Evenement(name_value);
        }
    }
}
