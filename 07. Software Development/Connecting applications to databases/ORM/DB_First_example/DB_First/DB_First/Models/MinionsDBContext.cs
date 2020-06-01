using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DB_First.Models
{
    public partial class MinionsDBContext : DbContext
    {
        public MinionsDBContext()
        {
        }

        public MinionsDBContext(DbContextOptions<MinionsDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<EvilnessFactors> EvilnessFactors { get; set; }
        public virtual DbSet<Minions> Minions { get; set; }
        public virtual DbSet<MinionsVillians> MinionsVillians { get; set; }
        public virtual DbSet<Towns> Towns { get; set; }
        public virtual DbSet<Villians> Villians { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server = DESKTOP-1817IFM\\SQLEXPRESS; Database= MinionsDB; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Countries>(entity =>
            {
                entity.ToTable("countries");

                entity.HasIndex(e => e.Id)
                    .HasName("UQ__countrie__3213E83E8400BF43")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EvilnessFactors>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Minions>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.Minions)
                    .HasForeignKey(d => d.TownId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Minions__TownId__3D5E1FD2");
            });

            modelBuilder.Entity<MinionsVillians>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.Minion)
                    .WithMany()
                    .HasForeignKey(d => d.MinionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MinionsVi__Minio__440B1D61");

                entity.HasOne(d => d.Villian)
                    .WithMany()
                    .HasForeignKey(d => d.VillianId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MinionsVi__Villi__44FF419A");
            });

            modelBuilder.Entity<Towns>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("UQ__Towns__3213E83E2476B148")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.Towns)
                    .HasForeignKey(d => d.CountryCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Towns__CountryCo__3A81B327");
            });

            modelBuilder.Entity<Villians>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.EvilnessFactor)
                    .WithMany(p => p.Villians)
                    .HasForeignKey(d => d.EvilnessFactorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Villians__Evilne__4222D4EF");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
