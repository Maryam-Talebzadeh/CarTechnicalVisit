using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infra.DB.SqlServer.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_carModels_ModelId",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_carModels",
                table: "carModels");

            migrationBuilder.RenameTable(
                name: "carModels",
                newName: "CarModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarModels",
                table: "CarModels",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Operators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalId = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operators", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarModels_ModelId",
                table: "Cars",
                column: "ModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarModels_ModelId",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "Operators");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarModels",
                table: "CarModels");

            migrationBuilder.RenameTable(
                name: "CarModels",
                newName: "carModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_carModels",
                table: "carModels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_carModels_ModelId",
                table: "Cars",
                column: "ModelId",
                principalTable: "carModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
