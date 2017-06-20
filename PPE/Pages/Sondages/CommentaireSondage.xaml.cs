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
    /// Interaction logic for CommentaireSondage.xaml
    /// </summary>
    public partial class CommentaireSondage : UserControl
    {
        public CommentaireSondage()
        {
            InitializeComponent();
            listView_ComSondage.ItemsSource = Controller.CommentaireSondageDAO.List();
            listView_ComSondage.Items.Refresh();
        }

        private void button_SupprimerCom_Click(object sender, RoutedEventArgs e)
        {
            Button bouton = (Button)sender;
            Controller.CommentaireSondageDAO.Delete((PPE.commentaire__sondage)bouton.DataContext);
            listView_ComSondage.ItemsSource = null;
            listView_ComSondage.Items.Clear();
            listView_ComSondage.ItemsSource = Controller.CommentaireSondageDAO.List();
            listView_ComSondage.Items.Refresh();
        }
    }
}
