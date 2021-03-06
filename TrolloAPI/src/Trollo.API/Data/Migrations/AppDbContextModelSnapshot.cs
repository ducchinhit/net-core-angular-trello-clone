﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TrolloAPI.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    internal class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TrolloAPI.Data.Entities.Board", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("CreatedAt")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("ModifiedAt")
                    .HasColumnType("datetime2");

                b.Property<string>("Scope")
                    .IsRequired()
                    .HasColumnType("nvarchar(16)")
                    .HasMaxLength(16);

                b.Property<string>("Status")
                    .IsRequired()
                    .HasColumnType("nvarchar(16)")
                    .HasMaxLength(16);

                b.Property<string>("Title")
                    .IsRequired()
                    .HasColumnType("nvarchar(255)")
                    .HasMaxLength(255);

                b.Property<Guid>("UserId")
                    .HasColumnType("uniqueidentifier");

                b.HasKey("Id");

                b.ToTable("Boards");
            });

            modelBuilder.Entity("TrolloAPI.Data.Entities.Card", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("CreatedAt")
                    .HasColumnType("datetime2");

                b.Property<string>("Description")
                    .HasColumnType("nvarchar(max)");

                b.Property<Guid>("ListCardId")
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("ModifiedAt")
                    .HasColumnType("datetime2");

                b.Property<int>("Order")
                    .HasColumnType("int");

                b.Property<string>("Title")
                    .IsRequired()
                    .HasColumnType("nvarchar(255)")
                    .HasMaxLength(255);

                b.HasKey("Id");

                b.HasIndex("ListCardId");

                b.ToTable("Cards");
            });

            modelBuilder.Entity("TrolloAPI.Data.Entities.ListCard", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("BoardId")
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("CreatedAt")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("ModifiedAt")
                    .HasColumnType("datetime2");

                b.Property<int>("Order")
                    .HasColumnType("int");

                b.Property<string>("Title")
                    .IsRequired()
                    .HasColumnType("nvarchar(255)")
                    .HasMaxLength(255);

                b.HasKey("Id");

                b.HasIndex("BoardId");

                b.ToTable("ListCards");
            });

            modelBuilder.Entity("TrolloAPI.Data.Entities.Card", b =>
            {
                b.HasOne("TrolloAPI.Data.Entities.ListCard", "ListCard")
                    .WithMany("Cards")
                    .HasForeignKey("ListCardId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("TrolloAPI.Data.Entities.ListCard", b =>
            {
                b.HasOne("TrolloAPI.Data.Entities.Board", "Board")
                    .WithMany("ListCards")
                    .HasForeignKey("BoardId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });
#pragma warning restore 612, 618
        }
    }
}