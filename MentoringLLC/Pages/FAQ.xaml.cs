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
    /// Interaktionslogik für FAQ.xaml
    /// </summary>
    public partial class FAQ : Page
    {
        public FAQ()
        {
            InitializeComponent();
        }

        private void fill_lBox(List<string> Data)
        {
            foreach(string s in Data)
            {
                listbQuestions.Items.Add(s);
            }
        }
        private void OpenQuestions(object sender, MouseButtonEventArgs e)
        {
            int index= listbQuestions.SelectedIndex;

            //Hier Code schreiben der die Info aus der Datenbank ausliest

            MessageBox.Show("Hier wird die Antwort ausgegeben");
        }
    }
}
