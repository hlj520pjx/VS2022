namespace Tcp_Server_Client
{
    partial class MyClient
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
            panel1 = new Panel();
            button2 = new Button();
            textBox2 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            iplabel = new Label();
            iptextBox = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(365, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 630);
            panel1.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(141, 374);
            button2.Name = "button2";
            button2.Size = new Size(170, 52);
            button2.TabIndex = 8;
            button2.Text = "发送消息";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 308);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 27);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(48, 141);
            button1.Name = "button1";
            button1.Size = new Size(138, 52);
            button1.TabIndex = 9;
            button1.Text = "连接Tcp服务";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Location = new Point(48, 301);
            label2.Name = "label2";
            label2.Size = new Size(87, 41);
            label2.TabIndex = 4;
            label2.Text = "消息";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 27);
            textBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Location = new Point(48, 65);
            label1.Name = "label1";
            label1.Size = new Size(87, 41);
            label1.TabIndex = 5;
            label1.Text = "端口号";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iplabel
            // 
            iplabel.Location = new Point(48, 32);
            iplabel.Name = "iplabel";
            iplabel.Size = new Size(87, 41);
            iplabel.TabIndex = 5;
            iplabel.Text = "IP";
            iplabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iptextBox
            // 
            iptextBox.Location = new Point(141, 39);
            iptextBox.Name = "iptextBox";
            iptextBox.Size = new Size(170, 27);
            iptextBox.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(205, 141);
            button3.Name = "button3";
            button3.Size = new Size(138, 52);
            button3.TabIndex = 9;
            button3.Text = "断开连接";
            button3.UseVisualStyleBackColor = true;
            // 
            // MyClient
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 672);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(iptextBox);
            Controls.Add(iplabel);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "MyClient";
            Text = "MyClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private TextBox textBox2;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label iplabel;
        private TextBox iptextBox;
        private Button button3;
    }
}