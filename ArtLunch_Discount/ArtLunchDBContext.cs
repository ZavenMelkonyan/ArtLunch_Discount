using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;
using ArtLunch_Discount.Models;

namespace SpyTheGame
{
    public partial class ArtLunchDBConext : DbContext
    {
        public virtual DbSet<DicLanguage> DicLanguage { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Words> Words { get; set; }
        public virtual DbSet<UidWords> UidWords { get; set; }
        public SpyTheGameDBContext(DbContextOptions<SpyTheGameDBContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DicLanguage>(entity =>
            {
                entity.HasIndex(e => e.id).HasName("IX_id").IsUnique();
            });
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasIndex(e => e.id).HasName("IX_id").IsUnique();
            });
            modelBuilder.Entity<Words>(entity =>
            {
                entity.HasIndex(e => e.id).HasName("IX_id").IsUnique();
            });
            modelBuilder.Entity<UidWords>(entity =>
            {
                entity.HasIndex(e => e.id).HasName("IX_id").IsUnique();
            });
        }
    }
}
