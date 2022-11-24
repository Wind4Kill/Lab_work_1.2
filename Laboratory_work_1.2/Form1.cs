using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_work_1._2
{
    public partial class Form1 : Form
    {

       

        
        public Form1()
        {
            InitializeComponent();

            fileToolStripMenuItem.DropDownItems[3].Visible = false;
            fileToolStripMenuItem.DropDownItems[4].Visible = false;
            fileToolStripMenuItem.DropDownItems[5].Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message window has opened!");
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkToolStripMenuItem.Checked == true)
            {
                checkToolStripMenuItem.Checked = false;
            }
            else
                checkToolStripMenuItem.Checked = true;


            if (checkToolStripMenuItem.Checked == false)
            {
                messageToolStripMenuItem.Enabled = false;

            }
            else
            {
                messageToolStripMenuItem.Enabled = true;

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {



                    fileToolStripMenuItem.DropDownItems[3].Visible=true;
                    fileToolStripMenuItem.DropDownItems[4].Visible=true;
                    fileToolStripMenuItem.DropDownItems[5].Visible=true;

                
                

            }

            if (e.KeyCode == Keys.D)
            {
                
                    fileToolStripMenuItem.DropDownItems[3].Visible = false;
                    fileToolStripMenuItem.DropDownItems[4].Visible = false;
                    fileToolStripMenuItem.DropDownItems[5].Visible = false;


            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string User = SystemInformation.UserName;
            string Domain = SystemInformation.UserDomainName;

            MessageBox.Show("Hello, " + User + ". You are connected to "
            + Domain + ". The current version of a program build is: 1.0.0");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New file!");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File has been opened!");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File has been closed!");
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Right))
                contextMenuStrip1.Show(MousePosition,ToolStripDropDownDirection.Right);
        }

        private void messageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message window has been opened!");
        }

        private void checkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (checkToolStripMenuItem.Checked == true)
            {
                checkToolStripMenuItem.Checked = false;
            }
            else
                checkToolStripMenuItem.Checked = true;


            if (checkToolStripMenuItem.Checked == false)
            {
                messageToolStripMenuItem.Enabled = false;

            }
            else
            {
                messageToolStripMenuItem.Enabled = true;

            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}
