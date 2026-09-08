namespace Book_Car_systeam.Book
{
    partial class register
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
            input1 = new AntdUI.Input();
            label2 = new Label();
            input2 = new AntdUI.Input();
            label3 = new Label();
            input3 = new AntdUI.Input();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel1 = new Panel();
            label7 = new Label();
            select1 = new AntdUI.Select();
            button1 = new AntdUI.Button();
            inputNumber1 = new AntdUI.InputNumber();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(982, 102);
            label1.TabIndex = 1;
            label1.Text = "注册";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input1
            // 
            input1.Location = new Point(394, 108);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入用户名";
            input1.Size = new Size(315, 49);
            input1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 123);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 8;
            label2.Text = "用户名";
            // 
            // input2
            // 
            input2.Location = new Point(394, 178);
            input2.Name = "input2";
            input2.PasswordChar = '*';
            input2.PlaceholderText = "请输入密码";
            input2.Size = new Size(315, 49);
            input2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 194);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 8;
            label3.Text = "密码";
            // 
            // input3
            // 
            input3.Location = new Point(394, 249);
            input3.Name = "input3";
            input3.PasswordChar = '*';
            input3.PlaceholderText = "确认密码";
            input3.Size = new Size(315, 49);
            input3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(315, 265);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 8;
            label4.Text = "确认密码";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(315, 335);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 8;
            label5.Text = "年龄";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(315, 402);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 8;
            label6.Text = "性别";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 24);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(45, 24);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "男";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(87, 24);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(45, 24);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "女";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton2);
            panel1.Location = new Point(394, 374);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 65);
            panel1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(315, 492);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 11;
            label7.Text = "班级";
            // 
            // select1
            // 
            select1.Location = new Point(394, 468);
            select1.Name = "select1";
            select1.PlaceholderText = "请选择班级";
            select1.Size = new Size(315, 60);
            select1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(431, 556);
            button1.Name = "button1";
            button1.Size = new Size(142, 63);
            button1.TabIndex = 13;
            button1.Text = "注册";
            button1.Click += button1_Click;
            // 
            // inputNumber1
            // 
            inputNumber1.Location = new Point(394, 319);
            inputNumber1.Name = "inputNumber1";
            inputNumber1.Size = new Size(315, 49);
            inputNumber1.TabIndex = 14;
            inputNumber1.Text = "0";
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(982, 653);
            Controls.Add(inputNumber1);
            Controls.Add(button1);
            Controls.Add(select1);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(input3);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(label1);
            Name = "register";
            Text = "register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Input input1;
        private Label label2;
        private AntdUI.Input input2;
        private Label label3;
        private AntdUI.Input input3;
        private Label label4;
        private Label label5;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Panel panel1;
        private Label label7;
        private AntdUI.Select select1;
        private AntdUI.Button button1;
        private AntdUI.InputNumber inputNumber1;
    }
}