using Microsoft.AspNetCore.Mvc;
using Project.Infrastructure.Data;
using Project.Infrastructure.Data.SeedSqls;

namespace Project.Api.Controllers
{
    public class SeedController : Controller
    {
        private readonly ApplicationDbContext context;

        public SeedController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> ApplySqlPrerequisits()
        {
            await SqlSeeder.Seed(context);
            return Ok();
        }
    }
}
