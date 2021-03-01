﻿// <auto-generated />
using System;
using ManalyticsBackend;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ManalyticsBackend.Migrations
{
    [DbContext(typeof(ManalyticsDbContext))]
    [Migration("20210301203822_CreateColorIdentity")]
    partial class CreateColorIdentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("ManalyticsBackend.Models.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Artist")
                        .HasColumnType("longtext");

                    b.Property<int>("CMC")
                        .HasColumnType("int");

                    b.Property<int?>("ColorIdentityId")
                        .HasColumnType("int");

                    b.Property<string>("ContainingSetSetId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FlavorText")
                        .HasColumnType("longtext");

                    b.Property<string>("ManaCost")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("CardId");

                    b.HasIndex("ColorIdentityId");

                    b.HasIndex("ContainingSetSetId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("ManalyticsBackend.Models.ColorIdentity", b =>
                {
                    b.Property<int>("ColorIdentityId")
                        .HasColumnType("int");

                    b.HasKey("ColorIdentityId");

                    b.ToTable("ColorIdentity");
                });

            modelBuilder.Entity("ManalyticsBackend.Models.PrimaryType", b =>
                {
                    b.Property<int>("PrimaryTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("CardId")
                        .HasColumnType("int");

                    b.HasKey("PrimaryTypeId");

                    b.HasIndex("CardId");

                    b.ToTable("PrimaryType");
                });

            modelBuilder.Entity("ManalyticsBackend.Models.Set", b =>
                {
                    b.Property<string>("SetId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("SetId");

                    b.ToTable("Sets");
                });

            modelBuilder.Entity("ManalyticsBackend.Models.SubType", b =>
                {
                    b.Property<string>("SubTypeId")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("CardId")
                        .HasColumnType("int");

                    b.HasKey("SubTypeId");

                    b.HasIndex("CardId");

                    b.ToTable("SubType");
                });

            modelBuilder.Entity("ManalyticsBackend.Models.Card", b =>
                {
                    b.HasOne("ManalyticsBackend.Models.ColorIdentity", "ColorIdentity")
                        .WithMany()
                        .HasForeignKey("ColorIdentityId");

                    b.HasOne("ManalyticsBackend.Models.Set", "ContainingSet")
                        .WithMany("Cards")
                        .HasForeignKey("ContainingSetSetId");

                    b.Navigation("ColorIdentity");

                    b.Navigation("ContainingSet");
                });

            modelBuilder.Entity("ManalyticsBackend.Models.PrimaryType", b =>
                {
                    b.HasOne("ManalyticsBackend.Models.Card", null)
                        .WithMany("PrimaryTypes")
                        .HasForeignKey("CardId");
                });

            modelBuilder.Entity("ManalyticsBackend.Models.SubType", b =>
                {
                    b.HasOne("ManalyticsBackend.Models.Card", null)
                        .WithMany("SubTypes")
                        .HasForeignKey("CardId");
                });

            modelBuilder.Entity("ManalyticsBackend.Models.Card", b =>
                {
                    b.Navigation("PrimaryTypes");

                    b.Navigation("SubTypes");
                });

            modelBuilder.Entity("ManalyticsBackend.Models.Set", b =>
                {
                    b.Navigation("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}
