using MentoringLLC.Interfaces;
using MentoringLLC.Pages;
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
using MentoringLLC.Pages;

namespace MentoringLLC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow instance; 
        
        public MainWindow()
        {
            NavigateToLoginPage();
            instance = this;
            mainWindowFrame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
            NavigateToLoginPage();
        }

        private void NavigateToLoginPage()
        {
            mainWindowFrame.Content = new Einstellungen();
            sideBarFrame.Content = new Sidebar();
        }
    }
}
