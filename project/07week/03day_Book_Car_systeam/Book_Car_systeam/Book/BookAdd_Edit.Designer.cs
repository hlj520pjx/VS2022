namespace Book_Car_systeam.Book
{
    partial class BookAdd_Edit
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
            label3 = new AntdUI.Label();
            input2 = new AntdUI.Input();
            label4 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            input4 = new AntdUI.Input();
            button1 = new AntdUI.Button();
            inputNumber1 = new AntdUI.InputNumber();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(982, 98);
            label1.TabIndex = 0;
            label1.Text = "";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(291, 127);
            label2.Name = "label2";
            label2.Size = new Size(94, 29);
            label2.TabIndex = 1;
            label2.Text = "图书书名";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input1
            // 
            input1.Location = new Point(402, 102);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入书名";
            input1.Size = new Size(271, 76);
            input1.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.Location = new Point(291, 230);
            label3.Name = "label3";
            label3.Size = new Size(94, 29);
            label3.TabIndex = 1;
            label3.Text = "图书作者";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input2
            // 
            input2.Location = new Point(402, 205);
            input2.Name = "input2";
            input2.PlaceholderText = "请输入作者";
            input2.Size = new Size(271, 76);
            input2.TabIndex = 2;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label4.Location = new Point(291, 328);
            label4.Name = "label4";
            label4.Size = new Size(94, 29);
            label4.TabIndex = 1;
            label4.Text = "图书价格";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label5.Location = new Point(291, 425);
            label5.Name = "label5";
            label5.Size = new Size(94, 29);
            label5.TabIndex = 1;
            label5.Text = "图书标签";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input4
            // 
            input4.Location = new Point(402, 400);
            input4.Multiline = true;
            input4.Name = "input4";
            input4.PlaceholderText = "请输入标签";
            input4.Size = new Size(271, 97);
            input4.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(402, 503);
            button1.Name = "button1";
            button1.Size = new Size(180, 66);
            button1.TabIndex = 3;
            // 
            // inputNumber1
            // 
            inputNumber1.Location = new Point(402, 309);
            inputNumber1.Name = "inputNumber1";
            inputNumber1.Size = new Size(271, 76);
            inputNumber1.TabIndex = 4;
            // 
            // BookAdd_Edit
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(inputNumber1);
            Controls.Add(button1);
            Controls.Add(input4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(input2);
            Controls.Add(label3);
            Controls.Add(input1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BookAdd_Edit";
            Text = "BookAdd_Edit";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Input input1;
        private AntdUI.Label label3;
        private AntdUI.Input input2;
        private AntdUI.Label label4;
        private AntdUI.Label label5;
        private AntdUI.Input input4;
        private AntdUI.Button button1;
        private AntdUI.InputNumber inputNumber1;
    }
}