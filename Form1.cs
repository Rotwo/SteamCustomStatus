using System.IO;
using System;
using System.Diagnostics;

namespace SteamCustomStatus
{
    public partial class Form1 : Form
    {
        public Form1()
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
            try
            {
                Process.Start(textBox1.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}