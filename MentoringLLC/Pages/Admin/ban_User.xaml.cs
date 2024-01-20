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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using MentoringLLC.Classes;

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
            List<User> users = User.getUserList();
            fill_lBox(users);

        }
        private void fill_lBox(List<User> Data, string searchstrg="")
        {
            
            foreach (User u in Data)
            {
                if(u.Username.Contains(searchstrg)||searchstrg==""||u.Nickname.Contains(searchstrg))
                UserListbox.Items.Add(u);
            }

        }
        private void UserSearch_TextInput(object sender, TextCompositionEventArgs e)
        {
          
            //fill_lBox(test);
            //nick- oder username zum suchen eingeben
            if (UserSearch.Text.Length!=0)
            {
                string searchstrg= UserSearch.Text;
               // fill_lBox(test,searchstrg);

            }
            //else
            //    fill_lBox(test);
            
        }

        private void BUserBan_Click(object sender, RoutedEventArgs e)
        {
            int index=UserListbox.SelectedIndex;
            
            


            //hier code einfügen für is banned, der gebannte User wird dann rot angezeigt
        }

        private void BUserEdit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.instance.Content = new Pages.Admin.Edit_User();
        }

        private void BUserUnban_Click(object sender, RoutedEventArgs e)
        {

            //funktioniert ähnlich wie BUserBan_Click
        }
    }
}
