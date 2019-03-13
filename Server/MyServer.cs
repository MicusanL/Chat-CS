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
        static List<String> clientsList = new List<string>();

        public MyServer(TcpClient clientSocket) // de mutat in alta clasa? pe constructorul clasei se porneste alt fir - receive - send 
        {
            stream = clientSocket.GetStream();
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);
            receiveName();
           // stream.Close();
        }

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

        public void sendString(String message)
        {
            streamWriter.WriteLine(message);
            streamWriter.Flush();
        }

        public void receiveInt()
        {
            int val = Convert.ToInt32(streamReader.ReadLine());
            Console.WriteLine(val);
        }

        private String convertClientListToString()
        {
            String stringClientsList = "";

            foreach (string client in clientsList)
            {
                stringClientsList += client;
            }

            return stringClientsList;
        }

        public void receiveName()
        {
            String name;
            Boolean invalideName = true;

            while (invalideName)
            {
                name = streamReader.ReadLine();
                foreach (string client in clientsList)
                {
                    Console.WriteLine(clientsList);
                }
              
                if (clientsList.Contains(name))
                {
                    sendString("**invalidename");

                }
                else
                {
                    clientsList.Add(name);
                    sendString(convertClientListToString());
                    invalideName = false;
                }
            }
        }
        void run()
        {
            server = new TcpListener(8000);
            server.Start();

            while (true)
            {
                TcpClient clientSocket = server.AcceptTcpClient();
                new MyServer(clientSocket);
            }
        }
    }

}
