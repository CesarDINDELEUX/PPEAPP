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
    /// Interaction logic for AjoutEnquete.xaml
    /// </summary>
    public partial class AjoutEnquete : UserControl
    {
        public AjoutEnquete()
        {
            InitializeComponent();
            combo_theme.ItemsSource = Controller.ThemeDAO.List();
            listView_Sequence.ItemsSource = (App.Current as App).listeseq;
            
        }
        private void OnLoad(object sender, RoutedEventArgs e)
        {
            listView_Sequence.ItemsSource = (App.Current as App).listeseq;
            listView_Sequence.Items.Refresh();
        }

        private void textBox_Nom_GotFocus(object sender, RoutedEventArgs e)
        {
          //  textBox_Nom.Text = "";
        } 

        private void button_AjoutSequence_Click(object sender, RoutedEventArgs e)
        {
            listView_Sequence.ItemsSource = null;
            listView_Sequence.Items.Clear();
            listView_Sequence.Items.Refresh();
            (App.Current as App).newsequence = new sequence();    
        }

        private void button_Valider_Click(object sender, RoutedEventArgs e)
        {
            theme letheme = combo_theme.SelectedItem as PPE.theme;
            int idtheme = letheme.id;
            PPE.enquete newEnquete = new PPE.enquete { Intitule = textBox_Nom.Text,theme_id = idtheme };
            foreach (var item in (App.Current as App).listeseq)
            {
                newEnquete.sequences.Add(item);
            }     
            Controller.EnqueteDAO.Add(newEnquete);
            textBox_Nom.Text = "";
            (App.Current as App).listeseq.Clear();

        }
        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            
        }
     //   private void button_modify_Click(object sender, RoutedEventArgs e)
     //   {
     //    Button btn = (Button)sender;
     //    (App.Current as App).newsequence = (sequence)btn.DataContext;
     //   }


        private void isenable()
        {
            /*if (globseq.Count != 0 || textBox_Nom.Text != "")
            {
             //   button_Valider.IsEnabled = true;
            }*/
        }
        private void textBox_Nom_TextChanged(object sender, TextChangedEventArgs e)
        {
           // isenable();
        }

        private void comboBox_SousTheme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
