using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
