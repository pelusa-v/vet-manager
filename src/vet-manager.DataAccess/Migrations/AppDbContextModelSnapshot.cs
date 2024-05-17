﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using vet_manager.DataAccess;

#nullable disable

namespace vet_manager.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("vet_manager.Core.ConsultationCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ConsultationCategories");
                });

            modelBuilder.Entity("vet_manager.Core.Entities.Clients.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("vet_manager.Core.Entities.Clients.Breed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Breeds");
                });

            modelBuilder.Entity("vet_manager.Core.Entities.Clients.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("vet_manager.Core.Entities.Clients.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<int>("BreedId")
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("BreedId");

                    b.HasIndex("ClientId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("vet_manager.Core.Entities.Consultations.Consultation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("ConsultationTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Diagnosis")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("OperationId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ParentConsultationId")
                        .HasColumnType("char(36)");

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConsultationTypeId");

                    b.HasIndex("OperationId")
                        .IsUnique();

                    b.HasIndex("ParentConsultationId");

                    b.HasIndex("PetId");

                    b.ToTable("Consultations");
                });

            modelBuilder.Entity("vet_manager.Core.Entities.Consultations.ConsultationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ConsultationCategoryId")
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ConsultationCategoryId");

                    b.ToTable("ConsultationTypes");
                });

            modelBuilder.Entity("vet_manager.Core.Entities.Money.Operation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<decimal>("Ammount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("vet_manager.Core.Entities.Money.OperationAdditional", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<decimal?>("Ammount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<Guid>("OperationId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OperationId");

                    b.ToTable("OperationAdditionals");
                });

            modelBuilder.Entity("vet_manager.Core.Entities.Clients.Pet", b =>
                {
                    b.HasOne("vet_manager.Core.Entities.Clients.Animal", "Animal")
                        .WithMany("Pets")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vet_manager.Core.Entities.Clients.Breed", "Breed")
                        .WithMany("Pets")
                        .HasForeignKey("BreedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vet_manager.Core.Entities.Clients.Client", "Client")
                        .WithMany("Pets")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Breed");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("vet_manager.Core.Entities.Consultations.Consultation", b =>
                {
                    b.HasOne("vet_manager.Core.Entities.Consultations.ConsultationType", "ConsultationType")
                        .WithMany("Consultations")
                        .HasForeignKey("ConsultationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vet_manager.Core.Entities.Money.Operation", "Operation")
                        .WithOne("Consultation")
                        .HasForeignKey("vet_manager.Core.Entities.Consultations.Consultation", "OperationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vet_manager.Core.Entities.Consultations.Consultation", "ParentConsultation")
                        .WithMany("RelatedConsultations")
                        .HasForeignKey("ParentConsultationId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("vet_manager.Core.Entities.Clients.Pet", "Pet")
                        .WithMany("Consultations")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ConsultationType");

                    b.Navigation("Operation");

                    b.Navigation("ParentConsultation");

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("vet_manager.Core.Entities.Consultations.ConsultationType", b =>
                {
                    b.HasOne("vet_manager.Core.ConsultationCategory", "ConsultationCategory")
                        .WithMany("ConsultationTypes")
                        .HasForeignKey("ConsultationCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ConsultationCategory");
                });

            modelBuilder.Entity("vet_manager.Core.Entities.Money.OperationAdditional", b =>
                {
                    b.HasOne("vet_manager.Core.Entities.Money.Operation", "Operation")
                        .WithMany("Additionals")
                        .HasForeignKey("OperationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Operation");
                });

            modelBuilder.Entity("vet_manager.Core.ConsultationCategory", b =>
                {
                    b.Navigation("ConsultationTypes");
                });

            modelBuilder.Entity("vet_manager.Core.Entities.Clients.Animal", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("vet_manager.Core.Entities.Clients.Breed", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("vet_manager.Core.Entities.Clients.Client", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("vet_manager.Core.Entities.Clients.Pet", b =>
                {
                    b.Navigation("Consultations");
                });

            modelBuilder.Entity("vet_manager.Core.Entities.Consultations.Consultation", b =>
                {
                    b.Navigation("RelatedConsultations");
                });

            modelBuilder.Entity("vet_manager.Core.Entities.Consultations.ConsultationType", b =>
                {
                    b.Navigation("Consultations");
                });

            modelBuilder.Entity("vet_manager.Core.Entities.Money.Operation", b =>
                {
                    b.Navigation("Additionals");

                    b.Navigation("Consultation");
                });
#pragma warning restore 612, 618
        }
    }
}
