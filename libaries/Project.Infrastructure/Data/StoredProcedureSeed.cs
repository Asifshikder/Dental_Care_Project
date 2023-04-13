using Microsoft.EntityFrameworkCore.Migrations;
using Project.Infrastructure.Procedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Data
{
    public class StoredProcedureSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            new SubscriptionProcedure(migrationBuilder);
        }
    }
}
