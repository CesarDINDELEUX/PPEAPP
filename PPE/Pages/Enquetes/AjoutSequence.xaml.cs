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
    /// Interaction logic for AjoutSequence.xaml
    /// </summary>
    public partial class AjoutSequence : UserControl
    {
        question__sequence QS = new question__sequence();
        public reponse__sequence RS = new reponse__sequence();
        public List<reponse__sequence> LRS = new List<reponse__sequence>();
        public List<sequence> LS = new List<sequence>();
        sequence NouvelleSequence = new sequence();
        

        public AjoutSequence()
        {
            InitializeComponent();
            
        }
        private void OnLoad(object sender, RoutedEventArgs e)
        {
            clearChamp();
            var item = new List<reponse__sequence>();
            QS = new question__sequence();
            dgReponses.ItemsSource = item;
            if (NouvelleSequence != (App.Current as App).newsequence)
            {
                NouvelleSequence = (App.Current as App).newsequence;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var itemdg = new List<reponse__sequence>();
            QS = new question__sequence();
            
            if (NouvelleSequence.question__sequence.Count == 0)
            {
                //NouvelleSequence = new sequence();
                NouvelleSequence = (App.Current as App).newsequence;
                NouvelleSequence.Intitule = textBox.Text;
                QS.Intitule = textBox_Question.Text;
                var newrep = new List<reponse__sequence>();
                foreach (var reponse in dgReponses.Items)
                {
                    newrep.Add(reponse as reponse__sequence);
                }
                foreach (var item in newrep)
                {
                    if (item != null)
                    {
                        QS.reponse__sequence.Add(item);
                    }
                }
                NouvelleSequence.question__sequence.Add(QS);
                listView.Items.Add(QS);
                listView.Items.Refresh();
                (App.Current as App).listeseq.Add(NouvelleSequence);
                itemdg = new List<reponse__sequence>();

            }
            else
            {
                QS.Intitule = textBox_Question.Text;
                var newrep = new List<reponse__sequence>();
                foreach (var reponse in dgReponses.Items)
                {
                    newrep.Add(reponse as reponse__sequence);
                }
                foreach (var item in newrep)
                {
                    if (item != null)
                    {
                        QS.reponse__sequence.Add(item);
                    }
                }
                NouvelleSequence.question__sequence.Add(QS);
                listView.Items.Add(QS);
                listView.Items.Refresh();
            }
            dgReponses.ItemsSource = itemdg;
            textBox_Question.Text = "";

        }



        private void button_Valider_Click(object sender, RoutedEventArgs e)
        {

            if (textBox_Question.Text == "" && NouvelleSequence.question__sequence.Count == 0)
            {
                // Si pas de question et que la liste des question est vide, alors bloquer l'envoi
                MessageBox.Show("Refusé, rien n'a été ajouté. Veuillez recommencer");
            }
            else if (textBox_Question.Text != "" && dgReponses.HasItems && !listView.HasItems)
            {

                NouvelleSequence = new sequence();
                NouvelleSequence.Intitule = textBox.Text;
                QS.Intitule = textBox_Question.Text;
                var newrep = new List<reponse__sequence>();
                foreach (var reponse in dgReponses.Items)
                {
                    newrep.Add(reponse as reponse__sequence);
                }
                foreach (var item in newrep)
                {
                    if (item != null)
                    {
                        QS.reponse__sequence.Add(item);
                    }
                }
                NouvelleSequence.question__sequence.Add(QS);
                (App.Current as App).listeseq.Add(NouvelleSequence);
                (App.Current as App).newsequence = new sequence();
                listView.Items.Clear();
                listView.Items.Refresh();
                dgReponses.ItemsSource = null;

            }
            else if (NouvelleSequence.question__sequence.Count > 0 && dgReponses.Items == null)
            {
               
            }
            else if (NouvelleSequence.question__sequence.Count > 0 && dgReponses.Items != null)
            {
                QS = new question__sequence();
                QS.Intitule = textBox_Question.Text;
                var newrep = new List<reponse__sequence>();
                foreach (var reponse in dgReponses.Items)
                {
                    newrep.Add(reponse as reponse__sequence);
                }
                foreach (var item in newrep)
                {
                    if (item != null)
                    {
                        QS.reponse__sequence.Add(item);
                    }
                }
                NouvelleSequence.question__sequence.Add(QS);
                listView.Items.Clear();
                listView.Items.Refresh();
            }
            else if (textBox_Question.Text != "" && dgReponses.HasItems)
            {
                NouvelleSequence = (App.Current as App).newsequence;
                NouvelleSequence.Intitule = textBox.Text;
                QS.Intitule = textBox_Question.Text;
                var newrep = new List<reponse__sequence>();
                foreach (var reponse in dgReponses.Items)
                {
                    newrep.Add(reponse as reponse__sequence);
                }
                foreach (var item in newrep)
                {
                    if (item != null)
                    {
                        QS.reponse__sequence.Add(item);
                    }
                }
                NouvelleSequence.question__sequence.Add(QS);
                listView.Items.Add(QS);
                listView.Items.Refresh();
                (App.Current as App).listeseq.Add(NouvelleSequence);
                (App.Current as App).listeseq.Clear();
                (App.Current as App).newsequence = new sequence();
                listView.Items.Clear();
                listView.Items.Refresh();
                
            }
        }


        private void clearChamp()
        {
            textBox.Text = "";
            textBox_Question.Text = "";
            dgReponses.ItemsSource = null;
            dgReponses.Items.Clear();
        }


    }
}
