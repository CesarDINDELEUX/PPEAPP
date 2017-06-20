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
    /// Interaction logic for ModificationSequence.xaml
    /// </summary>
    public partial class ModificationSequence : UserControl
    {
        public ModificationSequence()
        {
            InitializeComponent();
        }
        public void button_ValiderQuestion_Click(object sender, RoutedEventArgs e)
        {
            PPE.question__sequence QS = new question__sequence() { Intitule = textBox_ModifQuestion.Text };
            (App.Current as App).newsequence.question__sequence.Add(QS);
            listView_Question.Items.Add(QS);
            listView_Question.Items.Refresh();
        }

        public void button_ValiderReponse_Click(object sender, RoutedEventArgs e)
        {
            reponse__sequence RS = new reponse__sequence() { Intitule = textBox_ModifReponse.Text };
            listView_Reponse.Items.Add(RS);
            listView_Reponse.Items.Refresh();
        }

        private void button_Valider_Click(object sender, RoutedEventArgs e)
        {
            question__sequence laquestion = listView_Question.Items.GetItemAt(0) as question__sequence;


            foreach (var item in listView_Reponse.Items)
            {
                laquestion.reponse__sequence.Add(item as reponse__sequence);
            }

            (App.Current as App).newsequence.question__sequence.Add(laquestion);
            
        }
    }
}
