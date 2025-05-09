namespace AndroidControlApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelWelcome;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelWelcome = new Label();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Location = new Point(207, 74);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(196, 20);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "WELCOME TO MY ANDROID";
            // 
            // Form1
            // 
            BackColor = Color.Honeydew;
            ClientSize = new Size(657, 200);
            Controls.Add(labelWelcome);
            Name = "Form1";
            Text = "accessing android";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}