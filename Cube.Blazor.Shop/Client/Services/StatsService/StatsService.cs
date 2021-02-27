using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cube.Blazor.Shop.Client.Services.StatsService
{
    public class StatsService : IStatsService
    {
        private readonly HttpClient httpClient;
        private readonly ILocalStorageService localStorage;

        public StatsService(HttpClient httpClient, ILocalStorageService localStorage)
        {
            this.httpClient = httpClient;
            this.localStorage = localStorage;
        }

        public async Task GetVisits()
        {
            int visits = int.Parse(await this.httpClient.GetStringAsync("api/Stats"));
            Console.WriteLine($"Visits: {visits}");
        }

        public async Task IncrementVisits()
        {
            DateTime? lastVisit = await this.localStorage.GetItemAsync<DateTime?>("lastVisit");
            if(lastVisit == null || ((DateTime)lastVisit).Date != DateTime.Now.Date)
            {
                await this.localStorage.SetItemAsync("lastVisit", DateTime.Now);
                await this.httpClient.PostAsync("api/Stats", null);
            }
        }
    }
}
