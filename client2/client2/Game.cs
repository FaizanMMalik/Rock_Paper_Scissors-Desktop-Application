using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace client2
{
    public partial class Game : Form

    {
        string name;
        static TcpClient c;
        BinaryFormatter obj;
        string player;
        string mchoice = "";
        public Game()
        {
            InitializeComponent();
        }
        internal void getnameandclient(string n, TcpClient cl)
        {
            c = cl;
            name = n;
            obj = new BinaryFormatter();
        }
        private void Game_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            lblp.Text = "Waiting for another Player";
            btndisable();
            Thread wait = new Thread(waiting);
            wait.Start();
        }
        public void waiting()
        {
            BinaryFormatter bf = new BinaryFormatter();
            byte[] datafromserver = new byte[10];
            NetworkStream ns = c.GetStream();
            ns.Read(datafromserver, 0, datafromserver.Length);
            string msg = Encoding.ASCII.GetString(datafromserver);
            player = msg.Replace("\0", string.Empty);

            lblp.Text = name;
            lblp.Font = new Font("Jokerman", 18);
            lblp.ForeColor = Color.Blue;
            ns.Flush();

            if (player.Equals("1"))
                enabled();
            else
            {
                ns.Read(datafromserver, 0, datafromserver.Length);
                ns.Flush();
                mchoice = Encoding.ASCII.GetString(datafromserver);
                mchoice = mchoice.Replace("\0", string.Empty);
                enabled();
            }
        }
        public string getplayer()
        {
            return (int.Parse(player) - 1).ToString();
        }
        public void send(string result)
        {
            obj.Serialize(c.GetStream(), result);
        }


        public void enabled()
        {
            btnrock.Enabled = btnpaper.Enabled = btnscissor.Enabled = true;

        }
        public void btndisable()
        {
            btnrock.Enabled = btnpaper.Enabled = btnscissor.Enabled = false;

        }
        public void check(string uchoice)
        {
            btndisable();
            if (player.Equals("2"))
            {
                string result1 = "", result2 = "";
                if (uchoice.Equals(mchoice))
                {
                    result1 = "match draw";
                    result2 = "match draw";
                }
                else if (uchoice.Equals("rock") && mchoice.Equals("paper"))
                {
                    result1 = "win";
                    result2 = name + " Loses !";
                }
                else if (uchoice.Equals("rock") && mchoice.Equals("scissor"))
                {
                    result1 = "lose";
                    result2 = name + " Wins !";
                }
                else if (uchoice.Equals("paper") && mchoice.Equals("rock"))
                {
                    result1 = "lose";
                    result2 = name + " Wins !";
                }
                else if (uchoice.Equals("paper") && mchoice.Equals("scissor"))
                {
                    result1 = "win";
                    result2 = name + " Loses !";
                }
                else if (uchoice.Equals("scissor") && mchoice.Equals("rock"))
                {
                    result1 = "win";
                    result2 = name + " Loses !";
                }
                else if (uchoice.Equals("scissor") && mchoice.Equals("paper"))
                {
                    result1 = "Loses ";
                    result2 = name + "  Wins!";
                }
                MessageBox.Show(result2);

                send(result1);
            }
            else
            {
                send(uchoice);
                byte[] datafromserver = new byte[20];
                NetworkStream ns = c.GetStream();
                ns.Read(datafromserver, 0, datafromserver.Length);
                ns.Flush();
                string msg = Encoding.ASCII.GetString(datafromserver);
                msg = msg.Replace("\0", string.Empty);
                MessageBox.Show(name + " " + msg);
            }
        }

        private void btnrock_Click(object sender, EventArgs e)
        {
            check("rock");
        }

        private void btnscissor_Click(object sender, EventArgs e)
        {
            check("scissor");
        }

        private void btnpaper_Click(object sender, EventArgs e)
        {
            check("paper");
        }

        private void viewScoreBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chatbox a = new Chatbox(c, name);
            a.Show();
        }
    }
}
