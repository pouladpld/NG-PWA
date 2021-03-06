﻿// <auto-generated />
using Futbol.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Futbol.Web.Migrations
{
    [DbContext(typeof(FutbolContext))]
    [Migration("20180708142244_EditTeam")]
    partial class EditTeam
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Futbol.Web.Data.PushSubscription", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Agents")
                        .HasColumnType("JSON");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("JSON");

                    b.HasKey("Id");

                    b.ToTable("PushSubscriptions");
                });

            modelBuilder.Entity("Futbol.Web.Data.Team", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<string>("CrestUrl");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("ShortName");

                    b.Property<string>("SquadMarketValue");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
