using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace ProductManagement.Services
{
    internal class ProductService
    {
        private readonly HttpClient _client;

        public ProductService()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7006/api/")
            };
        }

        public List<Product> GetProducts()
        {
            var response = _client.GetAsync("Product").Result;
            if (response.IsSuccessStatusCode)
            {
                // Replace ReadAsAsync with ReadFromJsonAsync
                var products = response.Content.ReadFromJsonAsync<List<Product>>().Result;
                return products;
            }
            return new List<Product>();
        }

        public Product GetProduct(string productCode)
        {
            var response = _client.GetAsync($"Product/{productCode}").Result;
            if (response.IsSuccessStatusCode)
            {
                // Replace ReadAsAsync with ReadFromJsonAsync
                var product = response.Content.ReadFromJsonAsync<Product>().Result;
                return product;
            }
            return null;
        }
    }
}
