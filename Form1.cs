using System;
using System.Windows.Forms;

namespace AndroidControlApp
{
    public partial class Form1 : Form
    {
        private readonly System.Windows.Forms.Timer _timer;

        public Form1()
        {
            InitializeComponent();
            _timer = new System.Windows.Forms.Timer { Interval = 5000 }; // 5 seconds
            _timer.Tick += (s, e) => {
                _timer.Stop();
                this.Hide();
                new Form2().Show();  // Open Form2
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _timer.Start(); // Start countdown
        }
    }
}