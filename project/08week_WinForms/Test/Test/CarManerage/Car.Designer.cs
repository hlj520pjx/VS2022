namespace Test.CarManerage
{
    partial class Car
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
            label2 = new AntdUI.Label();
            button1 = new AntdUI.Button();
            input1 = new AntdUI.Input();
            label3 = new AntdUI.Label();
            input2 = new AntdUI.Input();
            label4 = new AntdUI.Label();
            input3 = new AntdUI.Input();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(611, 118);
            label1.TabIndex = 1;
            label1.Text = "新增车辆";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(110, 149);
            label2.Name = "label2";
            label2.Size = new Size(120, 38);
            label2.TabIndex = 2;
            label2.Text = "车牌号";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(213, 421);
            button1.Name = "button1";
            button1.Size = new Size(194, 69);
            button1.TabIndex = 3;
            button1.Text = "新增";
            // 
            // input1
            // 
            input1.Location = new Point(236, 134);
            input1.Name = "input1";
            input1.Size = new Size(246, 65);
            input1.TabIndex = 4;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.Location = new Point(110, 228);
            label3.Name = "label3";
            label3.Size = new Size(120, 38);
            label3.TabIndex = 2;
            label3.Text = "车辆类型";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input2
            // 
            input2.Location = new Point(236, 213);
            input2.Name = "input2";
            input2.Size = new Size(246, 65);
            input2.TabIndex = 4;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label4.Location = new Point(110, 305);
            label4.Name = "label4";
            label4.Size = new Size(120, 38);
            label4.TabIndex = 2;
            label4.Text = "车辆时费";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input3
            // 
            input3.Location = new Point(236, 290);
            input3.Name = "input3";
            input3.Size = new Size(246, 65);
            input3.TabIndex = 4;
            // 
            // Car
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 576);
            Controls.Add(input3);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Car";
            Text = "Car";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private AntdUI.Label label2;
        private AntdUI.Button button1;
        private AntdUI.Input input1;
        private AntdUI.Label label3;
        private AntdUI.Input input2;
        private AntdUI.Label label4;
        private AntdUI.Input input3;
    }
}