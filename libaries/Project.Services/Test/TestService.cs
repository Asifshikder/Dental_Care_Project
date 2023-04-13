using Project.Core.Domain.Common;
using Project.Core.Domain.Subscriptions;
using Project.Infrastructure.DataAccess;
using Project.Infrastructure.Procedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Test
{
    public class TestService : ITestService
    {
        private readonly ISqlService sqlService;

        public TestService(ISqlService sqlService)
        {
            this.sqlService = sqlService;
        }

        public async Task<IEnumerable<SubscriptionPlan>> GetAll()
        {
            var data = await sqlService.QueryAsync<SubscriptionPlan, dynamic>(storedProcedure: ProcedureConstants.GetAllSubscriptionPlans, new { });
            return data;
        }
    }
}
