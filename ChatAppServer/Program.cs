using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatAppServer
{
    public class Program
    {
        TcpListener server;
        TcpClient client_socket;
        int port = 2121;
        List<ClientThread> al = new List<ClientThread>();
        NetworkStream stream;


        static void Main(string[] args)
        {
            Program p = new Program();
        }

        public Program()
        {
            start();
        }

        public void start()
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), port);

            server.Start();
            System.Console.WriteLine("Server started.");

            while (true)
            {
                client_socket = server.AcceptTcpClient();
                System.Console.WriteLine("Client connected.");
                stream = client_socket.GetStream();

                ClientThread client = new ClientThread(stream, this);
                al.Add(client);

            }

        }
        class ClientThread
        {
            Program p;
            //StreamReader input;
            //StreamWriter output;
            String username;
            NetworkStream stream;

            public ClientThread(NetworkStream s, Program p)
            {
                stream = s;
                this.p = p;
                Thread t = new Thread(runClient);
                t.Start();
            }

            public List<ClientThread> getList()
            {
                return p.al;
            }

            public String readMessage()
            {
                //byte[] buffer = new byte[16 * 1024];
                //using (MemoryStream ms = new MemoryStream())
                //{
                //    int read;
                //    BinaryReader br = new BinaryReader(stream);
                //    byte size = (byte)br.ReadByte();
                //    while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                //    {
                //        ms.Write(buffer, 0, read);

                //    }

                //}
                //String s = "CLIENT: " + Encoding.ASCII.GetString(buffer);
                //return Encoding.ASCII.GetString(buffer);
                BinaryReader reader = new BinaryReader(stream);
   
                //int size = reader.ReadInt32();

                return (reader.ReadString());
            }
            public void writeMessage(String message)
            {
                //byte[] b = Encoding.ASCII.GetBytes(message);
                //byte size = (byte)b.Length;
                ////byte type = 0;
                ////stream.WriteByte(type);
                //stream.WriteByte(size);

                //stream.Write(b, 0, size);
                BinaryWriter writer = new BinaryWriter(stream);
                writer.Write(message);
            }

            public void runClient()
            {

                //input = new StreamReader(s);
                //output = new StreamWriter(s);
                username = readMessage();

                String online = "Usuarios online: " + username;
                foreach(ClientThread c in getList())
                {
                    online += ", " + c.username;
                    c.writeMessage(username + " conectado!");
                }
                writeMessage(online);

                while (true)
                {

                    String message = readMessage();
                    if (message.Equals("exit"))
                    {
                        foreach (ClientThread c in getList())
                        {
                            if (c.username.Equals(username))
                            {
                                getList().Remove(c);
                                foreach (ClientThread ct in getList())
                                {
                                    ct.writeMessage(username + " desconectado.");
                                }
                                return;
                                
                            }
                                                                                 
                        }
                    }

                    foreach (ClientThread ct in getList())
                    {
                        ct.writeMessage(username + ": " + message);
                    }
                }

            }
        }
    }


}
