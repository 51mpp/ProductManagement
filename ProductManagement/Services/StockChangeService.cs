using Newtonsoft.Json;
using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Services
{
    internal class StockChangeService
    {
        private readonly HttpClient _client;

        public StockChangeService( )
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7006/api/")
            };
        }
            public List<StockChange> GetStockChanges()
            {
                var response = _client.GetAsync("StockChange").Result;
                if (response.IsSuccessStatusCode)
                {
                    // Replace ReadAsAsync with ReadFromJsonAsync
                    var stockChanges = response.Content.ReadFromJsonAsync<List<StockChange>>().Result;
                    return stockChanges;
                }
                return new List<StockChange>();
            }
    
            public void AddStockChange(StockChange stockChange)
            {
                var response = _client.PostAsJsonAsync("StockChange", stockChange).Result;
                if (!response.IsSuccessStatusCode)
                {
                    var responseBody = response.Content.ReadAsStringAsync().Result;
                    dynamic errorResponse = JsonConvert.DeserializeObject(responseBody);
                    string errorMessage = errorResponse?.error ?? "เกิดข้อผิดพลาด";
                    throw new Exception("ไม่สามารถทำการอัปเดทสต็อกได้: " + errorMessage);

                }

        }
    }
}
