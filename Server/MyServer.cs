using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class MyServer
    {
        TcpListener server = null;
        NetworkStream stream = null;
        StreamReader streamReader = null;
        StreamWriter streamWriter = null;
        public static List<String> clientsList = new List<string>();

        public MyServer()
        {
            Thread thread = new Thread(new ThreadStart(run));
            thread.Start();
        }
        public void sendInt(int val)
        {
            streamWriter.WriteLine(Convert.ToString(val));
            streamWriter.Flush();
        }

      

        public void receiveInt()
        {
            int val = Convert.ToInt32(streamReader.ReadLine());
            Console.WriteLine(val);
        }

        public static String getStirngClientList()
        {
            String stringClientsList = "";

            foreach (string client in clientsList)
            {
                stringClientsList += client;
                stringClientsList += " ";
            }

            return stringClientsList.Trim();
        }

       
        void run()
        {
            server = new TcpListener(8000);
            server.Start();

            while (true)
            {

                TcpClient clientSocket = server.AcceptTcpClient();
                new ServerThread(clientSocket);
            }
        }
    }

}
