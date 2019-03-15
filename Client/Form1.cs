using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        MyClient client;

        public Form1()
        {
            InitializeComponent();
        }

        public static void debug(String text)
        {
            MessageBox.Show(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBoxName.Text;
        
            client = new MyClient();
            client.form = this;

            client.sendName(name);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.logout();
        }
    }
}
