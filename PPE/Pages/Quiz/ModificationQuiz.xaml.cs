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
    /// Interaction logic for ModificationQuiz.xaml
    /// </summary>
    public partial class ModificationQuiz : UserControl
    {
        public ModificationQuiz()
        {
            InitializeComponent();
        }

        private void button_ModfierQuestion_Click(object sender, RoutedEventArgs e)
        {
            question__quizz qq = new question__quizz() { Intitule = textBox_ModifQuestion.Text };
            (App.Current as App).creationquiz.question__quizz.Add(qq);
            listView_Question.Items.Add(qq);
            listView_Question.Items.Refresh();
        }

        private void button_ModifierReponse_Click(object sender, RoutedEventArgs e)
        {
            reponse__quizz rq = new reponse__quizz() { Intitule = textBox_ModifReponse.Text };
            listView_Reponse.Items.Add(rq);
            listView_Reponse.Items.Refresh();
        }

        private void button_Valider_Click(object sender, RoutedEventArgs e)
        {
            question__quizz question = listView_Question.Items.GetItemAt(0) as question__quizz;
            foreach (var item in listView_Reponse.Items)
            {
                question.reponse__quizz.Add(item as reponse__quizz);
            }
            (App.Current as App).creationquiz.question__quizz.Add(question);
        }
    }
}
