
using AndroidControlApp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AndroidControlApp
{
    public partial class Form2 : Form
    {
        private Dictionary<string, string> credentials = new Dictionary<string, string>();

        public Form2()
        {
            InitializeComponent();

            // Login button event
            btnLogin.Click += (s, e) =>
            {
                if (Authenticate(txtUsername.Text, txtPassword.Text))
                {
                    this.Hide();
                    new Form3().Show();
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }
            };

            // Add user button event
            btnAddUser.Click += (s, e) =>
            {
                string user = txtUsername.Text;
                string pass = txtPassword.Text;
                if (!credentials.ContainsKey(user))
                {
                    credentials.Add(user, pass);
                    MessageBox.Show("User added successfully!");
                }
                else
                {
                    MessageBox.Show("User already exists!");
                }
            };
        }

        private bool Authenticate(string user, string pass)
        {
            return credentials.ContainsKey(user) && credentials[user] == pass;
        }
    }
}