﻿// <auto-generated />
using InsuranceClaimMicroservice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InsuranceClaimMicroservice.Migrations
{
    [DbContext(typeof(InsuranceDbContext))]
    partial class InsuranceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InsuranceClaimMicroservice.Models.InsuranceClaim", b =>
                {
                    b.Property<int>("ClaimId")
                        .HasColumnType("int");

                    b.Property<string>("AilmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InsurerId")
                        .HasColumnType("int");

                    b.Property<string>("InsurerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PackageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PaybleBalance")
                        .HasColumnType("float");

                    b.Property<int>("PlanId")
                        .HasColumnType("int");

                    b.HasKey("ClaimId");

                    b.HasIndex("InsurerId");

                    b.ToTable("Claims");
                });

            modelBuilder.Entity("InsuranceClaimMicroservice.Models.Insurer", b =>
                {
                    b.Property<int>("InsurerId")
                        .HasColumnType("int");

                    b.Property<long>("AmountLimit")
                        .HasColumnType("bigint");

                    b.Property<int>("DisbursementDuration")
                        .HasColumnType("int");

                    b.Property<string>("InsurerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InsurerPackageName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InsurerId");

                    b.ToTable("Insurers");
                });

            modelBuilder.Entity("InsuranceClaimMicroservice.Models.InsuranceClaim", b =>
                {
                    b.HasOne("InsuranceClaimMicroservice.Models.Insurer", "Insurer")
                        .WithMany()
                        .HasForeignKey("InsurerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Insurer");
                });
#pragma warning restore 612, 618
        }
    }
}
