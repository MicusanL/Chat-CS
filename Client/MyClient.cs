using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    class MyClient
    {
        public Form1 form;
        TcpClient client = null;
        NetworkStream stream = null;
        StreamReader streamReader = null;
        StreamWriter streamWriter = null;
     
        List<String> clientsList = new List<string>();

        public MyClient()
        {
            client = new TcpClient();
            client.Connect("localhost", 8000);
            stream = client.GetStream();
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);

        }

        public void logout()
        {
            stream.Close();
            client.Close();
        }
        public void sendInt(int val)
        {
            streamWriter.WriteLine(Convert.ToString(val));
            streamWriter.Flush();
        }

        public void sendName(String Name)
        {
            streamWriter.WriteLine(Name);
            streamWriter.Flush();
            String response = receiveString();
            Boolean invalideName = true;

            if (response.Equals("**invalidename"))
            {
                
                Form1.debug("invalidename");
               
                
            }
            else
            {
                string[] clients = response.Split(' ');
                foreach (string client in clients)
                {
                    clientsList.Add(client);
                }

                Form1.debug("Good name");

                invalideName = false;
            }

            if(invalideName == false)
            {
                setFormForChat();
            }
        }
        public void receiveInt()
        {
            int val = Convert.ToInt32(streamReader.ReadLine());
            Console.WriteLine(val);
        }

        public String receiveString()
        {
            return streamReader.ReadLine();

        }

        private void setFormForChat()
        {
            form.textBoxName.Hide();
            form.buttonLogin.Hide();
        }
    }
}
