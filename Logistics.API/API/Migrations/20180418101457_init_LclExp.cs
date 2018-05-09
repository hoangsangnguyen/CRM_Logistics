using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class init_LclExp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LclExps",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CBM = table.Column<double>(nullable: false),
                    GW = table.Column<double>(nullable: false),
                    agentId = table.Column<Guid>(nullable: true),
                    bkgNumber = table.Column<string>(nullable: true),
                    commodityId = table.Column<Guid>(nullable: true),
                    created = table.Column<DateTime>(nullable: false),
                    eta = table.Column<DateTime>(nullable: false),
                    etd = table.Column<DateTime>(nullable: false),
                    freightId = table.Column<Guid>(nullable: true),
                    isFinish = table.Column<bool>(nullable: false),
                    jobID = table.Column<string>(nullable: false),
                    mBL = table.Column<string>(nullable: true),
                    mBLNumberId = table.Column<Guid>(nullable: true),
                    mMLNumberId = table.Column<Guid>(nullable: true),
                    notes = table.Column<string>(nullable: true),
                    opicID = table.Column<Guid>(nullable: true),
                    packages = table.Column<int>(nullable: false),
                    shipmentId = table.Column<Guid>(nullable: true),
                    unitID = table.Column<Guid>(nullable: true),
                    vesselId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LclExps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LclExps_Carriers_agentId",
                        column: x => x.agentId,
                        principalTable: "Carriers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LclExps_Commodities_commodityId",
                        column: x => x.commodityId,
                        principalTable: "Commodities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LclExps_Freights_freightId",
                        column: x => x.freightId,
                        principalTable: "Freights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LclExps_MBLTypes_mMLNumberId",
                        column: x => x.mMLNumberId,
                        principalTable: "MBLTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LclExps_Contacts_opicID",
                        column: x => x.opicID,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LclExps_Shipments_shipmentId",
                        column: x => x.shipmentId,
                        principalTable: "Shipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LclExps_Units_unitID",
                        column: x => x.unitID,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LclExps_Vessels_vesselId",
                        column: x => x.vesselId,
                        principalTable: "Vessels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LclExps_agentId",
                table: "LclExps",
                column: "agentId");

            migrationBuilder.CreateIndex(
                name: "IX_LclExps_commodityId",
                table: "LclExps",
                column: "commodityId");

            migrationBuilder.CreateIndex(
                name: "IX_LclExps_freightId",
                table: "LclExps",
                column: "freightId");

            migrationBuilder.CreateIndex(
                name: "IX_LclExps_mMLNumberId",
                table: "LclExps",
                column: "mMLNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_LclExps_opicID",
                table: "LclExps",
                column: "opicID");

            migrationBuilder.CreateIndex(
                name: "IX_LclExps_shipmentId",
                table: "LclExps",
                column: "shipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_LclExps_unitID",
                table: "LclExps",
                column: "unitID");

            migrationBuilder.CreateIndex(
                name: "IX_LclExps_vesselId",
                table: "LclExps",
                column: "vesselId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LclExps");
        }
    }
}
