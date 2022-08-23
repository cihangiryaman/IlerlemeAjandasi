using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IlerlemeAjandasi.Entities.Logging.DatabaseLogging
{
    public partial class IlerlemeAjandasiLogContext : DbContext
    {
        public IlerlemeAjandasiLogContext()
        {
        }

        public IlerlemeAjandasiLogContext(DbContextOptions<IlerlemeAjandasiLogContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Error> Errors { get; set; } = null!;
        public virtual DbSet<ErrorCode> ErrorCodes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-L6GG7P6\\SQLEXPRESS;Initial Catalog=IlerlemeAjandasi.Log; integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Error>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.FkerrorCodeId).HasColumnName("FKErrorCodeId");

                entity.Property(e => e.ManagerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkerrorCode)
                    .WithMany(p => p.Errors)
                    .HasForeignKey(d => d.FkerrorCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Errors_ErrorCodes");
            });

            modelBuilder.Entity<ErrorCode>(entity =>
            {
                entity.Property(e => e.ErrorCode1)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("ErrorCode")
                    .IsFixedLength();

                entity.Property(e => e.ErrorMessage)
                    .HasMaxLength(1000)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
