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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MentoringLLC.Pages.Admin
{
    /// <summary>
    /// Interaktionslogik für ban_User.xaml
    /// </summary>
    
    public partial class ban_User : Page
    {
        public ban_User()
        {
            InitializeComponent();

        }
        private void fill_lBox(List<string> Data, string searchstrg="")
        {
            if (searchstrg == "")
            {
                foreach (string s in Data)
                    UserListbox.Items.Add(s);
            }
            else
            {

            }
                
            
        }
        private void UserSearch_TextInput(object sender, TextCompositionEventArgs e)
        {
            //nick- oder username zum suchen eingeben
            if (UserSearch.Text.Length==0)
            {
                string searchstrg= UserSearch.Text;
                

            }
            else
            {
                List<string> test = new List<string>();
                fill_lBox(test);
            }
        }

        private void BUserBan_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BUserEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BUserUnban_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
