using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Clientprj
{
    public partial class SC : Form
    {
        public SC()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FileStream f = new FileStream("F:\\prjtxt.txt", FileMode.Open, FileAccess.Read);
            StreamReader s;
            s = new StreamReader(f);
            RTB.Text = s.ReadToEnd();
            s.Close();
            f.Close();
        }
    }
}
