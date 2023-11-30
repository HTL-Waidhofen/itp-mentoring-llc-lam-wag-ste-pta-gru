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
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainWindowframe.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
            NavigateToLoginPage();
        }

        private void NavigateToLoginPage()
        {
            mainWindowframe.Content = new Profilviewer();
        }


    }
}
