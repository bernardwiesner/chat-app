using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatApp
{
    
    public partial class ChatApp : Form
    {
        String username;
        String address;
        int port = 2121;

        //StreamReader input;
        //StreamWriter output;
        NetworkStream stream;
        TcpClient socket;

        public ChatApp()
        {
            InitializeComponent();
            RichTextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            if (buttonConectar.Text.Equals("Conectar"))
            {
                username = textBoxUsuario.Text;
                address = textBoxIP.Text;
                port = Convert.ToInt32(textBoxPuerto.Text);
                System.Console.WriteLine(username);
                ConnectToServer();
                buttonConectar.Text = "Desconectar";
            }
            else
            {
                writeMessage("exit");
               
                richTextBoxOutput.AppendText("\nTe desconectaste.");
                buttonConectar.Text = "Conectar";
            }

        }

        public void ConnectToServer()
        {
            
            richTextBoxOutput.AppendText("Creating socket...\n");
            socket = new TcpClient();
            richTextBoxOutput.AppendText("Connecting to server...\n");
            try
            {
                socket.Connect(address, port);
                richTextBoxOutput.AppendText("Connection established\n");
            }
            catch (SocketException e)
            {
                richTextBoxOutput.AppendText("Connection failed!");
                System.Console.WriteLine(e);
            }
            
             
            stream = socket.GetStream();
            //input = new StreamReader(stream);
            //output = new StreamWriter(stream);

            writeMessage(username);

            Thread t = new Thread(runListener);
            t.Start();

            
        }
        public String readMessage()
        {
            //byte[] buffer = new byte[16 * 1024];
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    int read;
            //    int size = stream.ReadByte();
            //    while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
            //    {
            //        ms.Write(buffer, 0, read);

            //    }

            //}
            //String s = "CLIENT: " + Encoding.ASCII.GetString(buffer);
            //return Encoding.ASCII.GetString(buffer);
            BinaryReader reader = new BinaryReader(stream);
            return(reader.ReadString());
        }
        public void writeMessage(String message)
        {
            //byte[] b = Encoding.ASCII.GetBytes(message);
            int size = message.Length;
            ////int type = 0;
            ////stream.WriteByte((byte)type);
            //stream.WriteByte((byte)size);

            //stream.Write(b, 0, size);
            BinaryWriter writer = new BinaryWriter(stream);
            //writer.Write(size);
            writer.Write(message);
        }

        public void runListener()
        {
            while (true)
            {
                richTextBoxOutput.AppendText("\n> "+readMessage());
                richTextBoxOutput.SelectionStart = richTextBoxOutput.Text.Length;
                richTextBoxOutput.ScrollToCaret();
            }
        }


        private void keyEnter(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                richTextBoxInput.SelectAll();
                String text = richTextBoxInput.SelectedText;
                writeMessage(text);               
                richTextBoxInput.Text = "";

            }
        }
    }

}
