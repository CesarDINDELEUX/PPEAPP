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
    /// Interaction logic for ModificationEnquete.xaml
    /// </summary>
    public partial class ModificationEnquete : UserControl
    {
        public ModificationEnquete()
        {
            InitializeComponent();
            textBox_Nom.Text = (App.Current as App).enquetemodif.Intitule;
            listView_Enquete.ItemsSource = (App.Current as App).enquetemodif.sequences;
            combo_theme.ItemsSource = Controller.ThemeDAO.List();
            combo_theme.SelectedValue = (App.Current as App).enquetemodif.theme;
        }

        private void button_Modifier_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OnLoad(object sender, RoutedEventArgs e)
        {
        }

        private void textBox_Nom_GotFocus(object sender, RoutedEventArgs e)
        {
            //  textBox_Nom.Text = "";
        }

        private void button_AjoutSequence_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Valider_Click(object sender, RoutedEventArgs e)
        {
            PPE.enquete newEnquete = new PPE.enquete { Intitule = textBox_Nom.Text, theme = combo_theme.SelectedItem as theme };
            newEnquete.sequences.Add((App.Current as App).newsequence);
            Controller.EnqueteDAO.Add(newEnquete);
        }
        private void button_delete_Click(object sender, RoutedEventArgs e)
        {

        }
        private void button_modify_Click(object sender, RoutedEventArgs e)
        {
            //   Button btn = (Button)sender;
            //   (App.Current as App).newsequence = (sequence)btn.DataContext;

        }


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
    }
}
