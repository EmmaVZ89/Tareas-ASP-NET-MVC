using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVP.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF NOT EXISTS(Select Id from AspNetRoles where Id = '679dadad-d477-4b57-b6cb-a4af5b529fc5')
                                BEGIN
                                INSERT AspNetRoles (Id, [Name], [NormalizedName])
                                VALUES ('679dadad-d477-4b57-b6cb-a4af5b529fc5', 'admin', 'ADMIN')
                                END");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE AspNetRoles WHERE Id = '679dadad-d477-4b57-b6cb-a4af5b529fc5';");
        }
    }
}
