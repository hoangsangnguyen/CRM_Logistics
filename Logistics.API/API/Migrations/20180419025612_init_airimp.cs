using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class init_airimp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirImps",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CW = table.Column<double>(nullable: false),
                    GW = table.Column<double>(nullable: false),
                    Routing = table.Column<string>(nullable: true),
                    SCN = table.Column<string>(nullable: true),
                    agentID = table.Column<Guid>(nullable: false),
                    commodityId = table.Column<Guid>(nullable: true),
                    created = table.Column<DateTime>(nullable: false),
                    eta = table.Column<DateTime>(nullable: false),
                    flightNumber = table.Column<string>(nullable: true),
                    isFinish = table.Column<bool>(nullable: false),
                    jobID = table.Column<string>(nullable: false),
                    mawbNumber = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true),
                    opicID = table.Column<Guid>(nullable: true),
                    quantity = table.Column<int>(nullable: false),
                    service = table.Column<string>(nullable: true),
                    shipmentID = table.Column<Guid>(nullable: true),
                    unitID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirImps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirImps_Carriers_agentID",
                        column: x => x.agentID,
                        principalTable: "Carriers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AirImps_Commodities_commodityId",
                        column: x => x.commodityId,
                        principalTable: "Commodities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AirImps_Contacts_opicID",
                        column: x => x.opicID,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AirImps_Shipments_shipmentID",
                        column: x => x.shipmentID,
                        principalTable: "Shipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AirImps_Units_unitID",
                        column: x => x.unitID,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AirImps_agentID",
                table: "AirImps",
                column: "agentID");

            migrationBuilder.CreateIndex(
                name: "IX_AirImps_commodityId",
                table: "AirImps",
                column: "commodityId");

            migrationBuilder.CreateIndex(
                name: "IX_AirImps_opicID",
                table: "AirImps",
                column: "opicID");

            migrationBuilder.CreateIndex(
                name: "IX_AirImps_shipmentID",
                table: "AirImps",
                column: "shipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_AirImps_unitID",
                table: "AirImps",
                column: "unitID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirImps");
        }
    }
}
