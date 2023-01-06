using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace fotogalerisiproje.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<FotoOzellikleri> FotoOzellikleri { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FotoOzellikleri>()
                .Property(e => e.FOTOAD)
                .IsUnicode(false);

            modelBuilder.Entity<FotoOzellikleri>()
                .Property(e => e.FOTORENK)
                .IsUnicode(false);

            modelBuilder.Entity<FotoOzellikleri>()
                .Property(e => e.FOTOSAHİBİ)
                .IsUnicode(false);

            modelBuilder.Entity<Kategori>()
                .Property(e => e.KATEGORIAD)
                .IsUnicode(false);

            modelBuilder.Entity<Kategori>()
                .HasMany(e => e.FotoOzellikleri)
                .WithOptional(e => e.Kategori1)
                .HasForeignKey(e => e.KATEGORI);
        }
    }
}
