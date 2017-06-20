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
using FirstFloor.ModernUI.Windows.Controls;

namespace PPE.Pages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        public ModernWindow window = App.Current.MainWindow as ModernWindow;
        public FirstFloor.ModernUI.Presentation.LinkGroup aremove0 = (App.Current.MainWindow as ModernWindow).MenuLinkGroups.ElementAt(0);
        public FirstFloor.ModernUI.Presentation.LinkGroup aremove1 = (App.Current.MainWindow as ModernWindow).MenuLinkGroups.ElementAt(1);
        public FirstFloor.ModernUI.Presentation.LinkGroup aremove2 = (App.Current.MainWindow as ModernWindow).MenuLinkGroups.ElementAt(2);
        public FirstFloor.ModernUI.Presentation.LinkGroup aremove3 = (App.Current.MainWindow as ModernWindow).MenuLinkGroups.ElementAt(3);
        public FirstFloor.ModernUI.Presentation.LinkGroup aremove4 = (App.Current.MainWindow as ModernWindow).MenuLinkGroups.ElementAt(4);
        public Home()
        {
            InitializeComponent();
            window.MenuLinkGroups.Remove(aremove1);
            window.MenuLinkGroups.Remove(aremove2);
            window.MenuLinkGroups.Remove(aremove3);
            window.MenuLinkGroups.Remove(aremove4); 
            //
        }

        private void TextBox_Login_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox_Login.Text = "";
        }

        private void button_connect_Click(object sender, RoutedEventArgs e)
        {
            
            PPE4Entities db = new PPE4Entities();    
            if (db.administrateurs.Any(x => x.Login == TextBox_Login.Text && x.Password == PasswordBox.Password))
            {
                MessageBox.Show("Bienvenue");
                window.MenuLinkGroups.Remove(aremove0);
                window.MenuLinkGroups.Add(aremove1);
                window.MenuLinkGroups.Add(aremove2);
                window.MenuLinkGroups.Add(aremove3);
                window.MenuLinkGroups.Add(aremove4);
            }
            else
            {
                MessageBox.Show("Utilisateur inconnu");
            }



        }
    }
}
