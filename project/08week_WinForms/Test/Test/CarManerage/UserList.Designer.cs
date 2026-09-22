namespace Test.CarManerage
{
    partial class UserList
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
            table1 = new AntdUI.Table();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1065, 118);
            label1.TabIndex = 1;
            label1.Text = "客户列表";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // table1
            // 
            table1.Gap = 12;
            table1.Location = new Point(206, 175);
            table1.Name = "table1";
            table1.Size = new Size(671, 382);
            table1.TabIndex = 3;
            table1.Text = "table1";
            // 
            // UserList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 621);
            Controls.Add(table1);
            Controls.Add(label1);
            Name = "UserList";
            Text = "UserList";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private AntdUI.Table table1;
    }
}