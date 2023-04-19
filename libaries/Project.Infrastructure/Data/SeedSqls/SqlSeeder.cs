using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Project.Infrastructure.Sql.Constants;
using Project.Infrastructure.Sql.Procedures.root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Data.SeedSqls
{
    public class SqlSeeder
    {
        public static async Task Seed(ApplicationDbContext context)
        {

            //var procedures = typeof(StoreProcedures).GetFields();

            IEnumerable<ProcedureDefination> classnames = typeof(ProcedureDefination).Assembly.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(ProcedureDefination)) && !t.IsAbstract)
                .Select(t => (ProcedureDefination)Activator.CreateInstance(t));

            await DeleteProcedures(context);

            foreach (ProcedureDefination item in classnames)
            {
                var procedures = item.GetType().GetFields();
                foreach (var p in procedures)
                {
                    var value = p.GetRawConstantValue();
                    if (value != null)
                    {
                        await context.Database.ExecuteSqlRawAsync(value.ToString(), new object[0]);
                        await context.SaveChangesAsync();

                    }
                }
            }
        }

        public static async Task DeleteProcedures(ApplicationDbContext context)
        {
            var procedureNames = typeof(ProcedureConstants).GetFields();
            foreach (var p in procedureNames)
            {
                string query = $@"IF EXISTS(SELECT 1 FROM sys.procedures  WHERE object_id = OBJECT_ID(N'dbo.[" + p.GetRawConstantValue().ToString() + "]')) BEGIN  DROP PROCEDURE " + p.GetRawConstantValue().ToString() + " END";
                await context.Database.ExecuteSqlRawAsync(query);
            }
            await context.SaveChangesAsync();

        }
    }
}
