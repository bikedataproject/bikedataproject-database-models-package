﻿// <auto-generated />
using System;
using BDPDatabase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace bikedataproject_database_models_package.Migrations
{
    [DbContext(typeof(BikeDataDbContext))]
    [Migration("20200722085039_AddedUserIsHistoryFetchedField")]
    partial class AddedUserIsHistoryFetchedField
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("BDPDatabase.Contribution", b =>
                {
                    b.Property<int>("ContributionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Distance")
                        .HasColumnType("integer");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<byte[]>("PointsGeom")
                        .HasColumnType("bytea");

                    b.Property<DateTimeOffset[]>("PointsTime")
                        .HasColumnType("timestamp with time zone[]");

                    b.Property<DateTimeOffset>("TimeStampStart")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("TimeStampStop")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserAgent")
                        .HasColumnType("text");

                    b.HasKey("ContributionId");

                    b.ToTable("Contributions");
                });

            modelBuilder.Entity("BDPDatabase.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AccessToken")
                        .HasColumnType("text");

                    b.Property<int>("ExpiresAt")
                        .HasColumnType("integer");

                    b.Property<int>("ExpiresIn")
                        .HasColumnType("integer");

                    b.Property<bool>("IsHistoryFetched")
                        .HasColumnType("boolean");

                    b.Property<string>("Provider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderUser")
                        .HasColumnType("text");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("text");

                    b.Property<DateTime>("TokenCreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("UserIdentifier")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BDPDatabase.UserContribution", b =>
                {
                    b.Property<int>("UserContributionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ContributionId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("UserContributionId");

                    b.HasIndex("UserId");

                    b.ToTable("UserContributions");
                });

            modelBuilder.Entity("BDPDatabase.UserContribution", b =>
                {
                    b.HasOne("BDPDatabase.User", null)
                        .WithMany("UserContributions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
