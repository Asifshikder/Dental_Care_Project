using Microsoft.EntityFrameworkCore.Migrations;
using Project.Infrastructure.Procedures;

#nullable disable

namespace Project.Infrastructure.Migrations
{
    public partial class apply_procedures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            new SubscriptionProcedure(migrationBuilder);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
