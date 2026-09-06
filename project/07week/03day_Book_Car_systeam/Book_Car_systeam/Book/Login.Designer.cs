namespace Book_Car_systeam.Book
{
    partial class Login
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
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            input1 = new AntdUI.Input();
            input2 = new AntdUI.Input();
            button1 = new AntdUI.Button();
            button2 = new AntdUI.Button();
            label4 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 102);
            label1.TabIndex = 1;
            label1.Text = "登录";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(154, 173);
            label2.Name = "label2";
            label2.Size = new Size(94, 29);
            label2.TabIndex = 2;
            label2.Text = "用户名";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input1
            // 
            input1.Location = new Point(286, 145);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入用户名";
            input1.Size = new Size(315, 82);
            input1.TabIndex = 3;
            // 
            // input2
            // 
            input2.Location = new Point(286, 257);
            input2.Name = "input2";
            input2.PlaceholderText = "请输入用户密码";
            input2.Size = new Size(315, 82);
            input2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(324, 370);
            button1.Name = "button1";
            button1.Size = new Size(178, 75);
            button1.TabIndex = 4;
            button1.Text = "登录";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(359, 532);
            button2.Name = "button2";
            button2.Size = new Size(94, 56);
            button2.TabIndex = 5;
            button2.Text = "注册";
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.Location = new Point(176, 542);
            label4.Name = "label4";
            label4.Size = new Size(177, 29);
            label4.TabIndex = 6;
            label4.Text = "没有账户请先注册==>";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.Location = new Point(154, 288);
            label3.Name = "label3";
            label3.Size = new Size(94, 29);
            label3.TabIndex = 2;
            label3.Text = "用户密码";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(286, 475);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(196, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "勾选即代表您加入二刺猿";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 649);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Input input1;
        private AntdUI.Input input2;
        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private AntdUI.Label label4;
        private AntdUI.Label label3;
        private CheckBox checkBox1;
    }
}