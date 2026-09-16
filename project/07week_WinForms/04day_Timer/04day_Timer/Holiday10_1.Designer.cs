namespace _04day_Timer
{
    partial class Holiday10_1
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
            day = new Label();
            label3 = new Label();
            hour = new Label();
            label5 = new Label();
            miunte = new Label();
            label7 = new Label();
            second = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(657, 87);
            label1.TabIndex = 0;
            label1.Text = "国庆倒计时";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // day
            // 
            day.AutoSize = true;
            day.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            day.Location = new Point(180, 184);
            day.Name = "day";
            day.Size = new Size(0, 27);
            day.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            label3.Location = new Point(213, 184);
            label3.Name = "label3";
            label3.Size = new Size(32, 27);
            label3.TabIndex = 2;
            label3.Text = "天";
            // 
            // hour
            // 
            hour.AutoSize = true;
            hour.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            hour.Location = new Point(251, 184);
            hour.Name = "hour";
            hour.Size = new Size(0, 27);
            hour.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            label5.Location = new Point(270, 184);
            label5.Name = "label5";
            label5.Size = new Size(52, 27);
            label5.TabIndex = 2;
            label5.Text = "小时";
            // 
            // miunte
            // 
            miunte.AutoSize = true;
            miunte.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            miunte.Location = new Point(328, 184);
            miunte.Name = "miunte";
            miunte.Size = new Size(0, 27);
            miunte.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            label7.Location = new Point(344, 184);
            label7.Name = "label7";
            label7.Size = new Size(32, 27);
            label7.TabIndex = 2;
            label7.Text = "分";
            // 
            // second
            // 
            second.AutoSize = true;
            second.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            second.Location = new Point(382, 184);
            second.Name = "second";
            second.Size = new Size(0, 27);
            second.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            label9.Location = new Point(412, 184);
            label9.Name = "label9";
            label9.Size = new Size(32, 27);
            label9.TabIndex = 2;
            label9.Text = "秒";
            // 
            // Holiday10_1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 558);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(second);
            Controls.Add(miunte);
            Controls.Add(hour);
            Controls.Add(day);
            Controls.Add(label1);
            Name = "Holiday10_1";
            Text = "Holiday10_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label day;
        private Label label3;
        private Label hour;
        private Label label5;
        private Label miunte;
        private Label label7;
        private Label second;
        private Label label9;
    }
}