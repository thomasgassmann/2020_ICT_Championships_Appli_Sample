using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TourCtrl.Models
{
    public partial class TourCtrlContext : DbContext
    {
        public TourCtrlContext()
        {
        }

        public TourCtrlContext(DbContextOptions<TourCtrlContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Game> Game { get; set; }
        public virtual DbSet<Match> Match { get; set; }
        public virtual DbSet<Participant> Participant { get; set; }
        public virtual DbSet<ParticipantInTournament> ParticipantInTournament { get; set; }
        public virtual DbSet<Tournament> Tournament { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=TourCtrl;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Match>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Participant1Id).HasColumnName("Participant1ID");

                entity.Property(e => e.Participant2Id).HasColumnName("Participant2ID");

                entity.Property(e => e.TournamentId).HasColumnName("TournamentID");

                entity.Property(e => e.WinnerParticipantId).HasColumnName("WinnerParticipantID");

                entity.HasOne(d => d.Participant1)
                    .WithMany(p => p.MatchParticipant1)
                    .HasForeignKey(d => d.Participant1Id)
                    .HasConstraintName("FK__Match__Participa__30F848ED");

                entity.HasOne(d => d.Participant2)
                    .WithMany(p => p.MatchParticipant2)
                    .HasForeignKey(d => d.Participant2Id)
                    .HasConstraintName("FK__Match__Participa__31EC6D26");

                entity.HasOne(d => d.Tournament)
                    .WithMany(p => p.Match)
                    .HasForeignKey(d => d.TournamentId)
                    .HasConstraintName("FK__Match__Tournamen__300424B4");

                entity.HasOne(d => d.WinnerParticipant)
                    .WithMany(p => p.MatchWinnerParticipant)
                    .HasForeignKey(d => d.WinnerParticipantId)
                    .HasConstraintName("FK__Match__WinnerPar__32E0915F");
            });

            modelBuilder.Entity<Participant>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ParticipantInTournament>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParticipantId).HasColumnName("ParticipantID");

                entity.Property(e => e.TournamentId).HasColumnName("TournamentID");

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.ParticipantInTournament)
                    .HasForeignKey(d => d.ParticipantId)
                    .HasConstraintName("FK__Participa__Parti__2D27B809");

                entity.HasOne(d => d.Tournament)
                    .WithMany(p => p.ParticipantInTournament)
                    .HasForeignKey(d => d.TournamentId)
                    .HasConstraintName("FK__Participa__Tourn__2C3393D0");
            });

            modelBuilder.Entity<Tournament>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WinnerParticipantId).HasColumnName("WinnerParticipantID");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.Tournament)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("FK__Tournamen__GameI__286302EC");

                entity.HasOne(d => d.WinnerParticipant)
                    .WithMany(p => p.Tournament)
                    .HasForeignKey(d => d.WinnerParticipantId)
                    .HasConstraintName("FK__Tournamen__Winne__29572725");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
