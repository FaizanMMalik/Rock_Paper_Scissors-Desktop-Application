using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace consoleprj
{
    class user
    {
        public TcpClient client { get; set; }
        public string name { get; set; }
        public int player { get; set; }
    }
    class Program
    {
        static List<user> lclient = new List<user>();
        static List<user> clist = new List<user>();

        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(9267);
            server.Start();
            int user = 0;
            while (true)
            {
                if (lclient.Count < 2)
                {
                    TcpClient client = server.AcceptTcpClient();
                    user++;
                    lock (lclient)
                    {
                        user u = new user();
                        u.player = user;
                        u.client = client;
                        lclient.Add(u);
                    }
                    BinaryFormatter bf = new BinaryFormatter();
                    if (lclient.Count == 2)
                    {
                        foreach (user us in lclient)
                        {
                            Console.WriteLine(us.player);
                            bf.Serialize(us.client.GetStream(), us.player);
                            //byte[] datafromserver = new byte[10];
                            //datafromserver = Encoding.ASCII.GetBytes(us.player.ToString());
                            //us.client.GetStream().Write(datafromserver, 0, datafromserver.Length);
                          
                        }
                    }
                    new Thread(() => readsend(client)).Start();
                    //new Thread(() => HandleClient(client)).Start();
                }            
            }
        }
        //public static void HandleClient(TcpClient cl)
        //{
        //    string cmsg, name;
        //    NetworkStream ns = cl.GetStream();
        //    BinaryFormatter fobj = new BinaryFormatter();
        //    name = (String)fobj.Deserialize(ns);
        //    user newClient = new user();
        //    newClient.client = cl;
        //    newClient.name = name;

        //    lock (clist)
        //    {
        //        clist.Add(newClient);
        //    }
        //    cmsg = name + "has joined ! ";
        //    while (true)
        //    {
        //        new Thread(() => Broadcast(cmsg, newClient)).Start();
        //        cmsg = (String)fobj.Deserialize(ns);
             
        //    }

        //}
        //public static void Broadcast(string msg, user sender)
        //{
        //    BinaryFormatter fobj = new BinaryFormatter();
        //    foreach (user cl in clist)
        //    {
        //        if (cl != sender)
        //        {
        //            fobj.Serialize(cl.client.GetStream(), msg);
                   
        //        }
        //    }
        //}
        public static void readsend(TcpClient client)
        {
            BinaryFormatter bf = new BinaryFormatter();
            string msg = "";
            while (true)
            {
                msg = (string)bf.Deserialize(client.GetStream());
                foreach (user u in lclient)
                {
                    if (!u.client.Equals(client))
                    {
                        Console.WriteLine(msg);
                        bf.Serialize(u.client.GetStream(), msg);
                        //byte[] datafromserver = new byte[10];
                        //datafromserver = Encoding.ASCII.GetBytes(msg);
                        //u.client.GetStream().Write(datafromserver, 0, datafromserver.Length);
                        FileStream f = new FileStream("F:\\prjtxt.txt", FileMode.Append, FileAccess.Write);
                        StreamWriter sw;
                        sw = new StreamWriter(f);
                        string m = "\n" +msg + "\n";
                        sw.Write(m);
                        sw.Close();
                        f.Close();

                    }
                }

            }
        }
    }
}
