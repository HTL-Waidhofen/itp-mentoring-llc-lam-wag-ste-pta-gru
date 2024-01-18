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

        public static void Connect()

        {

            SimpleTcpClient client = new SimpleTcpClient("45.142.114.49:9000");

            // set events

            client.Events.Connected += Connected;

            client.Events.Disconnected += Disconnected;

            client.Events.DataReceived += DataReceived;

            // let's go!

            client.Connect();

            // once connected to the server...

            while (true)

            {

                string consolePath = Console.ReadLine();

                if (consolePath == "")

                    consolePath = " ";

                client.Send(consolePath);

                Console.ReadKey();

            }

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

            Console.WriteLine($"{Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count)}");

        }

    }
}
