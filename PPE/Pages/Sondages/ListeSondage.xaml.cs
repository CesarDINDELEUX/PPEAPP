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

namespace PPE.Pages.Sondages
{
    /// <summary>
    /// Interaction logic for ListeSondage.xaml
    /// </summary>
    public partial class ListeSondage : UserControl
    {
        public ListeSondage()
        {
            InitializeComponent();
            listView_Sondage.ItemsSource = Controller.SequenceDAO.List();
        }

        private void button_modify_Click(object sender, RoutedEventArgs e)
        {
            Button bouton = (Button)sender;
            (App.Current as App).modifsondage = ((PPE.sondage)bouton.DataContext);
        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            Button bouton = (Button)sender;
            Controller.SondageDAO.Delete((PPE.sondage)bouton.DataContext);
            listView_Sondage.ItemsSource = null;
            listView_Sondage.Items.Clear();
            listView_Sondage.ItemsSource = (Controller.SondageDAO.List());

        }
    }
}
