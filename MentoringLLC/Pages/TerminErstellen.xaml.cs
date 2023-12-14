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

namespace MentoringLLC.Pages
{
    /// <summary>
    /// Interaktionslogik für TerminErstellen.xaml
    /// </summary>
    public partial class TerminErstellen : Page
    {
        public TerminErstellen()
        {
            InitializeComponent();
        }

        private void TitelTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TitelTB.Text.Length == 0)
            {
                HTitel.Visibility = Visibility.Visible;
            }
            else
            {
                HTitel.Visibility = Visibility.Hidden;
            }
        }
    }
}
