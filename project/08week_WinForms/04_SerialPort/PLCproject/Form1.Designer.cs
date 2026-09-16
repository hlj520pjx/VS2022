namespace WinFormsApp1
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
            panel1 = new Panel();
            panel8 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label9 = new Label();
            panel7 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            button6 = new Button();
            panel6 = new Panel();
            label8 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            textBox1 = new TextBox();
            label6 = new Label();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 652);
            panel1.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(flowLayoutPanel1);
            panel8.Controls.Add(label9);
            panel8.Location = new Point(522, 338);
            panel8.Name = "panel8";
            panel8.Size = new Size(481, 275);
            panel8.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 47);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(479, 226);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(479, 47);
            label9.TabIndex = 3;
            label9.Text = "日志输出区";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(tableLayoutPanel1);
            panel7.Location = new Point(12, 338);
            panel7.Name = "panel7";
            panel7.Size = new Size(498, 275);
            panel7.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(label10, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(button6, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(496, 273);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.SetColumnSpan(label10, 3);
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(366, 45);
            label10.TabIndex = 0;
            label10.Text = "数据记录区";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 4);
            dataGridView1.Location = new Point(3, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 5);
            dataGridView1.Size = new Size(490, 222);
            dataGridView1.TabIndex = 2;
            // 
            // button6
            // 
            button6.BackColor = Color.Lime;
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(375, 3);
            button6.Name = "button6";
            button6.Size = new Size(118, 39);
            button6.TabIndex = 3;
            button6.Text = "查看历史数据";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label8);
            panel6.Location = new Point(288, 102);
            panel6.Name = "panel6";
            panel6.Size = new Size(439, 230);
            panel6.TabIndex = 2;
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(437, 47);
            label8.TabIndex = 2;
            label8.Text = "监控画面区";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(733, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(271, 230);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(3, 140);
            panel5.Name = "panel5";
            panel5.Size = new Size(263, 36);
            panel5.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // label6
            // 
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(139, 25);
            label6.TabIndex = 0;
            label6.Text = "请输入设定温度：";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 192, 0);
            button5.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button5.Location = new Point(152, 183);
            button5.Name = "button5";
            button5.Size = new Size(94, 42);
            button5.TabIndex = 2;
            button5.Text = "设定温度";
            button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 0);
            button3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button3.Location = new Point(152, 74);
            button3.Name = "button3";
            button3.Size = new Size(94, 42);
            button3.TabIndex = 2;
            button3.Text = "停止";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 192, 0);
            button4.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button4.Location = new Point(27, 74);
            button4.Name = "button4";
            button4.Size = new Size(94, 42);
            button4.TabIndex = 2;
            button4.Text = "启动";
            button4.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(269, 47);
            label7.TabIndex = 1;
            label7.Text = "设备控制区";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(11, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 230);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(43, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(181, 36);
            panel3.TabIndex = 3;
            // 
            // label4
            // 
            label4.Location = new Point(82, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 0;
            label4.Text = "未连接";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(12, -1);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 0;
            label3.Text = "当前状态：";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button2.Location = new Point(152, 74);
            button2.Name = "button2";
            button2.Size = new Size(94, 42);
            button2.TabIndex = 2;
            button2.Text = "断开PLC";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button1.Location = new Point(27, 74);
            button1.Name = "button1";
            button1.Size = new Size(94, 42);
            button1.TabIndex = 2;
            button1.Text = "连接PLC";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(269, 47);
            label2.TabIndex = 1;
            label2.Text = "连接控制区";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(393, 13);
            label1.Name = "label1";
            label1.Size = new Size(195, 47);
            label1.TabIndex = 0;
            label1.Text = "温控设备监控主界面";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 652);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Panel panel5;
        private Label label6;
        private Button button3;
        private Button button4;
        private Label label7;
        private Label label4;
        private Panel panel6;
        private Panel panel8;
        private Panel panel7;
        private Label label8;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label10;
        private Button button5;
        private DataGridView dataGridView1;
        private Button button6;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
