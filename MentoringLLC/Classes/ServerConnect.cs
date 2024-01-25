using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using SuperSimpleTcp;

namespace MentoringLLC.Classes
{
    
public class ServerConnect

    {
        public static SimpleTcpClient client = new SimpleTcpClient("45.142.114.49:9000");
        public static List<User> UserList { get; set; }
        public static void Connect()
        {

            // set events

            client.Events.Connected += Connected;

            client.Events.Disconnected += Disconnected;

            client.Events.DataReceived += DataReceived;

            // let's go!

            client.Connect();

            // once connected to the server...

        }

        static void Connected(object sender, ConnectionEventArgs e)

        {

            Console.WriteLine($"*** Server {e.IpPort} connected");

        }

        static void Disconnected(object sender, ConnectionEventArgs e)

        {

            Console.WriteLine($"*** Server {e.IpPort} disconnected");

        }

        static void DataReceived(object sender, DataReceivedEventArgs e)
        {
            string message = Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count);
            List<string> list = message.Split(';').ToList();
            if (list.Count > 0)
            {
                switch (list[0].Trim())
                {
                    case "getUserAnswer":
                        if (list.Count == 2)
                        {
                            User tempUser = JsonConvert.DeserializeObject<User>(list[1].Trim());
                            UserList.Add(tempUser);
                        }
                        break;
                    case "getAllUsersAnswer":
                        if (list.Count == 1)
                        {
                            List<string> allUsers = JsonConvert.DeserializeObject<List<string>>(list[1].Trim());
                            foreach(string s in allUsers)
                            {
                                client.Send($"getUser;{s}");
                            }
                        }
                     break;
                }
                
            }
        }

    }
}
