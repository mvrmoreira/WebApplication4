using System;
using System.Net.Http;

namespace WebApplication4.Services
{
    public class MyCustomService : IMyCustomService
    {
        private readonly HttpClient _httpClient;

        public MyCustomService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public void DoNothing()
        {
            throw new NotImplementedException();
        }
    }
}
