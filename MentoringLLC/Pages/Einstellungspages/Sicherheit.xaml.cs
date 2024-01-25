﻿using System;
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

namespace MentoringLLC.Pages.Einstellungspages
{
    /// <summary>
    /// Interaktionslogik für Sicherheit.xaml
    /// </summary>
    public partial class Sicherheit : Page
    {
        public Sicherheit()
        {
            InitializeComponent();
        }
        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            MainWindow.instance.Content = new Profil();
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {

            MainWindow.instance.Content = new Erscheinung();
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {

            MainWindow.instance.Content = new Sicherheit();
        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {

            MainWindow.instance.Content = new MentorSettings();
        }
    }
}
