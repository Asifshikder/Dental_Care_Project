using Project.Infrastructure.Sql.Constants;
using Project.Infrastructure.Sql.Procedures.root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Sql.Procedures
{
    public class BloodGroupProcedures:ProcedureDefination
    {
        public const string GetAllBloodGroups = $@"CREATE PROCEDURE [dbo].[" + ProcedureConstants.GetAllBloodGroups + "] AS BEGIN select * from BloodGroups END";

    }
}
