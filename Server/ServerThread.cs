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
    class ServerThread
    {
        TcpListener server = null;
        NetworkStream stream = null;
        StreamReader streamReader = null;
        StreamWriter streamWriter = null;

        public ServerThread(TcpClient clientSocket) // de mutat in alta clasa? pe constructorul clasei se porneste alt fir - receive - send 
        {
            Thread thread = new Thread(new ThreadStart(run));
            thread.Start();

            stream = clientSocket.GetStream();
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);
           
        }

        void run()
        {

            receiveName();

            while (true)
            {

               
            }
        }

        public void receiveName()
        {
            String name;
            Boolean invalideName = true;

            while (invalideName)
            {
                name = streamReader.ReadLine();

                if (MyServer.clientsList.Contains(name))
                {
                    sendString("**invalidename");

                }
                else
                {
                    MyServer.clientsList.Add(name);
                    sendString(MyServer.getStirngClientList());
                    invalideName = false;
                }
            }
        }

        public void sendString(String message)
        {
            streamWriter.WriteLine(message);
            streamWriter.Flush();
        }


    }
}
