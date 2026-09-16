namespace Test.CarManerage
{
    partial class User
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
            label1 = new Label();
            input3 = new AntdUI.Input();
            input2 = new AntdUI.Input();
            input1 = new AntdUI.Input();
            button1 = new AntdUI.Button();
            label4 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            input4 = new AntdUI.Input();
            label6 = new AntdUI.Label();
            input5 = new AntdUI.Input();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 118);
            label1.TabIndex = 2;
            label1.Text = "新增客户";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input3
            // 
            input3.Location = new Point(337, 255);
            input3.Name = "input3";
            input3.Size = new Size(246, 65);
            input3.TabIndex = 9;
            // 
            // input2
            // 
            input2.Location = new Point(337, 178);
            input2.Name = "input2";
            input2.Size = new Size(246, 65);
            input2.TabIndex = 10;
            // 
            // input1
            // 
            input1.Location = new Point(337, 99);
            input1.Name = "input1";
            input1.Size = new Size(246, 65);
            input1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(315, 505);
            button1.Name = "button1";
            button1.Size = new Size(194, 69);
            button1.TabIndex = 8;
            button1.Text = "新增";
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label4.Location = new Point(211, 270);
            label4.Name = "label4";
            label4.Size = new Size(120, 38);
            label4.TabIndex = 5;
            label4.Text = "性别";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.Location = new Point(211, 193);
            label3.Name = "label3";
            label3.Size = new Size(120, 38);
            label3.TabIndex = 6;
            label3.Text = "身份证";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(211, 114);
            label2.Name = "label2";
            label2.Size = new Size(120, 38);
            label2.TabIndex = 7;
            label2.Text = "姓名";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label5.Location = new Point(211, 340);
            label5.Name = "label5";
            label5.Size = new Size(120, 38);
            label5.TabIndex = 5;
            label5.Text = "手机号";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input4
            // 
            input4.Location = new Point(337, 326);
            input4.Name = "input4";
            input4.Size = new Size(246, 65);
            input4.TabIndex = 9;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label6.Location = new Point(211, 407);
            label6.Name = "label6";
            label6.Size = new Size(120, 38);
            label6.TabIndex = 5;
            label6.Text = "座右铭";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input5
            // 
            input5.Location = new Point(337, 393);
            input5.Name = "input5";
            input5.Size = new Size(246, 65);
            input5.TabIndex = 9;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 637);
            Controls.Add(input5);
            Controls.Add(input4);
            Controls.Add(input3);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "User";
            Text = "User";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private AntdUI.Input input3;
        private AntdUI.Input input2;
        private AntdUI.Input input1;
        private AntdUI.Button button1;
        private AntdUI.Label label4;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
        private AntdUI.Label label5;
        private AntdUI.Input input4;
        private AntdUI.Label label6;
        private AntdUI.Input input5;
    }
}