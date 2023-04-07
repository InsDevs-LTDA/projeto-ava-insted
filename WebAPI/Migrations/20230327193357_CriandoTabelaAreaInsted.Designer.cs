﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Data;

#nullable disable

namespace WebAPI.Migrations
{
    [DbContext(typeof(AreaInstedContext))]
    [Migration("20230327193357_CriandoTabelaAreaInsted")]
    partial class CriandoTabelaAreaInsted
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("connectionDB.Models.TbAcadActivity", b =>
                {
                    b.Property<int>("IdAcadActivity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAcadActivity"));

                    b.Property<DateTime>("DtDeadline")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUserClass")
                        .HasColumnType("int");

                    b.Property<int>("IdUserClassNavigationIdUserClass")
                        .HasColumnType("int");

                    b.Property<string>("NmAcadActivity")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdAcadActivity");

                    b.HasIndex("IdUserClassNavigationIdUserClass");

                    b.ToTable("TbAcadActivities");
                });

            modelBuilder.Entity("connectionDB.Models.TbAddress", b =>
                {
                    b.Property<int>("IdAddress")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAddress"));

                    b.Property<string>("NmCity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NmComplement")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NmNeighborhood")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NmState")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NmStreet")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("NrHouseNumber")
                        .HasColumnType("int");

                    b.Property<int?>("NrZipCode")
                        .HasColumnType("int");

                    b.HasKey("IdAddress");

                    b.ToTable("TbAddresses");
                });

            modelBuilder.Entity("connectionDB.Models.TbClass", b =>
                {
                    b.Property<int>("IdClass")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdClass"));

                    b.Property<TimeSpan>("DtTime")
                        .HasColumnType("time");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<int>("IdUserNavigationIdUser")
                        .HasColumnType("int");

                    b.Property<string>("NmClass")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NmClassroom")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NmUser")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NmWeekday")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("NrTotal")
                        .HasColumnType("int");

                    b.HasKey("IdClass");

                    b.HasIndex("IdUserNavigationIdUser");

                    b.ToTable("TbClasses");
                });

            modelBuilder.Entity("connectionDB.Models.TbClassFile", b =>
                {
                    b.Property<int>("IdClassFiles")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdClassFiles"));

                    b.Property<int>("IdClass")
                        .HasColumnType("int");

                    b.Property<int>("IdClassNavigationIdClass")
                        .HasColumnType("int");

                    b.Property<byte[]>("ImgFile")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("NmFile")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdClassFiles");

                    b.HasIndex("IdClassNavigationIdClass");

                    b.ToTable("TbClassFiles");
                });

            modelBuilder.Entity("connectionDB.Models.TbFrequency", b =>
                {
                    b.Property<int>("IdFrequency")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFrequency"));

                    b.Property<DateTime>("DtDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUserClass")
                        .HasColumnType("int");

                    b.Property<int>("IdUserClassNavigationIdUserClass")
                        .HasColumnType("int");

                    b.Property<int>("NrPresence")
                        .HasColumnType("int");

                    b.HasKey("IdFrequency");

                    b.HasIndex("IdUserClassNavigationIdUserClass");

                    b.ToTable("TbFrequencies");
                });

            modelBuilder.Entity("connectionDB.Models.TbGrade", b =>
                {
                    b.Property<int>("IdGrades")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdGrades"));

                    b.Property<decimal>("ExCp1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ExCp2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Exam")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("IdUserClass")
                        .HasColumnType("int");

                    b.Property<int>("IdUserClassNavigationIdUserClass")
                        .HasColumnType("int");

                    b.Property<decimal>("Portfolio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Project")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Prova1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Prova2")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdGrades");

                    b.HasIndex("IdUserClassNavigationIdUserClass");

                    b.ToTable("TbGrades");
                });

            modelBuilder.Entity("connectionDB.Models.TbUser", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"));

                    b.Property<DateTime>("DtBirthdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdAddress")
                        .HasColumnType("int");

                    b.Property<byte[]>("ImgFile")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("NmEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NmExpedition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NmPhone1")
                        .HasColumnType("int");

                    b.Property<int?>("NmPhone2")
                        .HasColumnType("int");

                    b.Property<string>("NmSex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NmUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NrCpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NrRegister")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NrRg")
                        .HasColumnType("int");

                    b.Property<bool>("SnTeacher")
                        .HasColumnType("bit");

                    b.HasKey("IdUser");

                    b.HasIndex("IdAddress");

                    b.ToTable("TbUsers");
                });

            modelBuilder.Entity("connectionDB.Models.TbUserClass", b =>
                {
                    b.Property<int>("IdUserClass")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUserClass"));

                    b.Property<int>("IdClass")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("IdUserClass");

                    b.HasIndex("IdClass");

                    b.ToTable("TbUserClasses");
                });

            modelBuilder.Entity("connectionDB.Models.TbAcadActivity", b =>
                {
                    b.HasOne("connectionDB.Models.TbUserClass", "IdUserClassNavigation")
                        .WithMany("TbAcadActivities")
                        .HasForeignKey("IdUserClassNavigationIdUserClass")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdUserClassNavigation");
                });

            modelBuilder.Entity("connectionDB.Models.TbClass", b =>
                {
                    b.HasOne("connectionDB.Models.TbUser", "IdUserNavigation")
                        .WithMany("TbClasses")
                        .HasForeignKey("IdUserNavigationIdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("connectionDB.Models.TbClassFile", b =>
                {
                    b.HasOne("connectionDB.Models.TbClass", "IdClassNavigation")
                        .WithMany()
                        .HasForeignKey("IdClassNavigationIdClass")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdClassNavigation");
                });

            modelBuilder.Entity("connectionDB.Models.TbFrequency", b =>
                {
                    b.HasOne("connectionDB.Models.TbUserClass", "IdUserClassNavigation")
                        .WithMany("TbFrequencies")
                        .HasForeignKey("IdUserClassNavigationIdUserClass")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdUserClassNavigation");
                });

            modelBuilder.Entity("connectionDB.Models.TbGrade", b =>
                {
                    b.HasOne("connectionDB.Models.TbUserClass", "IdUserClassNavigation")
                        .WithMany("TbGrades")
                        .HasForeignKey("IdUserClassNavigationIdUserClass")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdUserClassNavigation");
                });

            modelBuilder.Entity("connectionDB.Models.TbUser", b =>
                {
                    b.HasOne("connectionDB.Models.TbAddress", "IdAddressNavigation")
                        .WithMany("TbUsers")
                        .HasForeignKey("IdAddress")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdAddressNavigation");
                });

            modelBuilder.Entity("connectionDB.Models.TbUserClass", b =>
                {
                    b.HasOne("connectionDB.Models.TbClass", "IdClassNavigation")
                        .WithMany("TbUserClasses")
                        .HasForeignKey("IdClass")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdClassNavigation");
                });

            modelBuilder.Entity("connectionDB.Models.TbAddress", b =>
                {
                    b.Navigation("TbUsers");
                });

            modelBuilder.Entity("connectionDB.Models.TbClass", b =>
                {
                    b.Navigation("TbUserClasses");
                });

            modelBuilder.Entity("connectionDB.Models.TbUser", b =>
                {
                    b.Navigation("TbClasses");
                });

            modelBuilder.Entity("connectionDB.Models.TbUserClass", b =>
                {
                    b.Navigation("TbAcadActivities");

                    b.Navigation("TbFrequencies");

                    b.Navigation("TbGrades");
                });
#pragma warning restore 612, 618
        }
    }
}
