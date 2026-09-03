namespace Book_Car_systeam.Book
{
    partial class BookShow
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
            button1 = new AntdUI.Button();
            table1 = new AntdUI.Table();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button1.Location = new Point(47, 480);
            button1.Name = "button1";
            button1.Size = new Size(242, 71);
            button1.TabIndex = 3;
            button1.Text = "新增数据";
            button1.Click += button1_Click;
            // 
            // table1
            // 
            table1.BackColor = SystemColors.Control;
            table1.Gap = 12;
            table1.Location = new Point(47, 27);
            table1.Name = "table1";
            table1.Size = new Size(915, 418);
            table1.TabIndex = 2;
            table1.Text = "table1";
            // 
            // BookShow
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 611);
            Controls.Add(button1);
            Controls.Add(table1);
            Name = "BookShow";
            Text = "BookShow";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button button1;
        private AntdUI.Table table1;
    }
}