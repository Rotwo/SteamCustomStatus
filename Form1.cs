using System.IO;
using System;
using System.Diagnostics;

namespace SteamCustomStatus
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string command = @textBox1.Text + @"&& echo Runned Successfully.";
                Process.Start("cmd.exe", "/K " + command);
            }

            else
            {
                try
                {
                    Process.Start(textBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            ShowBG();
        }

        private void ShowBG()
        {
            // Show notifyIcon with a message
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(1000, "Steam Custom Status", "Runned Successfully, running on background.", ToolTipIcon.Info);
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void finishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}