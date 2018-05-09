using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using API.Entities;

namespace API.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20180418101457_init_LclExp")]
    partial class init_LclExp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Entities.AccessiblePageEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Index");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("ValidRoleNames")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("AccessiblePages");
                });

            modelBuilder.Entity("API.Entities.AirExp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("JobID")
                        .IsRequired();

                    b.Property<Guid?>("carrierID");

                    b.Property<Guid?>("commodityId");

                    b.Property<DateTime>("created");

                    b.Property<DateTime>("eta");

                    b.Property<DateTime>("etd");

                    b.Property<string>("flightNumber");

                    b.Property<DateTime>("flyDate");

                    b.Property<string>("mawbNumber");

                    b.Property<Guid?>("opicID");

                    b.Property<Guid?>("paymentID");

                    b.Property<int>("quantity");

                    b.Property<string>("service");

                    b.Property<Guid?>("shipmentID");

                    b.Property<Guid?>("typeOfBill");

                    b.Property<Guid?>("typeOfBillId");

                    b.Property<Guid?>("unitID");

                    b.HasKey("Id");

                    b.HasIndex("carrierID");

                    b.HasIndex("commodityId");

                    b.HasIndex("opicID");

                    b.HasIndex("paymentID");

                    b.HasIndex("shipmentID");

                    b.HasIndex("typeOfBill");

                    b.HasIndex("unitID");

                    b.ToTable("AirExps");
                });

            modelBuilder.Entity("API.Entities.Carrier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cell");

                    b.Property<string>("Contact");

                    b.Property<Guid>("countryID");

                    b.Property<string>("fullName_EN")
                        .IsRequired();

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("countryID");

                    b.ToTable("Carriers");
                });

            modelBuilder.Entity("API.Entities.Commodity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Commodities");
                });

            modelBuilder.Entity("API.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("birthday");

                    b.Property<string>("cellPhone")
                        .IsRequired();

                    b.Property<string>("company_ext")
                        .IsRequired();

                    b.Property<Guid>("departmentID");

                    b.Property<string>("email")
                        .IsRequired();

                    b.Property<string>("englishName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("fieldInterested")
                        .IsRequired();

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("homeAddress")
                        .IsRequired();

                    b.Property<string>("homePhone")
                        .IsRequired();

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("marriageStatus");

                    b.Property<Guid>("positionID");

                    b.Property<string>("signature")
                        .IsRequired();

                    b.Property<DateTime>("spouseBirthday");

                    b.Property<string>("spouseName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("departmentID");

                    b.HasIndex("positionID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("API.Entities.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("API.Entities.Express", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("CW");

                    b.Property<double>("GW");

                    b.Property<Guid?>("carrierID");

                    b.Property<Guid?>("commodityId");

                    b.Property<DateTime>("eta");

                    b.Property<DateTime>("etd");

                    b.Property<string>("flightNumber");

                    b.Property<string>("jobID")
                        .IsRequired();

                    b.Property<string>("mawbNumber");

                    b.Property<string>("notes");

                    b.Property<Guid?>("opicID");

                    b.Property<int>("quantity");

                    b.Property<string>("service");

                    b.Property<Guid?>("unitID");

                    b.HasKey("Id");

                    b.HasIndex("carrierID");

                    b.HasIndex("commodityId");

                    b.HasIndex("opicID");

                    b.HasIndex("unitID");

                    b.ToTable("Express");
                });

            modelBuilder.Entity("API.Entities.FclExp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("CBM");

                    b.Property<double>("GW");

                    b.Property<string>("Service");

                    b.Property<Guid?>("agentId");

                    b.Property<string>("bkgNumber");

                    b.Property<Guid?>("commodityId");

                    b.Property<DateTime>("created");

                    b.Property<DateTime>("eta");

                    b.Property<DateTime>("etd");

                    b.Property<Guid?>("freightId");

                    b.Property<bool>("isFinish");

                    b.Property<string>("jobID")
                        .IsRequired();

                    b.Property<string>("mBL");

                    b.Property<Guid?>("mBLNumberId");

                    b.Property<Guid?>("mMLNumberId");

                    b.Property<string>("notes");

                    b.Property<Guid?>("opicID");

                    b.Property<string>("poNumber");

                    b.Property<Guid?>("shipmentId");

                    b.Property<Guid?>("vesselId");

                    b.HasKey("Id");

                    b.HasIndex("agentId");

                    b.HasIndex("commodityId");

                    b.HasIndex("freightId");

                    b.HasIndex("mMLNumberId");

                    b.HasIndex("opicID");

                    b.HasIndex("shipmentId");

                    b.HasIndex("vesselId");

                    b.ToTable("FclExps");
                });

            modelBuilder.Entity("API.Entities.Freight", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Freights");
                });

            modelBuilder.Entity("API.Entities.LclExp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("CBM");

                    b.Property<double>("GW");

                    b.Property<Guid?>("agentId");

                    b.Property<string>("bkgNumber");

                    b.Property<Guid?>("commodityId");

                    b.Property<DateTime>("created");

                    b.Property<DateTime>("eta");

                    b.Property<DateTime>("etd");

                    b.Property<Guid?>("freightId");

                    b.Property<bool>("isFinish");

                    b.Property<string>("jobID")
                        .IsRequired();

                    b.Property<string>("mBL");

                    b.Property<Guid?>("mBLNumberId");

                    b.Property<Guid?>("mMLNumberId");

                    b.Property<string>("notes");

                    b.Property<Guid?>("opicID");

                    b.Property<int>("packages");

                    b.Property<Guid?>("shipmentId");

                    b.Property<Guid?>("unitID");

                    b.Property<Guid?>("vesselId");

                    b.HasKey("Id");

                    b.HasIndex("agentId");

                    b.HasIndex("commodityId");

                    b.HasIndex("freightId");

                    b.HasIndex("mMLNumberId");

                    b.HasIndex("opicID");

                    b.HasIndex("shipmentId");

                    b.HasIndex("unitID");

                    b.HasIndex("vesselId");

                    b.ToTable("LclExps");
                });

            modelBuilder.Entity("API.Entities.MBLType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("MBLTypes");
                });

            modelBuilder.Entity("API.Entities.Mode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Modes");
                });

            modelBuilder.Entity("API.Entities.Nationality", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("API.Entities.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("API.Entities.Port", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("localZone")
                        .IsRequired();

                    b.Property<Guid>("modeID");

                    b.Property<Guid>("nationalityID");

                    b.Property<string>("portName")
                        .IsRequired();

                    b.Property<Guid>("zoneID");

                    b.HasKey("Id");

                    b.HasIndex("modeID");

                    b.HasIndex("nationalityID");

                    b.HasIndex("zoneID");

                    b.ToTable("Ports");
                });

            modelBuilder.Entity("API.Entities.Position", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("API.Entities.RoleEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("API.Entities.Shipment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Shipments");
                });

            modelBuilder.Entity("API.Entities.Storage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("API.Entities.TypeOfBill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TypeOfBills");
                });

            modelBuilder.Entity("API.Entities.Unit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("API.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsActive");

                    b.Property<string>("JobTitle");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("API.Entities.Vessel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Vessels");
                });

            modelBuilder.Entity("API.Entities.Zone", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Zones");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictApplication", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientId")
                        .IsRequired();

                    b.Property<string>("ClientSecret");

                    b.Property<string>("DisplayName");

                    b.Property<string>("PostLogoutRedirectUris");

                    b.Property<string>("RedirectUris");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("OpenIddictApplications");
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictAuthorization", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationId");

                    b.Property<string>("Scopes");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<string>("Subject")
                        .IsRequired();

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.ToTable("OpenIddictAuthorizations");
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictScope", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("OpenIddictScopes");
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictToken", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationId");

                    b.Property<string>("AuthorizationId");

                    b.Property<string>("Ciphertext");

                    b.Property<DateTimeOffset?>("CreationDate");

                    b.Property<DateTimeOffset?>("ExpirationDate");

                    b.Property<string>("Hash");

                    b.Property<string>("Status");

                    b.Property<string>("Subject")
                        .IsRequired();

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("AuthorizationId");

                    b.HasIndex("Hash")
                        .IsUnique();

                    b.ToTable("OpenIddictTokens");
                });

            modelBuilder.Entity("API.Entities.AirExp", b =>
                {
                    b.HasOne("API.Entities.Carrier", "carrier")
                        .WithMany()
                        .HasForeignKey("carrierID");

                    b.HasOne("API.Entities.Commodity", "Commodity")
                        .WithMany()
                        .HasForeignKey("commodityId");

                    b.HasOne("API.Entities.Contact", "opic")
                        .WithMany()
                        .HasForeignKey("opicID");

                    b.HasOne("API.Entities.Payment", "payment")
                        .WithMany()
                        .HasForeignKey("paymentID");

                    b.HasOne("API.Entities.Shipment", "shipment")
                        .WithMany()
                        .HasForeignKey("shipmentID");

                    b.HasOne("API.Entities.TypeOfBill", "TypeOfBill")
                        .WithMany()
                        .HasForeignKey("typeOfBill");

                    b.HasOne("API.Entities.Unit", "unit")
                        .WithMany()
                        .HasForeignKey("unitID");
                });

            modelBuilder.Entity("API.Entities.Carrier", b =>
                {
                    b.HasOne("API.Entities.Nationality", "country")
                        .WithMany()
                        .HasForeignKey("countryID");
                });

            modelBuilder.Entity("API.Entities.Contact", b =>
                {
                    b.HasOne("API.Entities.Department", "department")
                        .WithMany()
                        .HasForeignKey("departmentID");

                    b.HasOne("API.Entities.Position", "position")
                        .WithMany()
                        .HasForeignKey("positionID");
                });

            modelBuilder.Entity("API.Entities.Express", b =>
                {
                    b.HasOne("API.Entities.Carrier", "carrier")
                        .WithMany()
                        .HasForeignKey("carrierID");

                    b.HasOne("API.Entities.Commodity", "Commodity")
                        .WithMany()
                        .HasForeignKey("commodityId");

                    b.HasOne("API.Entities.Contact", "opic")
                        .WithMany()
                        .HasForeignKey("opicID");

                    b.HasOne("API.Entities.Unit", "unit")
                        .WithMany()
                        .HasForeignKey("unitID");
                });

            modelBuilder.Entity("API.Entities.FclExp", b =>
                {
                    b.HasOne("API.Entities.Carrier", "Agent")
                        .WithMany()
                        .HasForeignKey("agentId");

                    b.HasOne("API.Entities.Commodity", "Commodity")
                        .WithMany()
                        .HasForeignKey("commodityId");

                    b.HasOne("API.Entities.Freight", "Freight")
                        .WithMany()
                        .HasForeignKey("freightId");

                    b.HasOne("API.Entities.MBLType", "MBLType")
                        .WithMany()
                        .HasForeignKey("mMLNumberId");

                    b.HasOne("API.Entities.Contact", "opic")
                        .WithMany()
                        .HasForeignKey("opicID");

                    b.HasOne("API.Entities.Shipment", "Shipment")
                        .WithMany()
                        .HasForeignKey("shipmentId");

                    b.HasOne("API.Entities.Vessel", "Vessel")
                        .WithMany()
                        .HasForeignKey("vesselId");
                });

            modelBuilder.Entity("API.Entities.LclExp", b =>
                {
                    b.HasOne("API.Entities.Carrier", "Agent")
                        .WithMany()
                        .HasForeignKey("agentId");

                    b.HasOne("API.Entities.Commodity", "Commodity")
                        .WithMany()
                        .HasForeignKey("commodityId");

                    b.HasOne("API.Entities.Freight", "Freight")
                        .WithMany()
                        .HasForeignKey("freightId");

                    b.HasOne("API.Entities.MBLType", "MBLType")
                        .WithMany()
                        .HasForeignKey("mMLNumberId");

                    b.HasOne("API.Entities.Contact", "opic")
                        .WithMany()
                        .HasForeignKey("opicID");

                    b.HasOne("API.Entities.Shipment", "Shipment")
                        .WithMany()
                        .HasForeignKey("shipmentId");

                    b.HasOne("API.Entities.Unit", "unit")
                        .WithMany()
                        .HasForeignKey("unitID");

                    b.HasOne("API.Entities.Vessel", "Vessel")
                        .WithMany()
                        .HasForeignKey("vesselId");
                });

            modelBuilder.Entity("API.Entities.Port", b =>
                {
                    b.HasOne("API.Entities.Mode", "mode")
                        .WithMany()
                        .HasForeignKey("modeID");

                    b.HasOne("API.Entities.Nationality", "nationality")
                        .WithMany()
                        .HasForeignKey("nationalityID");

                    b.HasOne("API.Entities.Zone", "zone")
                        .WithMany()
                        .HasForeignKey("zoneID");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("API.Entities.RoleEntity")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("API.Entities.UserEntity")
                        .WithMany("Claims")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("API.Entities.UserEntity")
                        .WithMany("Logins")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("API.Entities.RoleEntity")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.HasOne("API.Entities.UserEntity")
                        .WithMany("Roles")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictAuthorization", b =>
                {
                    b.HasOne("OpenIddict.Models.OpenIddictApplication", "Application")
                        .WithMany("Authorizations")
                        .HasForeignKey("ApplicationId");
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictToken", b =>
                {
                    b.HasOne("OpenIddict.Models.OpenIddictApplication", "Application")
                        .WithMany("Tokens")
                        .HasForeignKey("ApplicationId");

                    b.HasOne("OpenIddict.Models.OpenIddictAuthorization", "Authorization")
                        .WithMany("Tokens")
                        .HasForeignKey("AuthorizationId");
                });
        }
    }
}
