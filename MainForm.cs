using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json;

namespace Modul4
{
    public partial class MainForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string apiBaseUrl = "https://localhost:7131";

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            var response = await client.GetAsync($"{apiBaseUrl}/products");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var products = JsonConvert.DeserializeObject<List<Product>>(responseContent);
                dataGridView.DataSource = products;
            }
            else
            {
                MessageBox.Show("Failed to load data.");
            }
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            var createForm = new CreateForm();
            createForm.ShowDialog();
            await LoadDataAsync();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var updateForm = new UpdateForm();
            updateForm.ShowDialog();
            await LoadDataAsync();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var id = txtId.Text;
            var response = await client.DeleteAsync($"{apiBaseUrl}/products/{id}");

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Product deleted.");
                await LoadDataAsync();
            }
            else
            {
                MessageBox.Show("Failed to delete product.");
            }
        }

        private async void btnReadOne_Click(object sender, EventArgs e)
        {
            var id = txtId.Text;
            var response = await client.GetAsync($"{apiBaseUrl}/products/{id}");

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var product = JsonConvert.DeserializeObject<Product>(responseContent);
                MessageBox.Show($"Name: {product.Name}\nPrice: {product.Price}\nStock: {product.Stock}");
            }
            else
            {
                MessageBox.Show("Failed to load product.");
            }
        }

        private async void btnFilter_Click(object sender, EventArgs e)
        {
            var name = txtNameFilter.Text;
            var minPrice = txtMinPriceFilter.Text;
            var maxPrice = txtMaxPriceFilter.Text;
            var minStock = txtMinStockFilter.Text;
            var maxStock = txtMaxStockFilter.Text;

            var response = await client.GetAsync($"{apiBaseUrl}/products?name={name}&min_price={minPrice}&max_price={maxPrice}&min_stock={minStock}&max_stock={maxStock}");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var products = JsonConvert.DeserializeObject<List<Product>>(responseContent);
                dataGridView.DataSource = products;
            }
            else
            {
                MessageBox.Show("Failed to load filtered data.");
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
