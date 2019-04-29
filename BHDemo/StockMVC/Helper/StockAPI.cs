using System;
using System.Net.Http;

namespace StockMVC.Helper
{
    public class StockAPI
    {
        public HttpClient Initialize()
        {
            var Client = new HttpClient();
            Client.BaseAddress = new Uri("https://localhost:44339/api/stock");
            return Client;
        }

    }
}
