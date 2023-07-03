using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Clientprj
{
    public partial class Game : Form
    {
        string result1 = "", result2 = "";
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
            lblp.Text =name;
            lblp.Font = new Font("Rockwell Extra Bold", 22);
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

        private void btnscissor_Click(object sender, EventArgs e)
        {
            //SoundPlayer s = new SoundPlayer("scissor.wav");
            //s.Play();
            check("scissor");
        }

        private void btnpaper_Click(object sender, EventArgs e)
        {
            //SoundPlayer s = new SoundPlayer("paper.wav");
            //s.Play();
            check("paper");
        }

        public void check(string uchoice)
        {
            btndisable();
            if (player.Equals("2"))
            {
                
                if (uchoice.Equals(mchoice))
                { 
                    result1 = "match draw";
                    result2 = "match draw";
                }
                else if (uchoice.Equals("rock") && mchoice.Equals("paper"))
                {
                    result1 = "win because other player chose paper";
                    result2 = name + " Loses ! because other player chose rock";
                }
                else if (uchoice.Equals("rock") && mchoice.Equals("scissor"))
                {
                    result1 = "lose because other player chose rock";
                    result2 = name + " Wins ! because other player chose scissor";
                }
                else if (uchoice.Equals("paper") && mchoice.Equals("rock"))
                {
                    result1 = "lose because other player chose paper";
                    result2 = name + " Wins ! because other player chose rock";
                }
                else if (uchoice.Equals("paper") && mchoice.Equals("scissor"))
                {
                    result1 = "win because other player chose paper";
                    result2 = name + " Loses !because other player chose scissor";
                }
                else if (uchoice.Equals("scissor") && mchoice.Equals("rock"))
                {
                    result1 = "win because other player chose scissor";
                    result2 = name + " Loses ! because other player chose rock";
                }
                else if (uchoice.Equals("scissor") && mchoice.Equals("paper"))
                {
                    result1 = "Loses because other player chose scissor";
                    result2 = name+"  Wins! because other player chose paper";
                }
          
                MessageBox.Show(result2);         
                send(result1);
                send(uchoice);
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
                MessageBox.Show(name+" "+msg);
            }
        }

       
        private void btnrock_Click_1(object sender, EventArgs e)
        {
            //SoundPlayer s = new SoundPlayer("rock.wav");
            //    s.Play();
            check("rock");

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c.Close();
            login s = new login();
            this.Hide();
            s.Show();
        }

        private void playAgainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
         
        }

        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewScoreBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChatBox a = new ChatBox(c, name);
            a.Show();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SC a = new SC();
            a.Show();
        }

        private void newGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //System.Environment.Exit(0);
            var Game = new Game();
            Game.Run();
            //Application.Restart();
            //System.Diagnostics.Process.Start(Application.ExecutablePath);
            //System.Environment.Exit(0);

        }
        public void Run()
        {
            Game.ActiveForm.Refresh();
            //btnrock.Enabled = true;
            //btnpaper.Enabled = true;
            //btnscissor.Enabled = true;
            //result1 = null;
            //result2 = null;
        }
    }
   
    }
   


