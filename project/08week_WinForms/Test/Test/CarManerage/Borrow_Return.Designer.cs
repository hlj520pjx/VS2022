namespace Test.CarManerage
{
    partial class Borrow_Return
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
            input2 = new AntdUI.Input();
            input1 = new AntdUI.Input();
            label4 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            select1 = new AntdUI.Select();
            button1 = new AntdUI.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 118);
            label1.TabIndex = 3;
            label1.Text = "租车";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input2
            // 
            input2.Location = new Point(332, 219);
            input2.Name = "input2";
            input2.Size = new Size(246, 65);
            input2.TabIndex = 17;
            // 
            // input1
            // 
            input1.Location = new Point(332, 140);
            input1.Name = "input1";
            input1.Size = new Size(246, 65);
            input1.TabIndex = 18;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label4.Location = new Point(206, 311);
            label4.Name = "label4";
            label4.Size = new Size(120, 38);
            label4.TabIndex = 12;
            label4.Text = "租车客户";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.Location = new Point(206, 234);
            label3.Name = "label3";
            label3.Size = new Size(120, 38);
            label3.TabIndex = 13;
            label3.Text = "车辆类型";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(206, 155);
            label2.Name = "label2";
            label2.Size = new Size(120, 38);
            label2.TabIndex = 14;
            label2.Text = "车牌号";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // select1
            // 
            select1.Location = new Point(332, 290);
            select1.Name = "select1";
            select1.Size = new Size(246, 67);
            select1.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(332, 443);
            button1.Name = "button1";
            button1.Size = new Size(183, 82);
            button1.TabIndex = 20;
            button1.Text = "点击租车";
            // 
            // Borrow_Return
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 678);
            Controls.Add(button1);
            Controls.Add(select1);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Borrow_Return";
            Text = "Borrow_Return";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private AntdUI.Input input2;
        private AntdUI.Input input1;
        private AntdUI.Label label4;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
        private AntdUI.Select select1;
        private AntdUI.Button button1;
    }
}