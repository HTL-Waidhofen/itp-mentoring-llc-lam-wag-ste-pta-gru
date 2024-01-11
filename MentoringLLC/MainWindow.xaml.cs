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

namespace MentoringLLC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow instance;
        public MainWindow()
        {
            InitializeComponent();
            NavigateToLoginPage();
            instance = this;
        }

        private void NavigateToLoginPage()
        {
            mainWindowFrame.Content = new ban_User();
            sideBarFrame.Content = new Sidebar();
        }
    }
}
