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
    /// Interaktionslogik für SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Page
    {
        public bool LI_UsedUsernameBox { get; set; }
        public bool LI_UsedPasswordBox { get; set; }

        public string LI_UsernameEmailContent { get; set; }
        public string LI_PasswordContent { get; set; }




        public SignUpPage(bool Temp_LI_UsedUsernameBox, bool Temp_LI_UsedPasswordBox, string Temp_LI_UsernameEmailContent, string Temp_LI_PasswordConten)
        {
            LI_UsedUsernameBox = Temp_LI_UsedUsernameBox;
            LI_UsedPasswordBox = Temp_LI_UsedPasswordBox;
            LI_UsernameEmailContent = Temp_LI_UsernameEmailContent;
            LI_PasswordContent = Temp_LI_PasswordConten;



            InitializeComponent();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = System.IO.Path.Combine("Pages", "Resources", "WPFMentor.mp4");
            string dynamicPath = System.IO.Path.Combine(baseDirectory, relativePath);
            Background.Source = new Uri(dynamicPath);

            if (LI_UsedUsernameBox)
            {
                UsernameBox.Text = string.Empty;
            }
            if (LI_UsedPasswordBox)
            {
                HiddenPasswordBox.Visibility = Visibility.Visible;
                PasswordTextBox.Visibility = Visibility.Hidden;
            }
            if (LI_UsedPasswordBox)
            {
                HiddenPasswordBox.Password = LI_PasswordContent;
            }


            if (LI_UsernameEmailContent.Contains("@") && LI_UsedUsernameBox)
            {
                EmailBox.Text = LI_UsernameEmailContent;
            }
            else if (LI_UsedUsernameBox)
            {
                UsernameBox.Text = LI_UsernameEmailContent;
            }
        }
        private void SignUpButton(object sender, RoutedEventArgs e)
        {
            SignUp();
        }

        private void Username(object sender, RoutedEventArgs e)
        {
            if (!LI_UsedUsernameBox)
            UsernameBox.Text = string.Empty;
        }
        private void Password(object sender, RoutedEventArgs e)
        {

            if (!LI_UsedPasswordBox) { 
            HiddenPasswordBox.Visibility = Visibility.Visible;
            PasswordTextBox.Visibility = Visibility.Hidden;
            HiddenPasswordBox.Focus();
            }
        }
        private void PasswordConfirm(object sender, RoutedEventArgs e)
        {
            HiddenPasswordConfirmBox.Visibility = Visibility.Visible;
            PasswordConfirmTextBox.Visibility = Visibility.Hidden;
            HiddenPasswordConfirmBox.Focus();
        }
        private void EMail(object sender, RoutedEventArgs e)
        {
            if (!(LI_UsernameEmailContent.Contains("@") && LI_UsedUsernameBox))
            EmailBox.Text = string.Empty;
        }
        private void SignUp()
        {           
            User user = new User();

           

            if (UsernameBox.Text != string.Empty && HiddenPasswordBox.Password == HiddenPasswordConfirmBox.Password && EmailBox.Text.Contains('@'))
            {
                user.Username = UsernameBox.Text;
                user.Password = PasswordTextBox.Text;
                user.Email = EmailBox.Text;
                SqliteDataAccess.AddUser(user);


                if (user.IsAdmin == 1)
                    MainWindow.instance.mainWindowFrame.Content = new Pages.Admin.ban_User();
                else
                    MainWindow.instance.mainWindowFrame.Content = new Pages.Dashboard(user);
            }
            else
                MessageBox.Show("Inkorrekt Eingabe");
        }
    }
}