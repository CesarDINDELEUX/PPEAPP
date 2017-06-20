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
    /// Interaction logic for AjoutQuizz.xaml
    /// </summary>
    public partial class AjoutQuizz : UserControl
    {
        public AjoutQuizz()
        {
            InitializeComponent();
            
            button_AjoutReponse.IsEnabled = false;
            button_AjoutQuestion.IsEnabled = false;
            button_Ajouter.IsEnabled = true;
            button_Valider.IsEnabled = true;
        }
        public quizz quizz22;

        public static PPE4Entities db = new PPE4Entities();

        public static List<reponse__quizz> R = new List<reponse__quizz>();
        public static List<question__quizz> Q = new List<question__quizz>();

        #region Fonction BoutonEnable
        private void BoutonEnableA()
        {
        /*    if(listView_Question.Items.Count == 1 || R == null)
            {
                button_Ajouter.IsEnabled = false;
            }
            else
            {
                button_Ajouter.IsEnabled = true;
            }*/
        }

        private void BoutonEnableQ()
        {
            if(textBox_Question.Text == "")
            {
                button_AjoutQuestion.IsEnabled = false;
            }
            else
            {
                button_AjoutQuestion.IsEnabled = true;
            }
        }

        private void BoutonEnableR()
        {
            if (textBox_Reponse.Text == "")
            {
                button_AjoutReponse.IsEnabled = false;
            }
            else
            {
                button_AjoutReponse.IsEnabled = true;
            }
        }

        private void BoutonEnableV()
        {       
             /* if (R == null)
              {
                 button_Valider.IsEnabled = false;
              }
              else
              {
                button_Valider.IsEnabled = true;
              }*/
        }
        #endregion

        private void textBox_Nom_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox_Nom.Text = "";
        }

        private void button_AjoutReponse_Click(object sender, RoutedEventArgs e)
        {
            var reponse = new reponse__quizz { Intitule = textBox_Reponse.Text };
            R.Add(reponse);
            listView_Reponse.ItemsSource = R;
            listView_Reponse.Items.Refresh();
        }

        private void button_AjoutQuestion_Click(object sender, RoutedEventArgs e)
        {
            var question = new question__quizz { Intitule = textBox_Question.Text };
            Q.Add(question);
            listView_Question.ItemsSource = Q;
            listView_Question.Items.Refresh();
        }

        private void button_Valider_Click(object sender, RoutedEventArgs e)
        {
            quizz22 = new quizz { Intitule = textBox_Nom.Text };
            Controller.QuizzDAO.Add(quizz22);
            MessageBox.Show("Votre quizz a été ajouté, il reste modifiable en cas d'erreur de saisie");
            foreach (var itemz in listView_Question.Items)
            {
                var question = new question__quizz { Intitule = (itemz as question__quizz).Intitule };
                foreach (var r in listView_Reponse.Items)
                {
                    var reponse = new reponse__quizz { Intitule = (r as reponse__quizz).Intitule};
                }
                foreach (var item in Q)
                {
                    Controller.QuestionQuizzDAO.Add(question);
                    foreach (var items in R)
                    {
                        items.question__quizz = question;
                        Controller.ReponseQuizzDAO.Add(items);
                    }
                }
            }
        }

        private void button_Ajouter_Click(object sender, RoutedEventArgs e)
        {
            var question = new question__quizz { Intitule = listView_Question.Items.ToString() };
            question.quizz = quizz22;
            Controller.QuestionQuizzDAO.Add(question);
            foreach (var item in R)
            {
                item.question__quizz = question;
                Controller.ReponseQuizzDAO.Add(item);                         
            }
        }

        #region EnableBouton


        private void textBox_Question_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoutonEnableQ();
           // BoutonEnableA();
        }

        private void textBox_Reponse_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoutonEnableR();
          //  BoutonEnableA();
        }

        private void textBox_Nom_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoutonEnableV();
        }

        #endregion

    }
}
