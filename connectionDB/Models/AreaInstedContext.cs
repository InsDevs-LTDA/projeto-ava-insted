using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace connectionDB.Models;

public partial class AreaInstedContext : DbContext
{

    public AreaInstedContext(DbContextOptions<AreaInstedContext> options)
        : base(options)
    {
    }
    public IConfiguration Configuration { get; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Configuration.GetConnectionString("MyDataBase"));
      
    }

    public virtual DbSet<TbAcadActivity> TbAcadActivities { get; set; }

    public virtual DbSet<TbAddress> TbAddresses { get; set; }

    public virtual DbSet<TbClass> TbClasses { get; set; }

    public virtual DbSet<TbClassFile> TbClassFiles { get; set; }

    public virtual DbSet<TbFrequency> TbFrequencies { get; set; }

    public virtual DbSet<TbGrade> TbGrades { get; set; }

    public virtual DbSet<TbUser> TbUsers { get; set; }

    public virtual DbSet<TbUserClass> TbUserClasses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbAcadActivity>(entity =>
        {
            entity.HasKey(e => e.IdAcadActivity).HasName("PK_ACAC");

            entity.ToTable("TB_ACAD_ACTIVITY");

            entity.Property(e => e.IdAcadActivity).HasColumnName("ID_ACAD_ACTIVITY");
            entity.Property(e => e.DtDeadline)
                .HasColumnType("date")
                .HasColumnName("DT_DEADLINE");
            entity.Property(e => e.IdUserClass).HasColumnName("ID_USER_CLASS");
            entity.Property(e => e.NmAcadActivity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NM_ACAD_ACTIVITY");

            entity.HasOne(d => d.IdUserClassNavigation).WithMany(p => p.TbAcadActivities)
                .HasForeignKey(d => d.IdUserClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACAC_UC");
        });

        modelBuilder.Entity<TbAddress>(entity =>
        {
            entity.HasKey(e => e.IdAddress).HasName("PK_ADDRESS");

            entity.ToTable("TB_ADDRESS");

            entity.Property(e => e.IdAddress).HasColumnName("ID_ADDRESS");
            entity.Property(e => e.NmCity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NM_CITY");
            entity.Property(e => e.NmComplement)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NM_COMPLEMENT");
            entity.Property(e => e.NmNeighborhood)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NM_NEIGHBORHOOD");
            entity.Property(e => e.NmState)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NM_STATE");
            entity.Property(e => e.NmStreet)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NM_STREET");
            entity.Property(e => e.NrHouseNumber).HasColumnName("NR_HOUSE_NUMBER");
            entity.Property(e => e.NrZipCode).HasColumnName("NR_ZIP_CODE");
        });

        modelBuilder.Entity<TbClass>(entity =>
        {
            entity.HasKey(e => e.IdClass).HasName("PK_CLASS");

            entity.ToTable("TB_CLASS", tb => tb.HasTrigger("TG_CLASS_TEACHER"));

            entity.Property(e => e.IdClass).HasColumnName("ID_CLASS");
            entity.Property(e => e.DtTime)
                .HasPrecision(0)
                .HasColumnName("DT_TIME");
            entity.Property(e => e.IdUser).HasColumnName("ID_USER");
            entity.Property(e => e.NmClass)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NM_CLASS");
            entity.Property(e => e.NmClassroom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NM_CLASSROOM");
            entity.Property(e => e.NmUser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NM_USER");
            entity.Property(e => e.NmWeekday)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NM_WEEKDAY");
            entity.Property(e => e.NrTotal).HasColumnName("NR_TOTAL");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.TbClasses)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CLASS_USER");
        });

        modelBuilder.Entity<TbClassFile>(entity =>
        {
            entity.HasKey(e => e.IdClassFiles).HasName("PK_CF");

            entity.ToTable("TB_CLASS_FILES");

            entity.Property(e => e.IdClassFiles).HasColumnName("ID_CLASS_FILES");
            entity.Property(e => e.IdClass).HasColumnName("ID_CLASS");
            entity.Property(e => e.ImgFile).HasColumnName("IMG_FILE");
            entity.Property(e => e.NmFile)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NM_FILE");
        });

        modelBuilder.Entity<TbFrequency>(entity =>
        {
            entity.HasKey(e => e.IdFrequency).HasName("PK_FREQ");

            entity.ToTable("TB_FREQUENCY");

            entity.Property(e => e.IdFrequency).HasColumnName("ID_FREQUENCY");
            entity.Property(e => e.DtDate)
                .HasColumnType("date")
                .HasColumnName("DT_DATE");
            entity.Property(e => e.IdUserClass).HasColumnName("ID_USER_CLASS");
            entity.Property(e => e.NrPresece).HasColumnName("NR_PRESECE");

            entity.HasOne(d => d.IdUserClassNavigation).WithMany(p => p.TbFrequencies)
                .HasForeignKey(d => d.IdUserClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FREQ_UC");
        });

        modelBuilder.Entity<TbGrade>(entity =>
        {
            entity.HasKey(e => e.IdGrades).HasName("PK_GRADES");

            entity.ToTable("TB_GRADES");

            entity.Property(e => e.IdGrades).HasColumnName("ID_GRADES");
            entity.Property(e => e.ExCp1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("EX_CP1");
            entity.Property(e => e.ExCp2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("EX_CP2");
            entity.Property(e => e.Exam)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("EXAM");
            entity.Property(e => e.IdUserClass).HasColumnName("ID_USER_CLASS");
            entity.Property(e => e.Portfolio)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("PORTFOLIO");
            entity.Property(e => e.Project)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("PROJECT");
            entity.Property(e => e.Prova1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("PROVA1");
            entity.Property(e => e.Prova2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("PROVA2");

            entity.HasOne(d => d.IdUserClassNavigation).WithMany(p => p.TbGrades)
                .HasForeignKey(d => d.IdUserClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GRADES_UC");
        });

        modelBuilder.Entity<TbUser>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PK_USER");

            entity.ToTable("TB_USER");

            entity.Property(e => e.IdUser).HasColumnName("ID_USER");
            entity.Property(e => e.DtBirthdate)
                .HasColumnType("date")
                .HasColumnName("DT_BIRTHDATE");
            entity.Property(e => e.IdAddress).HasColumnName("ID_ADDRESS");
            entity.Property(e => e.ImgFile).HasColumnName("IMG_FILE");
            entity.Property(e => e.NmEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NM_EMAIL");
            entity.Property(e => e.NmExpedition)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NM_EXPEDITION");
            entity.Property(e => e.NmPassword)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NM_PASSWORD");
            entity.Property(e => e.NmPhone1).HasColumnName("NM_PHONE1");
            entity.Property(e => e.NmPhone2).HasColumnName("NM_PHONE2");
            entity.Property(e => e.NmSex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NM_SEX");
            entity.Property(e => e.NmUser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NM_USER");
            entity.Property(e => e.NrCpf)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("NR_CPF");
            entity.Property(e => e.NrRegister).HasColumnName("NR_REGISTER");
            entity.Property(e => e.NrRg).HasColumnName("NR_RG");
            entity.Property(e => e.SnTeacher).HasColumnName("SN_TEACHER");

            entity.HasOne(d => d.IdAddressNavigation).WithMany(p => p.TbUsers)
                .HasForeignKey(d => d.IdAddress)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_ADDRESS");
        });

        modelBuilder.Entity<TbUserClass>(entity =>
        {
            entity.HasKey(e => e.IdUserClass).HasName("PK_UC");

            entity.ToTable("TB_USER_CLASS");

            entity.Property(e => e.IdUserClass).HasColumnName("ID_USER_CLASS");
            entity.Property(e => e.IdClass).HasColumnName("ID_CLASS");
            entity.Property(e => e.IdUser).HasColumnName("ID_USER");

            entity.HasOne(d => d.IdClassNavigation).WithMany(p => p.TbUserClasses)
                .HasForeignKey(d => d.IdClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UC_CLASS");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
