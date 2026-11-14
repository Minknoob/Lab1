namespace Lab1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            âToolStripMenuItem = new ToolStripMenuItem();
            chẳngToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItem4 = new ToolStripMenuItem();
            aToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItem1 = new ToolStripMenuItem();
            aToolStripMenuItem2 = new ToolStripMenuItem();
            aToolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(413, 395);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 31);
            textBox1.TabIndex = 3;
            textBox1.Text = "Developed by Dang Hieu Minh";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { âToolStripMenuItem, aToolStripMenuItem, aToolStripMenuItem1, aToolStripMenuItem2, aToolStripMenuItem3, toolStripMenuItem2 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(241, 229);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // âToolStripMenuItem
            // 
            âToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chẳngToolStripMenuItem, aToolStripMenuItem4 });
            âToolStripMenuItem.Name = "âToolStripMenuItem";
            âToolStripMenuItem.Size = new Size(240, 32);
            âToolStripMenuItem.Text = "524H0168";
            âToolStripMenuItem.Click += âToolStripMenuItem_Click;
            // 
            // chẳngToolStripMenuItem
            // 
            chẳngToolStripMenuItem.Name = "chẳngToolStripMenuItem";
            chẳngToolStripMenuItem.Size = new Size(270, 34);
            chẳngToolStripMenuItem.Text = "chẳng";
            chẳngToolStripMenuItem.Click += chẳngToolStripMenuItem_Click;
            // 
            // aToolStripMenuItem4
            // 
            aToolStripMenuItem4.Name = "aToolStripMenuItem4";
            aToolStripMenuItem4.Size = new Size(270, 34);
            aToolStripMenuItem4.Text = "a";
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(240, 32);
            aToolStripMenuItem.Text = "1";
            // 
            // aToolStripMenuItem1
            // 
            aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            aToolStripMenuItem1.Size = new Size(240, 32);
            aToolStripMenuItem1.Text = "2";
            // 
            // aToolStripMenuItem2
            // 
            aToolStripMenuItem2.Name = "aToolStripMenuItem2";
            aToolStripMenuItem2.Size = new Size(240, 32);
            aToolStripMenuItem2.Text = "3";
            // 
            // aToolStripMenuItem3
            // 
            aToolStripMenuItem3.Name = "aToolStripMenuItem3";
            aToolStripMenuItem3.Size = new Size(240, 32);
            aToolStripMenuItem3.Text = "4";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(240, 32);
            toolStripMenuItem2.Text = "5";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem âToolStripMenuItem;
        private ToolStripMenuItem chẳngToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem1;
        private ToolStripMenuItem aToolStripMenuItem2;
        private ToolStripMenuItem aToolStripMenuItem3;
        private ToolStripMenuItem aToolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}