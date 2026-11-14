namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView1 = new TreeView();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(292, 88);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(182, 146);
            treeView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(444, 372);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 31);
            textBox1.TabIndex = 1;
            textBox1.Text = "Developed by Dang Hieu Minh";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 450);
            Controls.Add(textBox1);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private TextBox textBox1;
    }
}
