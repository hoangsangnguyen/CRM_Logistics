using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Logistics.Migrations
{
    public partial class initdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Commodities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commodities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    _key = table.Column<string>(maxLength: 50, nullable: true),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Freights",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Freights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MBLTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBLTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfBills",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfBills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vessels",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vessels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carriers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    fullName_EN = table.Column<string>(nullable: false),
                    Contact = table.Column<string>(nullable: true),
                    Cell = table.Column<string>(nullable: true),
                    countryID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carriers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carriers_Nationalities_countryID",
                        column: x => x.countryID,
                        principalTable: "Nationalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    contactID = table.Column<string>(maxLength: 50, nullable: false),
                    firstName = table.Column<string>(maxLength: 50, nullable: false),
                    lastName = table.Column<string>(maxLength: 50, nullable: false),
                    englishName = table.Column<string>(maxLength: 50, nullable: false),
                    positionID = table.Column<Guid>(nullable: false),
                    homeAddress = table.Column<string>(nullable: true),
                    cellPhone = table.Column<string>(nullable: true),
                    homePhone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    company_ext = table.Column<string>(nullable: true),
                    signature = table.Column<string>(nullable: true),
                    departmentID = table.Column<Guid>(nullable: false),
                    birthday = table.Column<DateTime>(nullable: false),
                    marriageStatus = table.Column<bool>(nullable: false),
                    spouseName = table.Column<string>(nullable: true),
                    spouseBirthday = table.Column<DateTime>(nullable: false),
                    fieldInterested = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Departments_departmentID",
                        column: x => x.departmentID,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacts_Positions_positionID",
                        column: x => x.positionID,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ports",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    portName = table.Column<string>(nullable: false),
                    nationalityID = table.Column<Guid>(nullable: false),
                    zoneID = table.Column<Guid>(nullable: false),
                    localZone = table.Column<string>(nullable: false),
                    modeID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ports_Modes_modeID",
                        column: x => x.modeID,
                        principalTable: "Modes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ports_Nationalities_nationalityID",
                        column: x => x.nationalityID,
                        principalTable: "Nationalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ports_Zones_zoneID",
                        column: x => x.zoneID,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AirExps",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    JobID = table.Column<string>(nullable: false),
                    created = table.Column<DateTime>(nullable: false),
                    service = table.Column<string>(nullable: true),
                    etd = table.Column<DateTime>(nullable: false),
                    eta = table.Column<DateTime>(nullable: false),
                    commodityId = table.Column<Guid>(nullable: true),
                    mawbNumber = table.Column<string>(nullable: true),
                    typeOfBill = table.Column<Guid>(nullable: true),
                    typeOfBillId = table.Column<Guid>(nullable: true),
                    flightNumber = table.Column<string>(nullable: true),
                    flyDate = table.Column<DateTime>(nullable: false),
                    opicID = table.Column<Guid>(nullable: true),
                    shipmentID = table.Column<Guid>(nullable: true),
                    quantity = table.Column<int>(nullable: false),
                    unitID = table.Column<Guid>(nullable: true),
                    paymentID = table.Column<Guid>(nullable: true),
                    isFinish = table.Column<bool>(nullable: false),
                    carrierID = table.Column<Guid>(nullable: true),
                    notes = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirExps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirExps_Carriers_carrierID",
                        column: x => x.carrierID,
                        principalTable: "Carriers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AirExps_Commodities_commodityId",
                        column: x => x.commodityId,
                        principalTable: "Commodities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AirExps_Contacts_opicID",
                        column: x => x.opicID,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AirExps_Payments_paymentID",
                        column: x => x.paymentID,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AirExps_Shipments_shipmentID",
                        column: x => x.shipmentID,
                        principalTable: "Shipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AirExps_TypeOfBills_typeOfBill",
                        column: x => x.typeOfBill,
                        principalTable: "TypeOfBills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AirExps_Units_unitID",
                        column: x => x.unitID,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AirImps",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    jobID = table.Column<string>(nullable: false),
                    created = table.Column<DateTime>(nullable: false),
                    eta = table.Column<DateTime>(nullable: false),
                    mawbNumber = table.Column<string>(nullable: true),
                    flightNumber = table.Column<string>(nullable: true),
                    commodityId = table.Column<Guid>(nullable: true),
                    shipmentID = table.Column<Guid>(nullable: true),
                    isFinish = table.Column<bool>(nullable: false),
                    opicID = table.Column<Guid>(nullable: true),
                    service = table.Column<string>(nullable: true),
                    quantity = table.Column<int>(nullable: false),
                    unitID = table.Column<Guid>(nullable: true),
                    GW = table.Column<double>(nullable: false),
                    CW = table.Column<double>(nullable: false),
                    agentID = table.Column<Guid>(nullable: false),
                    Routing = table.Column<string>(nullable: true),
                    SCN = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirImps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirImps_Carriers_agentID",
                        column: x => x.agentID,
                        principalTable: "Carriers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "Express",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    jobID = table.Column<string>(nullable: false),
                    etd = table.Column<DateTime>(nullable: false),
                    eta = table.Column<DateTime>(nullable: false),
                    mawbNumber = table.Column<string>(nullable: true),
                    flightNumber = table.Column<string>(nullable: true),
                    opicID = table.Column<Guid>(nullable: true),
                    service = table.Column<string>(nullable: true),
                    commodityId = table.Column<Guid>(nullable: true),
                    quantity = table.Column<int>(nullable: false),
                    unitID = table.Column<Guid>(nullable: true),
                    GW = table.Column<double>(nullable: false),
                    CW = table.Column<double>(nullable: false),
                    carrierID = table.Column<Guid>(nullable: true),
                    notes = table.Column<string>(nullable: true)
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

            migrationBuilder.CreateTable(
                name: "FclExps",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    jobID = table.Column<string>(nullable: false),
                    created = table.Column<DateTime>(nullable: false),
                    etd = table.Column<DateTime>(nullable: false),
                    bkgNumber = table.Column<string>(nullable: true),
                    mBL = table.Column<string>(nullable: true),
                    eta = table.Column<DateTime>(nullable: false),
                    poNumber = table.Column<string>(nullable: true),
                    mMLNumberId = table.Column<Guid>(nullable: true),
                    mBLNumberId = table.Column<Guid>(nullable: true),
                    vesselId = table.Column<Guid>(nullable: true),
                    shipmentId = table.Column<Guid>(nullable: true),
                    freightId = table.Column<Guid>(nullable: true),
                    opicID = table.Column<Guid>(nullable: true),
                    isFinish = table.Column<bool>(nullable: false),
                    agentId = table.Column<Guid>(nullable: true),
                    commodityId = table.Column<Guid>(nullable: true),
                    Service = table.Column<string>(nullable: true),
                    GW = table.Column<double>(nullable: false),
                    CBM = table.Column<double>(nullable: false),
                    notes = table.Column<string>(nullable: true)
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

            migrationBuilder.CreateTable(
                name: "LclExps",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    jobID = table.Column<string>(nullable: false),
                    created = table.Column<DateTime>(nullable: false),
                    etd = table.Column<DateTime>(nullable: false),
                    eta = table.Column<DateTime>(nullable: false),
                    bkgNumber = table.Column<string>(nullable: true),
                    mBL = table.Column<string>(nullable: true),
                    mMLNumberId = table.Column<Guid>(nullable: true),
                    mBLNumberId = table.Column<Guid>(nullable: true),
                    isFinish = table.Column<bool>(nullable: false),
                    opicID = table.Column<Guid>(nullable: true),
                    vesselId = table.Column<Guid>(nullable: true),
                    shipmentId = table.Column<Guid>(nullable: true),
                    GW = table.Column<double>(nullable: false),
                    CBM = table.Column<double>(nullable: false),
                    packages = table.Column<int>(nullable: false),
                    unitID = table.Column<Guid>(nullable: true),
                    agentId = table.Column<Guid>(nullable: true),
                    commodityId = table.Column<Guid>(nullable: true),
                    freightId = table.Column<Guid>(nullable: true),
                    notes = table.Column<string>(nullable: true)
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
                name: "IX_AirExps_carrierID",
                table: "AirExps",
                column: "carrierID");

            migrationBuilder.CreateIndex(
                name: "IX_AirExps_commodityId",
                table: "AirExps",
                column: "commodityId");

            migrationBuilder.CreateIndex(
                name: "IX_AirExps_opicID",
                table: "AirExps",
                column: "opicID");

            migrationBuilder.CreateIndex(
                name: "IX_AirExps_paymentID",
                table: "AirExps",
                column: "paymentID");

            migrationBuilder.CreateIndex(
                name: "IX_AirExps_shipmentID",
                table: "AirExps",
                column: "shipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_AirExps_typeOfBill",
                table: "AirExps",
                column: "typeOfBill");

            migrationBuilder.CreateIndex(
                name: "IX_AirExps_unitID",
                table: "AirExps",
                column: "unitID");

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

            migrationBuilder.CreateIndex(
                name: "IX_Carriers_countryID",
                table: "Carriers",
                column: "countryID");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_contactID",
                table: "Contacts",
                column: "contactID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_departmentID",
                table: "Contacts",
                column: "departmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_positionID",
                table: "Contacts",
                column: "positionID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments__key",
                table: "Departments",
                column: "_key",
                unique: true,
                filter: "[_key] IS NOT NULL");

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

            migrationBuilder.CreateIndex(
                name: "IX_Ports_modeID",
                table: "Ports",
                column: "modeID");

            migrationBuilder.CreateIndex(
                name: "IX_Ports_nationalityID",
                table: "Ports",
                column: "nationalityID");

            migrationBuilder.CreateIndex(
                name: "IX_Ports_zoneID",
                table: "Ports",
                column: "zoneID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirExps");

            migrationBuilder.DropTable(
                name: "AirImps");

            migrationBuilder.DropTable(
                name: "Express");

            migrationBuilder.DropTable(
                name: "FclExps");

            migrationBuilder.DropTable(
                name: "LclExps");

            migrationBuilder.DropTable(
                name: "Ports");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "TypeOfBills");

            migrationBuilder.DropTable(
                name: "Carriers");

            migrationBuilder.DropTable(
                name: "Commodities");

            migrationBuilder.DropTable(
                name: "Freights");

            migrationBuilder.DropTable(
                name: "MBLTypes");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Shipments");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Vessels");

            migrationBuilder.DropTable(
                name: "Modes");

            migrationBuilder.DropTable(
                name: "Zones");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Positions");
        }
    }
}
