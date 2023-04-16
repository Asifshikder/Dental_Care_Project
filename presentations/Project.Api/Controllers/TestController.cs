using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Infrastructure.Data;
using Project.Infrastructure.Data.SeedSqls;
using Project.Services.Features.BloodGroups.Queries;

namespace Project.Api.Controllers
{
    public class TestController : BaseController
    {
        private readonly ApplicationDbContext context;

        public TestController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllBloodGroupQuery()));
        }
        [HttpGet]
        [Route("db")]
        public async Task<IActionResult> db()
        {
            await SqlSeeder.Seed(context);
            return Ok();
        }
    }
}
