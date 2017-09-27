﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Project56.Models;
using System;

namespace Project56.Migrations
{
    [DbContext(typeof(DBModel))]
    partial class DBModelModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Project56.Models.ItmCategories", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("description");

                    b.Property<DateTime>("dt_created");

                    b.Property<DateTime>("dt_modified");

                    b.Property<int>("l_show");

                    b.HasKey("id");

                    b.ToTable("itmcat_db_set");
                });

            modelBuilder.Entity("Project56.Models.Itms", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("category_id");

                    b.Property<string>("description");

                    b.Property<DateTime>("dt_created");

                    b.Property<DateTime>("dt_modified");

                    b.Property<int>("l_show");

                    b.Property<string>("long_description");

                    b.Property<string>("photo_url");

                    b.Property<float>("price");

                    b.HasKey("id");

                    b.ToTable("itms_db_set");
                });

            modelBuilder.Entity("Project56.Models.Logs", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("dt_created");

                    b.Property<DateTime>("dt_modified");

                    b.Property<int>("l_show");

                    b.Property<int>("log_type");

                    b.Property<int>("user_id");

                    b.HasKey("id");

                    b.ToTable("logs_db_set");
                });

            modelBuilder.Entity("Project56.Models.OrdHistory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("description");

                    b.Property<DateTime>("dt_created");

                    b.Property<DateTime>("dt_modified");

                    b.Property<int>("l_show");

                    b.HasKey("id");

                    b.ToTable("ordhis_db_set");
                });

            modelBuilder.Entity("Project56.Models.OrdLines", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("dt_created");

                    b.Property<DateTime>("dt_modified");

                    b.Property<int>("itm_id");

                    b.Property<int>("l_show");

                    b.Property<int>("ord_id");

                    b.Property<float>("qty");

                    b.HasKey("id");

                    b.ToTable("ordlines_db_set");
                });

            modelBuilder.Entity("Project56.Models.OrdMains", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("dt_created");

                    b.Property<DateTime>("dt_delivery");

                    b.Property<DateTime>("dt_modified");

                    b.Property<DateTime>("dt_order");

                    b.Property<int>("l_show");

                    b.Property<int>("ordstatus_id");

                    b.Property<int>("user_id");

                    b.HasKey("id");

                    b.ToTable("ordmain_db_set");
                });

            modelBuilder.Entity("Project56.Models.OrdStatus", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("description");

                    b.Property<DateTime>("dt_created");

                    b.Property<DateTime>("dt_modified");

                    b.Property<int>("l_show");

                    b.HasKey("id");

                    b.ToTable("ordstatus_db_set");
                });

            modelBuilder.Entity("Project56.Models.Users", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("delivery_adres");

                    b.Property<string>("dt_birth");

                    b.Property<DateTime>("dt_created");

                    b.Property<DateTime>("dt_modified");

                    b.Property<string>("email");

                    b.Property<string>("fullname");

                    b.Property<string>("gender");

                    b.Property<int>("l_show");

                    b.Property<string>("password");

                    b.Property<string>("street");

                    b.Property<string>("streetnumber");

                    b.Property<int>("user_level");

                    b.Property<string>("zipcode");

                    b.HasKey("id");

                    b.ToTable("users_db_set");
                });
#pragma warning restore 612, 618
        }
    }
}
