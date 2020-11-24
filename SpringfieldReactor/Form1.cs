using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace SpringfieldReactor {;
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
       
        }

        private void EnableButton_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.resources.alert);
            player.Play();

            ReactorLabel.Text = "Not Good!";
            Reactor1.BackColor = Color.Red;
            Reactor2.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            Reactor1.BackColor = Color.White;
            Reactor2.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);

            ReactorLabel.Text = "Not Good!";
            Reactor1.BackColor = Color.Red;
            Reactor2.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);
        }
    }
}
