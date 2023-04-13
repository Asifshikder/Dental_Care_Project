using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;
using Project.Core.Domain.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Procedures
{
    public class SubscriptionProcedure
    {
        public SubscriptionProcedure(MigrationBuilder builder)
        {
            var sp = $@"CREATE PROCEDURE [dbo].[{ProcedureConstants.GetAllSubscriptionPlans}]
                    AS
                    BEGIN
                          select * from SubscriptionPlans
                    END";

            builder.Sql(sp);
        }
    }

}
