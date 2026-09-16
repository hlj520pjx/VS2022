namespace WinFormsApp1.bookfn
{
    partial class bookedit
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
            uCbook1 = new UCbook();
            SuspendLayout();
            // 
            // uCbook1
            // 
            uCbook1.Location = new Point(2, 1);
            uCbook1.Name = "uCbook1";
            uCbook1.Size = new Size(624, 655);
            uCbook1.TabIndex = 0;
            // 
            // bookedit
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 666);
            Controls.Add(uCbook1);
            Name = "bookedit";
            Text = "bookedit";
            ResumeLayout(false);
        }

        #endregion

        private UCbook uCbook1;
    }
}