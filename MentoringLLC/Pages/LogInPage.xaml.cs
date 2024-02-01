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
using System.Windows.Shapes;
using System.IO;
using MentoringLLC.Classes;

namespace MentoringLLC.Pages
{
    /// <summary>
    /// Interaktionslogik für LogInPage.xaml
    /// </summary>
    public partial class LogInPage : Page
    {
        public bool UsedUsernameBox { get; set; }
        public bool UsedPasswordBox { get; set; }
        
        
        public LogInPage()
        {
            InitializeComponent();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = System.IO.Path.Combine("Pages", "Resources", "WPFMentor.mp4");
            string dynamicPath = System.IO.Path.Combine(baseDirectory, relativePath);
            Background.Source = new Uri(dynamicPath);
        }

        private void SignUpButton(object sender, RoutedEventArgs e)
        {
            MainWindow.instance.Content = new Pages.SignUpPage(UsedUsernameBox, UsedPasswordBox, UsernameBox.Text, HiddenPasswordBox.Password);
        } 
        private void LogInButton(object sender, RoutedEventArgs e)
        {
            LogIn();
        }
        private void Username(object sender, RoutedEventArgs e)
        {
            UsernameBox.Text = string.Empty;
            UsedUsernameBox = true;
        }
        private void Password(object sender, RoutedEventArgs e)
        {
            HiddenPasswordBox.Visibility = Visibility.Visible;
            PasswordTextBox.Visibility = Visibility.Hidden;
            HiddenPasswordBox.Focus();
            UsedPasswordBox = true;
        }
        private void LogIn()
        {
            // Implement check here
            User user = new User();
            user = SqliteDataAccess.GetUserbyUsername(UsernameBox.Text);
            if (user.Username == null)
                user = SqliteDataAccess.GetUserbyEmail(UsernameBox.Text);
            if (user.Username == null)
                return;

            if (user.Password == HiddenPasswordBox.Password)
            {
                MainWindow.instance.Content = new Pages.Dashboard(user);
            }
        }
    }
}
