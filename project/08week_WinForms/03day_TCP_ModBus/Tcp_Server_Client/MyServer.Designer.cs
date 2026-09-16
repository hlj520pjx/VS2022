namespace Tcp_Server_Client
{
    partial class MyServer
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(57, 65);
            label1.Name = "label1";
            label1.Size = new Size(87, 41);
            label1.TabIndex = 0;
            label1.Text = "端口号";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(150, 138);
            button1.Name = "button1";
            button1.Size = new Size(170, 52);
            button1.TabIndex = 2;
            button1.Text = "创建Tcp服务";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Location = new Point(57, 301);
            label2.Name = "label2";
            label2.Size = new Size(87, 41);
            label2.TabIndex = 0;
            label2.Text = "消息";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 308);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 27);
            textBox2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(150, 374);
            button2.Name = "button2";
            button2.Size = new Size(170, 52);
            button2.TabIndex = 2;
            button2.Text = "发送消息";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(374, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 630);
            panel1.TabIndex = 3;
            // 
            // MyServer
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 672);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "MyServer";
            Text = "MyServer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private Button button2;
        private Panel panel1;
    }
}
