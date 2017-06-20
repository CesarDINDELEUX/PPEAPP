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
    /// Interaction logic for CommentaireQuizz.xaml
    /// </summary>
    public partial class CommentaireQuizz : UserControl
    {
        public CommentaireQuizz()
        {
            InitializeComponent();
            listView_ComQuizz.ItemsSource = Controller.CommentaireQuizzDAO.List();
            listView_ComQuizz.Items.Refresh();
        }

        private void button_SupprimerCom_Click(object sender, RoutedEventArgs e)
        {
            Button bouton = (Button)sender;
            Controller.CommentaireQuizzDAO.Delete((PPE.commentaire__quizz)bouton.DataContext);
            listView_ComQuizz.ItemsSource = null;
            listView_ComQuizz.Items.Clear();
            listView_ComQuizz.ItemsSource = (Controller.CommentaireQuizzDAO.List());
            listView_ComQuizz.Items.Refresh();
        }
    }
}
