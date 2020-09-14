using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Police.Data.Entities
{
    public partial class TestingDBContext : DbContext
    {
        public TestingDBContext()
        {
        }

        public TestingDBContext(DbContextOptions<TestingDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<ArrestingReport> ArrestingReport { get; set; }
        public virtual DbSet<AutopsyReport> AutopsyReport { get; set; }
        public virtual DbSet<CaseFolder> CaseFolder { get; set; }
        public virtual DbSet<Crime> Crime { get; set; }
        public virtual DbSet<Criminal> Criminal { get; set; }
        public virtual DbSet<Evidence> Evidence { get; set; }
        public virtual DbSet<InvolvedPersons> InvolvedPersons { get; set; }
        public virtual DbSet<Officer> Officer { get; set; }
        public virtual DbSet<PoliceReport> PoliceReport { get; set; }
        public virtual DbSet<Victim> Victim { get; set; }
        public virtual DbSet<Witness> Witness { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:williams1998.database.windows.net,1433;Initial Catalog=TestingDB;Persist Security Info=False;User ID=asher;Password=Clarkezlayer571;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address", "Police");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ArrestingReport>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("PK__Arrestin__D5BD48E5A6485197");

                entity.ToTable("ArrestingReport", "Police");

                entity.HasIndex(e => e.ReportId)
                    .HasName("UQ__Arrestin__D5BD48E423BA232D")
                    .IsUnique();

                entity.Property(e => e.ReportId)
                    .HasColumnName("ReportID")
                    .HasMaxLength(10);

                entity.Property(e => e.ArrestingOfficer)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.CrimeId).HasColumnName("CrimeID");

                entity.Property(e => e.CriminalId).HasColumnName("CriminalID");

                entity.HasOne(d => d.ArrestingOfficerNavigation)
                    .WithMany(p => p.ArrestingReport)
                    .HasForeignKey(d => d.ArrestingOfficer);

                entity.HasOne(d => d.Crime)
                    .WithMany(p => p.ArrestingReport)
                    .HasForeignKey(d => d.CrimeId);

                entity.HasOne(d => d.Criminal)
                    .WithMany(p => p.ArrestingReport)
                    .HasForeignKey(d => d.CriminalId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AutopsyReport>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("PK__AutopsyR__D5BD48E511D65DBE");

                entity.ToTable("AutopsyReport", "Police");

                entity.HasIndex(e => e.ReportId)
                    .HasName("UQ__AutopsyR__D5BD48E4916C4F4F")
                    .IsUnique();

                entity.Property(e => e.ReportId)
                    .HasColumnName("ReportID")
                    .HasMaxLength(10);

                entity.Property(e => e.CaseNumber)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CauseOfDeath)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Examiner)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.MannerOfDeath)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.VictimId).HasColumnName("VictimID");

                entity.HasOne(d => d.CaseNumberNavigation)
                    .WithMany(p => p.AutopsyReport)
                    .HasForeignKey(d => d.CaseNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ExaminerNavigation)
                    .WithMany(p => p.AutopsyReport)
                    .HasForeignKey(d => d.Examiner)
                    .HasConstraintName("FK_AutopsyReport_Officer_OfficerID");

                entity.HasOne(d => d.Victim)
                    .WithMany(p => p.AutopsyReport)
                    .HasForeignKey(d => d.VictimId);
            });

            modelBuilder.Entity<CaseFolder>(entity =>
            {
                entity.HasKey(e => e.CaseNumber)
                    .HasName("PK__CaseFold__103BB8D9951B2C15");

                entity.ToTable("CaseFolder", "Police");

                entity.HasIndex(e => e.CaseNumber)
                    .HasName("UQ__CaseFold__103BB8D8FA911C70")
                    .IsUnique();

                entity.Property(e => e.CaseNumber).HasMaxLength(10);

                entity.Property(e => e.ArrestingReportId)
                    .IsRequired()
                    .HasColumnName("ArrestingReportID")
                    .HasMaxLength(10);

                entity.Property(e => e.Detective)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.PoliceReportId)
                    .IsRequired()
                    .HasColumnName("PoliceReportID")
                    .HasMaxLength(10);

                entity.HasOne(d => d.ArrestingReport)
                    .WithMany(p => p.CaseFolder)
                    .HasForeignKey(d => d.ArrestingReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CaseFolder_ArrestingReport_ReportID");

                entity.HasOne(d => d.DetectiveNavigation)
                    .WithMany(p => p.CaseFolder)
                    .HasForeignKey(d => d.Detective);

                entity.HasOne(d => d.PoliceReport)
                    .WithMany(p => p.CaseFolder)
                    .HasForeignKey(d => d.PoliceReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CaseFolder_PoliceReport_ReportID");
            });

            modelBuilder.Entity<Crime>(entity =>
            {
                entity.ToTable("Crime", "Police");

                entity.Property(e => e.CrimeId).HasColumnName("CrimeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Criminal>(entity =>
            {
                entity.ToTable("Criminal", "Police");

                entity.Property(e => e.CriminalId).HasColumnName("CriminalID");

                entity.Property(e => e.BodyMarks).HasMaxLength(4000);

                entity.Property(e => e.Dob).HasColumnName("DOB");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Portrait).HasColumnType("image");

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.CurrentAddressNavigation)
                    .WithMany(p => p.Criminal)
                    .HasForeignKey(d => d.CurrentAddress)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Criminal_Address_AddressID");
            });

            modelBuilder.Entity<Evidence>(entity =>
            {
                entity.ToTable("Evidence", "Police");

                entity.HasIndex(e => e.EvidenceId)
                    .HasName("UQ__Evidence__FA39D78C00106E18")
                    .IsUnique();

                entity.Property(e => e.EvidenceId)
                    .HasColumnName("EvidenceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CaseNumber)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.CaseNumberNavigation)
                    .WithMany(p => p.Evidence)
                    .HasForeignKey(d => d.CaseNumber);
            });

            modelBuilder.Entity<InvolvedPersons>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InvolvedPersons", "Police");

                entity.Property(e => e.CaseNumber)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.WitnessId).HasColumnName("WitnessID");

                entity.HasOne(d => d.CaseNumberNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CaseNumber);

                entity.HasOne(d => d.Witness)
                    .WithMany()
                    .HasForeignKey(d => d.WitnessId);
            });

            modelBuilder.Entity<Officer>(entity =>
            {
                entity.HasKey(e => e.BadgeNumber)
                    .HasName("PK__Officer__D110FD57C4CF46D7");

                entity.ToTable("Officer", "Police");

                entity.HasIndex(e => e.BadgeNumber)
                    .HasName("UQ__Officer__D110FD56A7ABB4AD")
                    .IsUnique();

                entity.Property(e => e.BadgeNumber).HasMaxLength(3);

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Portrait).HasColumnType("image");

                entity.Property(e => e.Rank)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Officer)
                    .HasForeignKey(d => d.AddressId);
            });

            modelBuilder.Entity<PoliceReport>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("PK__PoliceRe__D5BD48E555AA27BF");

                entity.ToTable("PoliceReport", "Police");

                entity.HasIndex(e => e.ReportId)
                    .HasName("UQ__PoliceRe__D5BD48E4EF06280C")
                    .IsUnique();

                entity.Property(e => e.ReportId)
                    .HasColumnName("ReportID")
                    .HasMaxLength(10);

                entity.Property(e => e.CrimeId).HasColumnName("CrimeID");

                entity.Property(e => e.Narrative)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.HasOne(d => d.Crime)
                    .WithMany(p => p.PoliceReport)
                    .HasForeignKey(d => d.CrimeId);

                entity.HasOne(d => d.CrimeLocationNavigation)
                    .WithMany(p => p.PoliceReport)
                    .HasForeignKey(d => d.CrimeLocation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PoliceReport_Address_AddressID");
            });

            modelBuilder.Entity<Victim>(entity =>
            {
                entity.ToTable("Victim", "Police");

                entity.Property(e => e.VictimId).HasColumnName("VictimID");

                entity.Property(e => e.Dob).HasColumnName("DOB");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Witness>(entity =>
            {
                entity.ToTable("Witness", "Police");

                entity.Property(e => e.WitnessId).HasColumnName("WitnessID");

                entity.Property(e => e.Dob).HasColumnName("DOB");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
