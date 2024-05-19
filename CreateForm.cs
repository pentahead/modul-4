using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Modul4
{
    public partial class CreateForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string apiBaseUrl = "https://localhost:7131";

        public CreateForm()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var product = new { name = txtName.Text, price = txtPrice.Text, stock = txtStock.Text };
            var content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{apiBaseUrl}/products", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Product created.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to create product.");
            }
        }
    }
}
