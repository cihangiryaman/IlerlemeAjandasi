using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IlerlemeAjandasi.Entities.Database.EntityFramework
{
    public partial class IlerlemeAjandasiContext : DbContext
    {
        public IlerlemeAjandasiContext()
        {
        }

        public IlerlemeAjandasiContext(DbContextOptions<IlerlemeAjandasiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Exam> Exams { get; set; } = null!;
        public virtual DbSet<Lesson> Lessons { get; set; } = null!;
        public virtual DbSet<Question> Questions { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;
        public virtual DbSet<SubjectQuestion> SubjectQuestions { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-L6GG7P6\\SQLEXPRESS;Initial Catalog=IlerlemeAjandasi; integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExamBrand)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FkexamPlaceId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FKExamPlaceId");

                entity.Property(e => e.FkuserId).HasColumnName("FKUserId");

                entity.Property(e => e.TotalNet)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.Property(e => e.LessonName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.FkexamId).HasColumnName("FKExamId");

                entity.HasOne(d => d.Fkexam)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.FkexamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Questions_Exams");

                entity.HasOne(d => d.FkexamNavigation)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.FkexamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WrongQuestions_Users");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.Property(e => e.FklessonId).HasColumnName("FKLessonId");

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Fklesson)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.FklessonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subjects_Lessons");
            });

            modelBuilder.Entity<SubjectQuestion>(entity =>
            {
                entity.ToTable("SubjectQuestion");

                entity.Property(e => e.FkquestionId).HasColumnName("FKQuestionId");

                entity.Property(e => e.FksubjectId).HasColumnName("FKSubjectId");

                entity.HasOne(d => d.Fkquestion)
                    .WithMany(p => p.SubjectQuestions)
                    .HasForeignKey(d => d.FkquestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubjectQuestion_WrongQuestions");

                entity.HasOne(d => d.Fksubject)
                    .WithMany(p => p.SubjectQuestions)
                    .HasForeignKey(d => d.FksubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubjectQuestion_Subjects");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.NickName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
