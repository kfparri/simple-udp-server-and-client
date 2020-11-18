using System;

namespace udp_client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the destination IP: ");
            var ip = Console.ReadLine();

            Console.Write("Port Number: ");
            var port = Console.ReadLine();

            UDPSocket c = new UDPSocket();
            c.Client(ip, Convert.ToInt32(port));
            c.Send("Client Started up!");

            while(true)
            {
                var result = Console.ReadLine();
                c.Send(result);
            }

            
        }
    }
}
