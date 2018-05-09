using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class init_FclExp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FclExps",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CBM = table.Column<double>(nullable: false),
                    GW = table.Column<double>(nullable: false),
                    Services = table.Column<string>(nullable: true),
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
                    mMLNumberId = table.Column<Guid>(nullable: true),
                    notes = table.Column<string>(nullable: true),
                    opicID = table.Column<Guid>(nullable: true),
                    poNumber = table.Column<string>(nullable: true),
                    sLinesId = table.Column<Guid>(nullable: true),
                    shipmentId = table.Column<Guid>(nullable: true),
                    vesselId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FclExps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FclExps_Carriers_agentId",
                        column: x => x.agentId,
                        principalTable: "Carriers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FclExps_Commodities_commodityId",
                        column: x => x.commodityId,
                        principalTable: "Commodities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FclExps_Freights_freightId",
                        column: x => x.freightId,
                        principalTable: "Freights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FclExps_MBLTypes_mMLNumberId",
                        column: x => x.mMLNumberId,
                        principalTable: "MBLTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FclExps_Contacts_opicID",
                        column: x => x.opicID,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FclExps_Shipments_shipmentId",
                        column: x => x.shipmentId,
                        principalTable: "Shipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FclExps_Vessels_vesselId",
                        column: x => x.vesselId,
                        principalTable: "Vessels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FclExps_agentId",
                table: "FclExps",
                column: "agentId");

            migrationBuilder.CreateIndex(
                name: "IX_FclExps_commodityId",
                table: "FclExps",
                column: "commodityId");

            migrationBuilder.CreateIndex(
                name: "IX_FclExps_freightId",
                table: "FclExps",
                column: "freightId");

            migrationBuilder.CreateIndex(
                name: "IX_FclExps_mMLNumberId",
                table: "FclExps",
                column: "mMLNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_FclExps_opicID",
                table: "FclExps",
                column: "opicID");

            migrationBuilder.CreateIndex(
                name: "IX_FclExps_shipmentId",
                table: "FclExps",
                column: "shipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_FclExps_vesselId",
                table: "FclExps",
                column: "vesselId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FclExps");
        }
    }
}
