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

namespace PPE.Pages.Thème
{
    /// <summary>
    /// Interaction logic for AjoutTheme.xaml
    /// </summary>
    public partial class AjoutTheme : UserControl
    {
        public AjoutTheme()
        {
            InitializeComponent();
        }

        private void button_Valider_Click(object sender, RoutedEventArgs e)
        {
            theme newtheme = new theme { Intutile = textBox_NomTheme.Text };
            Controller.ThemeDAO.addtheme(newtheme);

        }
    }
}
