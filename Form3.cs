using System;
using System.Drawing;
using System.Windows.Forms;

namespace AndroidControlApp
{
    public partial class Form3 : Form
    {
        private TextBox outputBox;
        private ADBHelper adb;

        public Form3()
        {
            InitializeComponent();
            adb = new ADBHelper();
            BuildUI();
        }

        private void BuildUI()
        {
            this.Text = "ANDROID CONTROL APPLICATION";
            this.Size = new Size(800, 600);

            Label title = new Label
            {
                Text = "Android Data Extraction",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 50,
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(title);

            FlowLayoutPanel buttonPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 60,
                FlowDirection = FlowDirection.LeftToRight
            };

            Button btnContacts = CreateButton("Get Contacts", (s, e) => ShowOutput(adb.GetContacts()));
            Button btnSMS = CreateButton("Get SMS", (s, e) => ShowOutput(adb.GetSMS()));
            Button btnCallLogs = CreateButton("Get Call Logs", (s, e) => ShowOutput(adb.GetCallLogs()));
            Button btnCPU = CreateButton("Get CPU Info", (s, e) => ShowOutput(adb.GetCPUInfo()));
            Button btnMem = CreateButton("Get Memory Info", (s, e) => ShowOutput(adb.GetMemoryInfo()));

            buttonPanel.Controls.AddRange(new Control[] { btnContacts, btnSMS, btnCallLogs, btnCPU, btnMem });
            this.Controls.Add(buttonPanel);

            outputBox = new TextBox
            {
                Multiline = true,
                Dock = DockStyle.Fill,
                ScrollBars = ScrollBars.Vertical,
                Font = new Font("Consolas", 10),
                ReadOnly = true
            };
            this.Controls.Add(outputBox);
        }

        private Button CreateButton(string text, EventHandler onClick)
        {
            Button btn = new Button
            {
                Text = text,
                Width = 140,
                Height = 40,
                Margin = new Padding(5),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.LightGray
            };

            // Correct event subscription
            btn.Click += onClick;

            return btn;
        }

        private void ShowOutput(string data)
        {
            outputBox.Text = data;
        }
    }
}