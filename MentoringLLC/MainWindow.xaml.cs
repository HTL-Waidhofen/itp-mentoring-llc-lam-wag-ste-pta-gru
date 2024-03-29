using MentoringLLC.Interfaces;
using MentoringLLC.Pages;
using MentoringLLC.Pages.Admin;
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
using MentoringLLC.Pages.Einstellungspages;

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
            
            InitializeComponent();

            instance = this;
            mainWindowFrame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;

            NavigateToLoginPage();
            instance = this;
        }

        public void NavigateToLoginPage()
        {

            FullScreenFrame.Content = new LogInPage();
            
            sideBarFrame.Content = new Sidebar();
        }
    }
}
