﻿using System;
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
    public partial class Chatbox : Form
    {
        public Chatbox()
        {
            InitializeComponent();
        }
        TcpClient c;
        String username; NetworkStream ns;
        BinaryFormatter fobj;
        public Chatbox(TcpClient cl, string n)
        {
            c = cl;
            username = n;
            ns = c.GetStream();
            fobj = new BinaryFormatter();

        }
        private void Chatbox_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            new Thread(() => Read()).Start();
        }
        private void Read()
        {
            string msg;
            while (true)
            {
                msg = (String)fobj.Deserialize(ns);
                listbox.Items.Add(msg);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            fobj.Serialize(ns, txtcmsg.Text);
            listbox.Items.Add(username + " : " + txtcmsg.Text);
        }
    }
}
