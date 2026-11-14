using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem cutItem = new ToolStripMenuItem("Cut");
            ToolStripMenuItem copyItem = new ToolStripMenuItem("Copy");
            ToolStripMenuItem pasteItem = new ToolStripMenuItem("Paste");
            contextMenuStrip1.Items.Add(cutItem);
            contextMenuStrip1.Items.Add(copyItem);
            contextMenuStrip1.Items.Add(pasteItem);
            textBox1.ContextMenuStrip = contextMenuStrip1;
        }

        private void chẳngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void âToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
