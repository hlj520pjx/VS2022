namespace WinFormsApp1
{
    partial class Form2
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
            button2 = new AntdUI.Button();
            button1 = new AntdUI.Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            input2 = new AntdUI.Input();
            label3 = new AntdUI.Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            input1 = new AntdUI.Input();
            label2 = new AntdUI.Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label4 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            panel3 = new Panel();
            label6 = new AntdUI.Label();
            label7 = new AntdUI.Label();
            panel4 = new Panel();
            label8 = new AntdUI.Label();
            label9 = new AntdUI.Label();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(23, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(1007, 613);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackActive = Color.Blue;
            button2.BackColor = Color.Blue;
            button2.Location = new Point(868, 83);
            button2.Name = "button2";
            button2.Size = new Size(103, 41);
            button2.TabIndex = 2;
            button2.Text = "导出";
            // 
            // button1
            // 
            button1.BackActive = Color.Blue;
            button1.BackColor = Color.Blue;
            button1.Location = new Point(750, 83);
            button1.Name = "button1";
            button1.Size = new Size(103, 41);
            button1.TabIndex = 2;
            button1.Text = "查询";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel2.Controls.Add(input2, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Location = new Point(384, 83);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(351, 44);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // input2
            // 
            input2.Dock = DockStyle.Fill;
            input2.Location = new Point(120, 3);
            input2.Name = "input2";
            input2.PlaceholderText = "请输入结束时间";
            input2.Size = new Size(228, 38);
            input2.TabIndex = 1;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(111, 38);
            label3.TabIndex = 2;
            label3.Text = "结束时间：";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.Controls.Add(input1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(27, 83);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(351, 44);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // input1
            // 
            input1.Dock = DockStyle.Fill;
            input1.Location = new Point(120, 3);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入开始时间";
            input1.Size = new Size(228, 38);
            input1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(111, 38);
            label2.TabIndex = 2;
            label2.Text = "开始时间：";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(349, -1);
            label1.Name = "label1";
            label1.Size = new Size(266, 55);
            label1.TabIndex = 0;
            label1.Text = "历史温度数据查询";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(944, 364);
            dataGridView1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(30, 534);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 37);
            panel2.TabIndex = 4;
            // 
            // label4
            // 
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(94, 29);
            label4.TabIndex = 0;
            label4.Text = "最高温度：";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Location = new Point(76, 3);
            label5.Name = "label5";
            label5.Size = new Size(94, 29);
            label5.TabIndex = 0;
            label5.Text = "";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(306, 534);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 37);
            panel3.TabIndex = 4;
            // 
            // label6
            // 
            label6.Location = new Point(76, 3);
            label6.Name = "label6";
            label6.Size = new Size(94, 29);
            label6.TabIndex = 0;
            label6.Text = "";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Location = new Point(3, 3);
            label7.Name = "label7";
            label7.Size = new Size(94, 29);
            label7.TabIndex = 0;
            label7.Text = "最低温度：";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(581, 534);
            panel4.Name = "panel4";
            panel4.Size = new Size(192, 37);
            panel4.TabIndex = 4;
            // 
            // label8
            // 
            label8.Location = new Point(76, 3);
            label8.Name = "label8";
            label8.Size = new Size(94, 29);
            label8.TabIndex = 0;
            label8.Text = "";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Location = new Point(3, 3);
            label9.Name = "label9";
            label9.Size = new Size(94, 29);
            label9.TabIndex = 0;
            label9.Text = "平均温度：";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 652);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private AntdUI.Input input1;
        private AntdUI.Label label2;
        private AntdUI.Button button1;
        private TableLayoutPanel tableLayoutPanel2;
        private AntdUI.Input input2;
        private AntdUI.Label label3;
        private AntdUI.Button button2;
        private DataGridView dataGridView1;
        private Panel panel4;
        private AntdUI.Label label8;
        private AntdUI.Label label9;
        private Panel panel3;
        private AntdUI.Label label6;
        private AntdUI.Label label7;
        private Panel panel2;
        private AntdUI.Label label5;
        private AntdUI.Label label4;
    }
}