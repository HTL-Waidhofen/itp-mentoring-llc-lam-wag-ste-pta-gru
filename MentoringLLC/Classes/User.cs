using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentoringLLC.Pages;

namespace MentoringLLC.Classes
{
    public class User
    {
        public string Username { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public int IsBanned { get; set; }
        public int TimeBanned { get; set; }
        public int UntilBanned { get; set; }
        public int IsAdmin { get; set; }
        public int IsMentor { get; set; }
      

        public User() { }
        public User(string username = "", string email = "",  string password = "", string nickname = "", string bild = "", int banned = 0, int timeBanned = 0, int untilBanned = 0, int admin = 0, int mentor = 0)
            {
                Username = username;
                Nickname = nickname;
                Email = email;
                Password = password;
                Image = bild;
                IsBanned = banned;
                IsAdmin = admin;
                IsMentor = mentor;
                TimeBanned = timeBanned;
                UntilBanned = untilBanned;
            }

        public static List<User> getUserList()
        {
            ServerConnect.client.Send("getAllUsers");
            return ServerConnect.UserList;
            
        }
        public List<User> getUserCensoredList()
        {
            List<User> returnuserList = new List<User>();
            ServerConnect.Connect();

            foreach (var user in ServerConnect.UserList)
            {
                user.Email = "";
                returnuserList.Add(new User());
            }
                
            return returnuserList;
        }


    }
}
