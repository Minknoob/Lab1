using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");
            ToolStripMenuItem openItem = new ToolStripMenuItem("Open");
            ToolStripMenuItem saveItem = new ToolStripMenuItem("Save");
            fileMenu.DropDownItems.Add(openItem);
            fileMenu.DropDownItems.Add(saveItem);
            menuStrip1.Items.Add(fileMenu);
        }
    }
}
