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
    /// Interaction logic for ModificationSondage.xaml
    /// </summary>
    public partial class ModificationSondage : UserControl
    {
        public ModificationSondage()
        {
            InitializeComponent();
        }

        private void button_ValiderQuestion_Click(object sender, RoutedEventArgs e)
        {
            question__sondage qs = new question__sondage() { Intitule = textBox_ModifQuestion.Text };
            (App.Current as App).creationsondage.question__sondage.Add(qs);
            listView_Question.Items.Add(qs);
            listView_Question.Items.Refresh();
        }

        private void button_ValiderReponse_Click(object sender, RoutedEventArgs e)
        {
            reponse__sondage rs = new reponse__sondage() { Intitule = textBox_ModifReponse.Text };
            listView_Reponse.Items.Add(rs);
            listView_Reponse.Items.Refresh();
        }

        private void button_Valider_Click(object sender, RoutedEventArgs e)
        {
            question__sondage question = listView_Question.Items.GetItemAt(0) as question__sondage;
            foreach (var item in listView_Reponse.Items)
            {
                question.reponse__sondage.Add(item as reponse__sondage);
            }
            (App.Current as App).creationsondage.question__sondage.Add(question);
        }
    }
}
