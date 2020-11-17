using Microsoft.EntityFrameworkCore;
using MJ24.DataAccess.Contact.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MJ24.DataAccess
{
    public class MJ24DataContext : DbContext
    {
        public MJ24DataContext(DbContextOptions<MJ24DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductPOCO>().ToTable("Product", "dbo");
            modelBuilder.Entity<ProductPOCO>().HasKey(p => p.Id);

            modelBuilder.Entity<UzytkownicyPOCO>().ToTable("Uzytkownicy", "dbo");
            modelBuilder.Entity<UzytkownicyPOCO>().HasKey(p => p.Id);

            modelBuilder.Entity<KategoriePOCO>().ToTable("Kategorie", "dbo");
            modelBuilder.Entity<KategoriePOCO>().HasKey(p => p.Id);

            modelBuilder.Entity<ZakupyPOCO>().ToTable("Zakupy", "dbo");
            modelBuilder.Entity<ZakupyPOCO>().HasKey(p => p.Id);

            modelBuilder.Entity<ZakupyStatusPOCO>().ToTable("ZakupyStatus", "dbo");
            modelBuilder.Entity<ZakupyStatusPOCO>().HasKey(p => p.Id);
        }

    }
}
