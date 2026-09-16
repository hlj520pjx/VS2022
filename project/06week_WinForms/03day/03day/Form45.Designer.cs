namespace _03day
{
    partial class Form45
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
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            labT = new Label();
            labF = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 63);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "手机号码";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 27);
            textBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(42, 129);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(243, 196);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // labT
            // 
            labT.AutoSize = true;
            labT.ForeColor = Color.Lime;
            labT.Location = new Point(291, 63);
            labT.Name = "labT";
            labT.Size = new Size(50, 20);
            labT.TabIndex = 3;
            labT.Text = "通过√";
            // 
            // labF
            // 
            labF.AutoSize = true;
            labF.ForeColor = Color.Red;
            labF.Location = new Point(291, 63);
            labF.Name = "labF";
            labF.Size = new Size(80, 20);
            labF.TabIndex = 4;
            labF.Text = "错误格式×";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(483, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 27);
            textBox2.TabIndex = 5;
            
            // 
            // button1
            // 
            button1.Location = new Point(532, 118);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form45
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(labF);
            Controls.Add(labT);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form45";
            Text = "Form45";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Label labT;
        private Label labF;
        private TextBox textBox2;
        private Button button1;
    }
}