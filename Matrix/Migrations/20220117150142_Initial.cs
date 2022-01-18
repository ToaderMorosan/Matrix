using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Matrix.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ocupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    github = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    instagram = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Studies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Interval = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Studies_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Description", "Name", "Ocupation", "PhoneNumber", "address", "email", "github", "instagram" },
                values: new object[,]
                {
                    { new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"), "llllllllll", "iiiiiii", "iiiiiii", "iiiiiii", "iiiiiii", "iiiiiii", "iiiiiii", "iiiiiii" },
                    { new Guid("119f9ccb-149d-4d3c-ad4f-40100f38e918"), "llllllllll", "ddddddddd", "ddddddddd", "ddddddddd", "ddddddddd", "ddddddddd", "ddddddddd", "ddddddddd" },
                    { new Guid("28c1db41-f104-46e6-8943-d31c0291e0e3"), "llllllllll", "cccccccccc", "cccccccccc", "cccccccccc", "cccccccccc", "cccccccccc", "cccccccccc", "cccccccccc" },
                    { new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), "llllllllll", "jjjjjjjjjjj", "jjjjjjjjjjj", "jjjjjjjjjjj", "jjjjjjjjjjj", "jjjjjjjjjjj", "jjjjjjjjjjj", "jjjjjjjjjjj" },
                    { new Guid("2aadd2df-7caf-45ab-9355-7f6332985a87"), "llllllllll", "gggggggg", "gggggggg", "gggggggg", "gggggggg", "gggggggg", "gggggggg", "gggggggg" },
                    { new Guid("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"), "llllllllll", "fffffffffffff", "fffffffffffff", "fffffffffffff", "fffffffffffff", "fffffffffffff", "fffffffffffff", "fffffffffffff" },
                    { new Guid("380c2c6b-0d1c-4b82-9d83-3cf635a3e62b"), "llllllllll", "aaaaaaaaa", "aaaaaaaaa", "aaaaaaaaa", "aaaaaaaaa", "aaaaaaaaa", "boscaaaaaaaaahetar", "aaaaaaaaa" },
                    { new Guid("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"), "llllllllll", "hhhhhhhhh", "hhhhhhhhh", "hhhhhhhhh", "hhhhhhhhh", "hhhhhhhhh", "hhhhhhhhh", "hhhhhhhhh" },
                    { new Guid("71838f8b-6ab3-4539-9e67-4e77b8ede1c0"), "llllllllll", "eeeeeeee", "eeeeeeee", "eeeeeeee", "eeeeeeee", "eeeeeeee", "eeeeeeee", "eeeeeeee" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "llllllllll", "llllllllll", "llllllllll", "llllllllll", "llllllllll", "llllllllll", "llllllllll", "llllllllll" },
                    { new Guid("d94a64c2-2e8f-4162-9976-0ffe03d30767"), "llllllllll", "bbbbbbbbbb", "bbbbbbbbbb", "bbbbbbbbbb", "bbbbbbbbbb", "bbbbbbbbbb", "bbbbbbbbbb", "bbbbbbbbbb" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "llllllllll", "kkkkkkkkkk", "kkkkkkkkkk", "kkkkkkkkkk", "kkkkkkkkkk", "kkkkkkkkkk", "kkkkkkkkkk", "kkkkkkkkkk" }
                });

            migrationBuilder.InsertData(
                table: "Studies",
                columns: new[] { "Id", "EmployeeId", "Interval", "Location", "Name" },
                values: new object[,]
                {
                    { new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"), new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), "2002-2022", "In this course you'll learn how to sing all-time favourite pirate songs without sounding like you actually know the words or how to hold a note.", "Singalong Pirate Hits" },
                    { new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "2002-2022", "Commandeering a ship in rough waters isn't easy.  Commandeering it without getting caught is even harder.  In this course you'll learn how to sail away and avoid those pesky musketeers.", "Commandeering a Ship Without Getting Caught" },
                    { new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "2002-2022", "Every good pirate loves rum, but it also has a tendency to get you into trouble.  In this course you'll learn how to avoid that.  This new exclusive edition includes an additional chapter on how to run fast without falling while drunk.", "Avoiding Brawls While Drinking as Much Rum as You Desire" },
                    { new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "2002-2022", "In this course, the author provides tips to avoid, or, if needed, overthrow pirate mutiny.", "Overthrowing Mutiny" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Studies_EmployeeId",
                table: "Studies",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studies");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
