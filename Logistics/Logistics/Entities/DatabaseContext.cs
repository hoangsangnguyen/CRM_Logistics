﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Department>()
                .HasIndex(u => u._key)
                .IsUnique();
            modelBuilder.Entity<Contact>()
               .HasIndex(u => u.contactID)
               .IsUnique();

        }

        public DbSet<Storage> Storages { get; set; }

        public DbSet<AirExp> AirExps{ get; set; }
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Commodity> Commodities { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Mode> Modes { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Port> Ports { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<TypeOfBill> TypeOfBills{ get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<Express> Express { get; set; }
        public DbSet<MBLType> MBLTypes { get; set; }
        public DbSet<Vessel> Vessels { get; set; }
        public DbSet<Freight> Freights { get; set; }
        public DbSet<FclExp> FclExps { get; set; }
        public DbSet<LclExp> LclExps { get; set; }
        public DbSet<AirImp> AirImps { get; set; }


    }
}
