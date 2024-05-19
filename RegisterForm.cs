using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Modul4
{
    public partial class RegisterForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string apiBaseUrl = "https://localhost:7131";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            var registerData = new { username = txtUsername.Text, password = txtPassword.Text };
            var content = new StringContent(JsonConvert.SerializeObject(registerData), Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{apiBaseUrl}/register", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Registration successful.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed.");
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
