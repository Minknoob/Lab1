using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            ToolStripStatusLabel statusLabel = new ToolStripStatusLabel("Ready");
            statusStrip1.Items.Add(statusLabel);
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }
    }
}
