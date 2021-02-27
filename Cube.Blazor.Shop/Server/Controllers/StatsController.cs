using Cube.Blazor.Shop.Server.Services.StatsService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cube.Blazor.Shop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        private readonly IStatsService statsService;

        public StatsController(IStatsService statsService)
        {
            this.statsService = statsService;
        }

        [HttpGet]
        public async Task<ActionResult<int>> GetVisits()
        {
            return await this.statsService.GetVisits();
        }

        [HttpPost]
        public async Task IncrementVisits()
        {
            await this.statsService.IncrementVisits();
        }
    }
}
