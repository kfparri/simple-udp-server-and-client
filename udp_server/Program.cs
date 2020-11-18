using System;

namespace udp_server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Port to lisen on: ");
            var port = Console.ReadLine();

            UDPSocket s = new UDPSocket();
            s.Server(Convert.ToInt32(port));
            //s.Server("127.0.0.1", 27000);

            Console.ReadKey();
        }
    }
}
