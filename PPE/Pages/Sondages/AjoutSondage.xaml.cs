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
    /// Interaction logic for AjoutSondage.xaml
    /// </summary>
    public partial class AjoutSondage : UserControl
    {
        public AjoutSondage()
        {
            InitializeComponent();
            button_Ajouter.IsEnabled = true;
            button_AjoutQuestion.IsEnabled = true;
            button_AjoutReponse.IsEnabled = true;
            button_Valider.IsEnabled = true;
            comboBox_Theme.ItemsSource = (Controller.ThemeDAO.List());
        }
        public PPE.sondage sondage22;
        public static PPE4Entities db = new PPE4Entities();
        public static List<question__sondage> Q;
        public static List<reponse__sondage> R;

        #region Fonction Enable
        private void BoutonEnableA()
        {
            if (listView_Question.Items.Count == 1 || listView_Reponse.Items.Count > 0)
            {
                button_Ajouter.IsEnabled = false;
            }
            else
            {
                button_Ajouter.IsEnabled = true;
            }
        }

        private void BoutonEnableQ()
        {
            if (Q == null)
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
            if(R == null)
            {
                button_AjoutReponse.IsEnabled = false;
            }
            else
            {
                button_AjoutReponse.IsEnabled = true;
            }
        }

        
        #endregion

        private void textBox_Nom_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox_Nom.Text = "";
        }

        private void button_AjoutReponse_Click(object sender, RoutedEventArgs e)
        {
            var reponse = new reponse__sondage { Intitule = textBox_AjoutReponse.Text };
            R.Add(reponse);
            listView_Reponse.ItemsSource = (R);
        }
        
        private void button_Valider_Click(object sender, RoutedEventArgs e)
        {
            sondage22 = new PPE.sondage { Intitule = textBox_Nom.Text };
            db.sondages.Add(sondage22);
            textBox_Nom.Clear();
            textBox_Question.Clear();
            textBox_AjoutReponse.Clear();
            listView_Question.Items.Clear();
            listView_Reponse.Items.Clear();
            MessageBox.Show("Votre sondage a été ajouté, il reste modifiable en cas d'erreur de saisie");
        }

        private void button_AjoutQuestion_Click(object sender, RoutedEventArgs e)
        {
            var question = new question__sondage { Intitule = textBox_Question.Text };
            Q.Add(question);
            listView_Question.ItemsSource = (Q);
        }

        private void button_Ajouter_Click(object sender, RoutedEventArgs e)
        {
            var question = new question__sondage { Intitule = listView_Question.Items.ToString() };
            question.sondage = sondage22;
            db.question__sondage.Add(question);
            foreach (var item in R)
            {
                item.question__sondage = question;
                db.reponse__sondage.Add(item);
                textBox_AjoutReponse.Clear();
            }
        }

        #region Enable
        private void textBox_AjoutReponse_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoutonEnableR();
        }

        private void textBox_Question_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoutonEnableQ();
        }

      /*  private void textBox_Nom_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoutonEnableV();
        }
        private void comboBox_Theme_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            BoutonEnableV();
        }*/
        #endregion
    }
}
