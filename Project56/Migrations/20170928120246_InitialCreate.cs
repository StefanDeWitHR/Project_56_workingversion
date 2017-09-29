using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Project56.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "itmcat_db_set",
                columns: table => new
                {
                    id = table.Column<int>(type: "int4", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    description = table.Column<string>(type: "text", nullable: true),
                    dt_created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    dt_modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    l_show = table.Column<int>(type: "int4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itmcat_db_set", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "itms_db_set",
                columns: table => new
                {
                    id = table.Column<int>(type: "int4", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    category_id = table.Column<int>(type: "int4", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    dt_created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    dt_modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    l_show = table.Column<int>(type: "int4", nullable: false),
                    long_description = table.Column<string>(type: "text", nullable: true),
                    photo_url = table.Column<string>(type: "text", nullable: true),
                    price = table.Column<float>(type: "float4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itms_db_set", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "logs_db_set",
                columns: table => new
                {
                    id = table.Column<int>(type: "int4", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    dt_created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    dt_modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    l_show = table.Column<int>(type: "int4", nullable: false),
                    log_type = table.Column<int>(type: "int4", nullable: false),
                    user_id = table.Column<int>(type: "int4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logs_db_set", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ordhis_db_set",
                columns: table => new
                {
                    id = table.Column<int>(type: "int4", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    description = table.Column<string>(type: "text", nullable: true),
                    dt_created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    dt_modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    l_show = table.Column<int>(type: "int4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordhis_db_set", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ordlines_db_set",
                columns: table => new
                {
                    id = table.Column<int>(type: "int4", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    dt_created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    dt_modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    itm_id = table.Column<int>(type: "int4", nullable: false),
                    l_show = table.Column<int>(type: "int4", nullable: false),
                    ord_id = table.Column<int>(type: "int4", nullable: false),
                    qty = table.Column<float>(type: "float4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordlines_db_set", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ordmain_db_set",
                columns: table => new
                {
                    id = table.Column<int>(type: "int4", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    dt_created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    dt_delivery = table.Column<DateTime>(type: "timestamp", nullable: false),
                    dt_modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    dt_order = table.Column<DateTime>(type: "timestamp", nullable: false),
                    l_show = table.Column<int>(type: "int4", nullable: false),
                    ordstatus_id = table.Column<int>(type: "int4", nullable: false),
                    user_id = table.Column<int>(type: "int4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordmain_db_set", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ordstatus_db_set",
                columns: table => new
                {
                    id = table.Column<int>(type: "int4", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    description = table.Column<string>(type: "text", nullable: true),
                    dt_created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    dt_modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    l_show = table.Column<int>(type: "int4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordstatus_db_set", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users_db_set",
                columns: table => new
                {
                    id = table.Column<int>(type: "int4", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    a_adres = table.Column<string>(type: "text", nullable: true),
                    a_city = table.Column<string>(type: "text", nullable: true),
                    a_zipcode = table.Column<string>(type: "text", nullable: true),
                    d_adres = table.Column<string>(type: "text", nullable: true),
                    d_city = table.Column<string>(type: "text", nullable: true),
                    d_zipcode = table.Column<string>(type: "text", nullable: true),
                    dt_birth = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    fullname = table.Column<string>(type: "text", nullable: true),
                    gender = table.Column<string>(type: "text", nullable: true),
                    l_show = table.Column<int>(type: "int4", nullable: false),
                    password = table.Column<string>(type: "text", nullable: true),
                    user_level = table.Column<int>(type: "int4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users_db_set", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "itmcat_db_set");

            migrationBuilder.DropTable(
                name: "itms_db_set");

            migrationBuilder.DropTable(
                name: "logs_db_set");

            migrationBuilder.DropTable(
                name: "ordhis_db_set");

            migrationBuilder.DropTable(
                name: "ordlines_db_set");

            migrationBuilder.DropTable(
                name: "ordmain_db_set");

            migrationBuilder.DropTable(
                name: "ordstatus_db_set");

            migrationBuilder.DropTable(
                name: "users_db_set");
        }
    }
}
