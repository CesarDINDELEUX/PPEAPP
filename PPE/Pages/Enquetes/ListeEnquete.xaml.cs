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

namespace PPE.Pages.Enquetes
{
    /// <summary>
    /// Interaction logic for ListeEnquete.xaml
    /// </summary>
    public partial class ListeEnquete : UserControl
    {
        public ListeEnquete()
        {
            InitializeComponent();
              
        }
        private void OnLoad(object sender, RoutedEventArgs e)
        {
            listView_Enquete.ItemsSource = null;
            listView_Enquete.Items.Clear();
            listView_Enquete.ItemsSource = (Controller.EnqueteDAO.List());
        }
     //   private void button_modify_Click(object sender, RoutedEventArgs e)
     //   {
     //       (App.Current as App).enquetemodif = new PPE.enquete();
     //       Button btn = (Button)sender;
     //       (App.Current as App).enquetemodif = ((PPE.enquete)btn.DataContext);
     //   }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Etes-vous sûr de vouloir supprimer cette enquête ?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {


                Button btn = (Button)sender;
                Controller.EnqueteDAO.Delete((PPE.enquete)btn.DataContext);
                listView_Enquete.ItemsSource = null;
                listView_Enquete.Items.Clear();
                listView_Enquete.ItemsSource = (Controller.EnqueteDAO.List());
            }

        }
    }
}
