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
        TcpClient tcpClient;
        static IList<Thread> thread = new List<Thread>();

        public ServerThread(TcpClient clientSocket)
        {
            stream = clientSocket.GetStream();
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);
            tcpClient = clientSocket;

            //thread.Add(new Thread(new ThreadStart(run)));
            thread.Add( new Thread(() => run(thread.Count)));
            thread[thread.Count - 1].Start();

            
        }

        void run(int id)
        {
            receiveName();

            while (true)
            {
                Console.WriteLine(Thread.GetDomainID());
                String message = streamReader.ReadLine();
                if (message.Equals("**Logout"))
                {
                    return;
                }
            }
        }

        public void receiveName()
        {
            String name;
            Boolean invalideName = true;

            while (invalideName == true)
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
