using MentoringLLC.Pages;
using MentoringLLC.Interfaces;
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

namespace MentoringLLC.Interfaces
{
    /// <summary>
    /// Interaktionslogik für Sidebar.xaml
    /// </summary>
    public partial class Sidebar : Page
    {
        public Sidebar()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)//Profil
        {
            MainWindow.instance.Content = new Profilviewer();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)//Termine
        {
           // MainWindow.instance.Content = new Termine();
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)//Chat
        {
           // MainWindow.instance.Content = new Chat();
        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)//Add (?)
        {
            MainWindow.instance.Content = new TerminErstellen();
        }

        private void Image_MouseDown_4(object sender, MouseButtonEventArgs e)//Settings
        {
            MainWindow.instance.Content = new Einstellungen();
        }

        private void Image_MouseDown_5(object sender, MouseButtonEventArgs e)//Exit
        {
            Environment.Exit(7);
        }

        private void Image_MouseDown_6(object sender, MouseButtonEventArgs e)//Help
        {
            MainWindow.instance.Content = new FAQ();
        }
    }
}
