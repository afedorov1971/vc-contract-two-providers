﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VirtoCommerce.Contracts.Data.Repositories.MySql;

#nullable disable

namespace VirtoCommerce.Contracts.Data.Migrations.MySql
{
    [DbContext(typeof(ContractMySqlDbContext))]
    partial class ContractMySqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("VirtoCommerce.Contracts.Data.Models.ContractDynamicPropertyObjectValueEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<bool?>("BooleanValue")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DateTimeValue")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal?>("DecimalValue")
                        .HasColumnType("decimal(18,5)");

                    b.Property<string>("DictionaryItemId")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<int?>("IntegerValue")
                        .HasColumnType("int");

                    b.Property<string>("Locale")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("LongTextValue")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ObjectId")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ObjectType")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PropertyId")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("PropertyName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ShortTextValue")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<string>("ValueType")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("ObjectId");

                    b.HasIndex("ObjectType", "ObjectId")
                        .HasDatabaseName("IX_ObjectType_ObjectId");

                    b.ToTable("ContractDynamicPropertyObjectValue", (string)null);
                });

            modelBuilder.Entity("VirtoCommerce.Contracts.Data.Models.ContractEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("BasePricelistAssignmentId")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Code")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(1024)
                        .HasColumnType("varchar(1024)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("PriorityPricelistAssignmentId")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("StoreId")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Contract", (string)null);
                });

            modelBuilder.Entity("VirtoCommerce.Contracts.Data.Models.ContractDynamicPropertyObjectValueEntity", b =>
                {
                    b.HasOne("VirtoCommerce.Contracts.Data.Models.ContractEntity", "Contract")
                        .WithMany("DynamicPropertyObjectValues")
                        .HasForeignKey("ObjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Contract");
                });

            modelBuilder.Entity("VirtoCommerce.Contracts.Data.Models.ContractEntity", b =>
                {
                    b.Navigation("DynamicPropertyObjectValues");
                });
#pragma warning restore 612, 618
        }
    }
}
