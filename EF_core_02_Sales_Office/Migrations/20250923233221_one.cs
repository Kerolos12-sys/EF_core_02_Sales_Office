using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_core_02_Sales_Office.Migrations
{
    /// <inheritdoc />
    public partial class one : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesOfficeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales_Office",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales_Office", x => x.Number);
                    table.ForeignKey(
                        name: "FK_Sales_Office_Employee_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<int>(type: "int", nullable: true),
                    SalesOfficeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Property_Sales_Office_SalesOfficeId",
                        column: x => x.SalesOfficeId,
                        principalTable: "Sales_Office",
                        principalColumn: "Number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Owned_Property",
                columns: table => new
                {
                    Property_id = table.Column<int>(type: "int", nullable: false),
                    Owner_id = table.Column<int>(type: "int", nullable: false),
                    Precent = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owned_Property", x => new { x.Owner_id, x.Property_id });
                    table.ForeignKey(
                        name: "FK_Owned_Property_Owner_Owner_id",
                        column: x => x.Owner_id,
                        principalTable: "Owner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Owned_Property_Property_Property_id",
                        column: x => x.Property_id,
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_SalesOfficeId",
                table: "Employee",
                column: "SalesOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Owned_Property_Property_id",
                table: "Owned_Property",
                column: "Property_id");

            migrationBuilder.CreateIndex(
                name: "IX_Property_SalesOfficeId",
                table: "Property",
                column: "SalesOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_Office_ManagerId",
                table: "Sales_Office",
                column: "ManagerId",
                unique: true,
                filter: "[ManagerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Sales_Office_SalesOfficeId",
                table: "Employee",
                column: "SalesOfficeId",
                principalTable: "Sales_Office",
                principalColumn: "Number");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Sales_Office_SalesOfficeId",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "Owned_Property");

            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "Sales_Office");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
