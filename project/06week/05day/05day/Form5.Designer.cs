namespace _05day
{
    partial class Form5
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
            button1 = new Button();
            rebtn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(338, 85);
            button1.Name = "button1";
            button1.Size = new Size(125, 121);
            button1.TabIndex = 0;
            button1.Text = "拖拽";
            button1.UseVisualStyleBackColor = true;
            // 
            // rebtn
            // 
            rebtn.Location = new Point(324, 364);
            rebtn.Name = "rebtn";
            rebtn.Size = new Size(159, 46);
            rebtn.TabIndex = 1;
            rebtn.Text = "退出";
            rebtn.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rebtn);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button rebtn;
    }
}