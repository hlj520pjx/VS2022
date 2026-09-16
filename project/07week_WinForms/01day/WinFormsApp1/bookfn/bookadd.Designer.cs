namespace WinFormsApp1.bookfn
{
    partial class bookadd
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
            uCbook1.Location = new Point(0, 2);
            uCbook1.Name = "uCbook1";
            uCbook1.Size = new Size(642, 641);
            uCbook1.TabIndex = 0;
            // 
            // bookadd
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 709);
            Controls.Add(uCbook1);
            Name = "bookadd";
            Text = "bookadd";
            ResumeLayout(false);
        }

        #endregion

        private UCbook uCbook1;
    }
}