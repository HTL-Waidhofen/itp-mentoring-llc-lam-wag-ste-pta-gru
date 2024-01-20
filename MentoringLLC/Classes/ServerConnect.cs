using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
            if (Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count) is string)
                UserList.Add(new User(Encoding.UTF8.GetString(e.Data.Array)));

            Console.WriteLine($"{Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count)}");

        }

    }
}
