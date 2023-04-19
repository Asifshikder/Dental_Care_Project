using Project.Infrastructure.Sql.Constants;
using Project.Infrastructure.Sql.Procedures.root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Sql.Procedures
{
    public class SubsciptionProcedures:ProcedureDefination
    {
        public const string GetAllSubscriptionPlans = $@"CREATE PROCEDURE [dbo].[" + ProcedureConstants.GetAllSubscriptionPlans + "] AS BEGIN select * from SubscriptionPlans END";
        public const string GetAllSubscriptionPlans2 = $@"CREATE PROCEDURE [dbo].[" + ProcedureConstants.GetAllSubscriptionPlans + "] AS BEGIN select * from SubscriptionPlans END";
        public const string GetAllSubscriptionPlans3 = $@"CREATE PROCEDURE [dbo].[" + ProcedureConstants.GetAllSubscriptionPlans + "] AS BEGIN select * from SubscriptionPlans END";

    }
}


