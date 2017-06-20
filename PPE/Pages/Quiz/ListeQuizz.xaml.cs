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

namespace PPE.Pages.Quiz
{
    /// <summary>
    /// Interaction logic for ListeQuizz.xaml
    /// </summary>
    public partial class ListeQuizz : UserControl
    {
        public ListeQuizz()
        {
            InitializeComponent();
            listView_Quizz.ItemsSource = Controller.QuizzDAO.List();
            listView_Quizz.Items.Refresh();       
        }

        private void button_modify_Click(object sender, RoutedEventArgs e)
        {
            Button bouton = (Button)sender;
            (App.Current as App).modifquiz = ((PPE.quizz)bouton.DataContext);
        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            Button bouton = (Button)sender;
            Controller.QuizzDAO.Delete((PPE.quizz)bouton.DataContext);
            listView_Quizz.ItemsSource = null;
            listView_Quizz.Items.Clear();
            listView_Quizz.ItemsSource = (Controller.QuizzDAO.List());
            listView_Quizz.Items.Refresh();
        }
    }
}
