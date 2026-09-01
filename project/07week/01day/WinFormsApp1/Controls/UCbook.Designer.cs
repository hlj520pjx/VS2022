namespace WinFormsApp1
{
    partial class UCbook
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            button1 = new AntdUI.Button();
            input1 = new AntdUI.Input();
            input2 = new AntdUI.Input();
            input3 = new AntdUI.Input();
            inputNumber1 = new AntdUI.InputNumber();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(241, 36);
            label1.Name = "label1";
            label1.Size = new Size(148, 66);
            label1.TabIndex = 0;
            label1.Text = "";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(86, 137);
            label2.Name = "label2";
            label2.Size = new Size(148, 66);
            label2.TabIndex = 0;
            label2.Text = "图书名称";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.Location = new Point(86, 223);
            label3.Name = "label3";
            label3.Size = new Size(148, 66);
            label3.TabIndex = 0;
            label3.Text = "图书作者";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label4.Location = new Point(86, 306);
            label4.Name = "label4";
            label4.Size = new Size(148, 66);
            label4.TabIndex = 0;
            label4.Text = "图书价格";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label5.Location = new Point(86, 389);
            label5.Name = "label5";
            label5.Size = new Size(148, 66);
            label5.TabIndex = 0;
            label5.Text = "图书简介";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(223, 529);
            button1.Name = "button1";
            button1.Size = new Size(166, 63);
            button1.TabIndex = 1;
            // 
            // input1
            // 
            input1.Location = new Point(214, 134);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入图书名称";
            input1.Size = new Size(251, 69);
            input1.TabIndex = 2;
            input1.Tag = "";
            // 
            // input2
            // 
            input2.Location = new Point(214, 220);
            input2.Name = "input2";
            input2.PlaceholderText = "请输入图书作者";
            input2.Size = new Size(251, 69);
            input2.TabIndex = 2;
            // 
            // input3
            // 
            input3.Location = new Point(214, 389);
            input3.Name = "input3";
            input3.PlaceholderText = "请输入图书简介";
            input3.Size = new Size(251, 111);
            input3.TabIndex = 2;
            // 
            // inputNumber1
            // 
            inputNumber1.Location = new Point(214, 306);
            inputNumber1.Name = "inputNumber1";
            inputNumber1.PlaceholderText = "请输入图书价格";
            inputNumber1.Size = new Size(251, 66);
            inputNumber1.TabIndex = 3;
            inputNumber1.Text = "0";
            // 
            // UCbook
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(inputNumber1);
            Controls.Add(input3);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCbook";
            Size = new Size(645, 662);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private AntdUI.Label label5;
        private AntdUI.Button button1;
        private AntdUI.Input input1;
        private AntdUI.Input input2;
        private AntdUI.Input input3;
        private AntdUI.InputNumber inputNumber1;
    }
}
