﻿// <auto-generated />
using System;
using ExcelGeneration.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DynamicTableCreation.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231212151747_AccessService")]
    partial class AccessService
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DynamicTableCreation.Models.EntityColumnListMetadataModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("ColumnPrimaryKey")
                        .HasColumnType("boolean");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Datatype")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DateMaxValue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DateMinValue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DefaultValue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EntityColumnName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EntityId")
                        .HasColumnType("integer");

                    b.Property<string>("False")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsNullable")
                        .HasColumnType("boolean");

                    b.Property<int>("Length")
                        .HasColumnType("integer");

                    b.Property<int>("ListEntityId")
                        .HasColumnType("integer");

                    b.Property<int>("ListEntityKey")
                        .HasColumnType("integer");

                    b.Property<int>("ListEntityValue")
                        .HasColumnType("integer");

                    b.Property<int?>("MaxLength")
                        .HasColumnType("integer");

                    b.Property<int?>("MaxRange")
                        .HasColumnType("integer");

                    b.Property<int?>("MinLength")
                        .HasColumnType("integer");

                    b.Property<int?>("MinRange")
                        .HasColumnType("integer");

                    b.Property<string>("True")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("EntityId");

                    b.ToTable("EntityColumnListMetadataModels");
                });

            modelBuilder.Entity("DynamicTableCreation.Models.EntityListMetadataModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EntityName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("EntityListMetadataModels");
                });

            modelBuilder.Entity("DynamicTableCreation.Models.LogChild", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("ErrorMessage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ErrorRowNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Filedata")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ParentID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("ParentID");

                    b.ToTable("logChilds");
                });

            modelBuilder.Entity("DynamicTableCreation.Models.LogParent", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<int>("Entity_Id")
                        .HasColumnType("integer");

                    b.Property<int>("FailCount")
                        .HasColumnType("integer");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PassCount")
                        .HasColumnType("integer");

                    b.Property<int>("RecordCount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("User_Id")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("logParents");
                });

            modelBuilder.Entity("DynamicTableCreation.Models.UserRoleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UserRoleModel");
                });

            modelBuilder.Entity("DynamicTableCreation.Models.UserTableModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("UserTableModel");
                });

            modelBuilder.Entity("DynamicTableCreation.Models.EntityColumnListMetadataModel", b =>
                {
                    b.HasOne("DynamicTableCreation.Models.EntityListMetadataModel", "EntityList")
                        .WithMany("EntityColumns")
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntityList");
                });

            modelBuilder.Entity("DynamicTableCreation.Models.LogChild", b =>
                {
                    b.HasOne("DynamicTableCreation.Models.LogParent", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("DynamicTableCreation.Models.EntityListMetadataModel", b =>
                {
                    b.Navigation("EntityColumns");
                });
#pragma warning restore 612, 618
        }
    }
}
