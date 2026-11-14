using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Label label1 = new Label() { Text = "Panel 1", Dock = DockStyle.Fill };
            Label label2 = new Label() { Text = "Panel 2", Dock = DockStyle.Fill };

            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(label2);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
