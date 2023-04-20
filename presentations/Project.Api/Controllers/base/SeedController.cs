using Microsoft.AspNetCore.Mvc;
using Project.Infrastructure.Data;
using Project.Infrastructure.Data.SeedSqls;
using Project.Services.SeedData;

namespace Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly ISeedDataService seedDataService;

        public SeedController(ApplicationDbContext context,ISeedDataService seedDataService)
        {
            this.context = context;
            this.seedDataService = seedDataService;
        }
        [HttpGet]
        [Route("Sql")]
        public async Task<IActionResult> ApplySqlPrerequisits()
        {
            await SqlSeeder.Seed(context);
            return Ok();
        }
        [HttpGet]
        [Route("CoreData")]
        public async Task<IActionResult> ApplyCoreData()
        {
            await seedDataService.SeedCoreData();
            return Ok();
        }
    }
}
