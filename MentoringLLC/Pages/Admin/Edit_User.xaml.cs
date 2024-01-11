using Microsoft.Win32;
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

namespace MentoringLLC.Pages.Admin
{
    /// <summary>
    /// Interaktionslogik für Edit_User.xaml
    /// </summary>
    public partial class Edit_User : Page
    {
        public Edit_User()
        {
            InitializeComponent();
        }

        private void UploadButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == true)
                {
                    ImagePreview.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                    FeedbackMsg.Foreground = Brushes.Green;
                    FeedbackMsg.Text = "Bild erfolgreich hochgeladen";

                }
            }
            catch
            (Exception ex)
            {
                FeedbackMsg.Foreground = Brushes.Red;
                FeedbackMsg.Text = "Bild konnte nicht hochgeladen werden";
            }
           

        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.instance.Content = new Pages.Admin.ban_User();
        }
    }
}

