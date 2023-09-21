﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tingle.Dependabot.Models;

#nullable disable

namespace Tingle.Dependabot.Migrations
{
    [DbContext(typeof(MainDbContext))]
    partial class MainDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.DataProtection.EntityFrameworkCore.DataProtectionKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FriendlyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Xml")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DataProtectionKeys");
                });

            modelBuilder.Entity("Tingle.Dependabot.Models.Management.Project", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<byte[]>("Etag")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("GithubToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Private")
                        .HasColumnType("bit");

                    b.Property<string>("ProviderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Secrets")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("Synchronized")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("Updated")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Created")
                        .IsDescending();

                    b.HasIndex("Password")
                        .IsUnique();

                    b.HasIndex("ProviderId")
                        .IsUnique();

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Tingle.Dependabot.Models.Management.Repository", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ConfigFileContents")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<byte[]>("Etag")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("LatestCommit")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProviderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Registries")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SyncException")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("Updated")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Updates")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Created")
                        .IsDescending();

                    b.HasIndex("ProjectId");

                    b.HasIndex("ProviderId")
                        .IsUnique();

                    b.ToTable("Repositories");
                });

            modelBuilder.Entity("Tingle.Dependabot.Models.Management.UpdateJob", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AuthKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Commit")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Directory")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<long?>("Duration")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset?>("End")
                        .HasColumnType("datetimeoffset");

                    b.Property<byte[]>("Etag")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("EventBusId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Log")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PackageEcosystem")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RepositoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RepositorySlug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("Start")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Trigger")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthKey")
                        .IsUnique();

                    b.HasIndex("Created")
                        .IsDescending();

                    b.HasIndex("ProjectId");

                    b.HasIndex("RepositoryId");

                    b.HasIndex("PackageEcosystem", "Directory");

                    b.HasIndex("PackageEcosystem", "Directory", "EventBusId")
                        .IsUnique()
                        .HasFilter("[EventBusId] IS NOT NULL");

                    b.ToTable("UpdateJobs");
                });

            modelBuilder.Entity("Tingle.Dependabot.Models.Management.Project", b =>
                {
                    b.OwnsOne("Tingle.Dependabot.Models.Management.ProjectAutoApprove", "AutoApprove", b1 =>
                        {
                            b1.Property<string>("ProjectId")
                                .HasColumnType("nvarchar(50)");

                            b1.Property<bool>("Enabled")
                                .HasColumnType("bit");

                            b1.HasKey("ProjectId");

                            b1.ToTable("Projects");

                            b1.WithOwner()
                                .HasForeignKey("ProjectId");
                        });

                    b.OwnsOne("Tingle.Dependabot.Models.Management.ProjectAutoComplete", "AutoComplete", b1 =>
                        {
                            b1.Property<string>("ProjectId")
                                .HasColumnType("nvarchar(50)");

                            b1.Property<bool>("Enabled")
                                .HasColumnType("bit");

                            b1.Property<string>("IgnoreConfigs")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int?>("MergeStrategy")
                                .HasColumnType("int");

                            b1.HasKey("ProjectId");

                            b1.ToTable("Projects");

                            b1.WithOwner()
                                .HasForeignKey("ProjectId");
                        });

                    b.Navigation("AutoApprove")
                        .IsRequired();

                    b.Navigation("AutoComplete")
                        .IsRequired();
                });

            modelBuilder.Entity("Tingle.Dependabot.Models.Management.Repository", b =>
                {
                    b.HasOne("Tingle.Dependabot.Models.Management.Project", null)
                        .WithMany("Repositories")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Tingle.Dependabot.Models.Management.UpdateJob", b =>
                {
                    b.OwnsOne("Tingle.Dependabot.Models.Management.UpdateJobError", "Error", b1 =>
                        {
                            b1.Property<string>("UpdateJobId")
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("Detail")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Type")
                                .IsRequired()
                                .HasColumnType("nvarchar(450)");

                            b1.HasKey("UpdateJobId");

                            b1.HasIndex("Type");

                            b1.ToTable("UpdateJobs");

                            b1.WithOwner()
                                .HasForeignKey("UpdateJobId");
                        });

                    b.OwnsOne("Tingle.Dependabot.Models.Management.UpdateJobResources", "Resources", b1 =>
                        {
                            b1.Property<string>("UpdateJobId")
                                .HasColumnType("nvarchar(50)");

                            b1.Property<double>("Cpu")
                                .HasColumnType("float");

                            b1.Property<double>("Memory")
                                .HasColumnType("float");

                            b1.HasKey("UpdateJobId");

                            b1.ToTable("UpdateJobs");

                            b1.WithOwner()
                                .HasForeignKey("UpdateJobId");
                        });

                    b.Navigation("Error");

                    b.Navigation("Resources")
                        .IsRequired();
                });

            modelBuilder.Entity("Tingle.Dependabot.Models.Management.Project", b =>
                {
                    b.Navigation("Repositories");
                });
#pragma warning restore 612, 618
        }
    }
}
