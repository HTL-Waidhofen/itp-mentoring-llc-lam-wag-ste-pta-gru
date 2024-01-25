using MentoringLLC.Classes;
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

        private void OrtTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (OrtTB.Text.Length == 0)
            {
                HOrt.Visibility = Visibility.Visible;
            }
            else
            {
                HOrt.Visibility = Visibility.Hidden;
            }
        }

        private void TimeTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TimeTB.Text.Length == 0)
            {
                HTime.Visibility = Visibility.Visible;
            }
            else
            {
                HTime.Visibility = Visibility.Hidden;
            }
        }

        private void TeilnehmerTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TeilnehmerTB.Text.Length == 0)
            {
                HTeilnehmer.Visibility = Visibility.Visible;
            }
            else
            {
                HTeilnehmer.Visibility = Visibility.Hidden;
            }
        }

        private void BeschreibungTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (BeschreibungTB.Text.Length == 0)
            {
                HBeschreibung.Visibility = Visibility.Visible;
            }
            else
            {
                HBeschreibung.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = new DateTime();
            
            Termin termin = new Termin(TitelTB.Text,CBFach.Text,int.Parse(TeilnehmerTB.Text),date,OrtTB.Text,BeschreibungTB.Text);

        }
    }
}
