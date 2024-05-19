using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json;

namespace Modul4
{
    public partial class UpdateForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string apiBaseUrl = "https://localhost:7131";

        public UpdateForm()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var id = txtId.Text;
            var product = new { name = txtName.Text, price = txtPrice.Text, stock = txtStock.Text };
            var content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{apiBaseUrl}/products/{id}", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Product updated.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update product.");
            }
        }
    }
}
