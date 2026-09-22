namespace Test.CarManerage
{
    partial class MainShow
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
            button1 = new AntdUI.Button();
            button2 = new AntdUI.Button();
            button3 = new AntdUI.Button();
            button4 = new AntdUI.Button();
            table1 = new AntdUI.Table();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1258, 118);
            label1.TabIndex = 0;
            label1.Text = "车辆租还系统";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button1.Location = new Point(82, 121);
            button1.Name = "button1";
            button1.Size = new Size(238, 69);
            button1.TabIndex = 1;
            button1.Text = "新增车辆";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button2.Location = new Point(374, 121);
            button2.Name = "button2";
            button2.Size = new Size(238, 69);
            button2.TabIndex = 1;
            button2.Text = "新增用户";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button3.Location = new Point(671, 121);
            button3.Name = "button3";
            button3.Size = new Size(238, 69);
            button3.TabIndex = 1;
            button3.Text = "查看客户列表";
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button4.Location = new Point(957, 121);
            button4.Name = "button4";
            button4.Size = new Size(238, 69);
            button4.TabIndex = 1;
            button4.Text = "查看租车记录";
            button4.Click += button4_Click;
            // 
            // table1
            // 
            table1.Gap = 12;
            table1.Location = new Point(357, 207);
            table1.Name = "table1";
            table1.Size = new Size(690, 378);
            table1.TabIndex = 2;
            table1.Text = "table1";
            // 
            // MainShow
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 753);
            Controls.Add(table1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "MainShow";
            Text = "MainShow";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private AntdUI.Button button3;
        private AntdUI.Button button4;
        private AntdUI.Table table1;
    }
}