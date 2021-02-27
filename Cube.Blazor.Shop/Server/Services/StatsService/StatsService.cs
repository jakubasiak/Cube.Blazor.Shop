using Cube.Blazor.Shop.Server.Data;
using Cube.Blazor.Shop.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cube.Blazor.Shop.Server.Services.StatsService
{
    public class StatsService : IStatsService
    {
        private readonly DataContext context;

        public StatsService(DataContext context)
        {
            this.context = context;
        }

        public async Task<int> GetVisits()
        {
            var stats = await this.context.Stats.FirstOrDefaultAsync();
            if(stats == null)
            {
                return 0;
            }
            return stats.Visits;
        }

        public async Task IncrementVisits()
        {
            var stats = await this.context.Stats.FirstOrDefaultAsync();
            if (stats == null)
            {
                this.context.Stats.Add(new Stats()
                {
                    Visits = 1,
                    LastVisit = DateTime.Now
                });
            }
            else
            {
                stats.Visits++;
                stats.LastVisit = DateTime.Now;
            }

            await this.context.SaveChangesAsync();
        }
    }
}
