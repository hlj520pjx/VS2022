namespace _05day
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
            price = new ComboBox();
            times = new ComboBox();
            SuspendLayout();
            // 
            // price
            // 
            price.FormattingEnabled = true;
            price.Location = new Point(222, 123);
            price.Name = "price";
            price.Size = new Size(151, 28);
            price.TabIndex = 0;
            price.Text = "按价格排序";
            // 
            // times
            // 
            times.FormattingEnabled = true;
            times.Location = new Point(457, 123);
            times.Name = "times";
            times.Size = new Size(151, 28);
            times.TabIndex = 1;
            times.Text = "按时间排序";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 439);
            Controls.Add(times);
            Controls.Add(price);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox price;
        private ComboBox times;
    }
}