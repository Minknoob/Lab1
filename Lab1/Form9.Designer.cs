namespace Lab1
{
    partial class Form9
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
            textBox1 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(450, 374);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 31);
            textBox1.TabIndex = 7;
            textBox1.Text = "Developed by Dang Hieu Minh";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.Highlight;
            flowLayoutPanel1.Location = new Point(97, 26);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(300, 226);
            flowLayoutPanel1.TabIndex = 8;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBox1);
            Name = "Form9";
            Text = "Form9";
            Load += Form9_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}