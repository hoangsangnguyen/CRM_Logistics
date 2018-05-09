using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class init_express : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Express",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CW = table.Column<double>(nullable: false),
                    GW = table.Column<double>(nullable: false),
                    carrierID = table.Column<Guid>(nullable: true),
                    commodityId = table.Column<Guid>(nullable: true),
                    etd = table.Column<DateTime>(nullable: false),
                    flightNumber = table.Column<string>(nullable: true),
                    jobID = table.Column<string>(nullable: false),
                    mawbNumber = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true),
                    opicID = table.Column<Guid>(nullable: true),
                    quantity = table.Column<int>(nullable: false),
                    service = table.Column<string>(nullable: true),
                    unitID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Express", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Express_Carriers_carrierID",
                        column: x => x.carrierID,
                        principalTable: "Carriers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Express_Commodities_commodityId",
                        column: x => x.commodityId,
                        principalTable: "Commodities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Express_Contacts_opicID",
                        column: x => x.opicID,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Express_Units_unitID",
                        column: x => x.unitID,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Express_carrierID",
                table: "Express",
                column: "carrierID");

            migrationBuilder.CreateIndex(
                name: "IX_Express_commodityId",
                table: "Express",
                column: "commodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Express_opicID",
                table: "Express",
                column: "opicID");

            migrationBuilder.CreateIndex(
                name: "IX_Express_unitID",
                table: "Express",
                column: "unitID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Express");
        }
    }
}
