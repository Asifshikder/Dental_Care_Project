using Project.Infrastructure.Sql.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Sql.Procedures
{
    public class StoreProcedures
    {
        public const string GetAllSubscriptionPlans = $@"CREATE PROCEDURE [dbo].[" + ProcedureConstants.GetAllSubscriptionPlans + "] AS BEGIN select * from SubscriptionPlans END";
        public const string GetAllBloodGroups = $@"CREATE PROCEDURE [dbo].[" + ProcedureConstants.GetAllBloodGroups + "] AS BEGIN select * from BloodGroups END";
    }
}
