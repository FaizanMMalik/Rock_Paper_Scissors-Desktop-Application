using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace client2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            bool check = true;
            while (check)
            {
                try
                {
                    TcpClient c = new TcpClient();
                    c.Connect(txtip.Text, int.Parse(txtport.Text));
                    Game t = new Game();
                    t.getnameandclient(txtn.Text, c);
                    check = false;
                    t.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please turn on Server");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtip.Text = "127.0.0.1";
            txtport.Text = "9267";
        }
    }
}
