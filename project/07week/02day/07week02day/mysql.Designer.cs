namespace _07week02day
{
    partial class mysql
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
            dataGridView1 = new DataGridView();
            input1 = new AntdUI.Input();
            button1 = new AntdUI.Button();
            button2 = new AntdUI.Button();
            button3 = new AntdUI.Button();
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            button4 = new AntdUI.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(965, 515);
            dataGridView1.TabIndex = 0;
            // 
            // input1
            // 
            input1.Location = new Point(371, 533);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入关键词";
            input1.Size = new Size(217, 53);
            input1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.AliceBlue;
            button1.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button1.Location = new Point(371, 592);
            button1.Name = "button1";
            button1.OriginalBackColor = Color.RosyBrown;
            button1.Size = new Size(217, 52);
            button1.TabIndex = 2;
            button1.Text = "条件查询";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.AliceBlue;
            button2.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button2.Location = new Point(113, 592);
            button2.Name = "button2";
            button2.OriginalBackColor = Color.RosyBrown;
            button2.Size = new Size(217, 52);
            button2.TabIndex = 2;
            button2.Text = "聚合查询";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.AliceBlue;
            button3.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button3.Location = new Point(627, 592);
            button3.Name = "button3";
            button3.OriginalBackColor = Color.RosyBrown;
            button3.Size = new Size(217, 52);
            button3.TabIndex = 2;
            button3.Text = "增删改";
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.Location = new Point(113, 663);
            label1.Name = "label1";
            label1.Size = new Size(94, 29);
            label1.TabIndex = 3;
            label1.Text = "查询结果：";
            // 
            // label2
            // 
            label2.Location = new Point(182, 663);
            label2.Name = "label2";
            label2.Size = new Size(94, 29);
            label2.TabIndex = 4;
            label2.Text = "";
            // 
            // button4
            // 
            button4.Location = new Point(426, 663);
            button4.Name = "button4";
            button4.Size = new Size(115, 49);
            button4.TabIndex = 5;
            button4.Text = "返回";
            button4.Click += button4_Click;
            // 
            // mysql
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 769);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(input1);
            Controls.Add(dataGridView1);
            Name = "mysql";
            Text = "mysql";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private AntdUI.Input input1;
        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private AntdUI.Button button3;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Button button4;
    }
}