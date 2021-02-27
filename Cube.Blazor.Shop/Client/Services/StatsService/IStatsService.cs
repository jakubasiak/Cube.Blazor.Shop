using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cube.Blazor.Shop.Client.Services.StatsService
{
    public interface IStatsService
    {
        Task GetVisits();
        Task IncrementVisits();
    }
}
