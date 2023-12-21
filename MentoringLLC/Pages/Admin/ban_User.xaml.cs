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
    /// Interaktionslogik für ban_User.xaml
    /// </summary>
    public partial class ban_User : Page
    {
        public ban_User()
        {
            InitializeComponent();
        }

        private void UserSearch_TextInput(object sender, TextCompositionEventArgs e)
        {
            if (UserSearch.Text.Length==0)
            {
               //Alle User werden in der Textbox angezeigt
            }
            else
            {
                //all User mit dieser Buchstabenreihenfolge werden in der LB angezeigt
            }
        }
    }
}
