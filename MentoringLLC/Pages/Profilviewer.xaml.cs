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
    /// Interaktionslogik für Profilviewer.xaml
    /// </summary>
    public partial class Profilviewer : Page
    {
        public Profilviewer()
        {
            InitializeComponent();
        }
        private void fill_LBoxes(List<string> Data)
        {

            foreach (string s in Data)
                    Faecher.Items.Add(s);

        }
    }
}
