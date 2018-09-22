using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevSlop.Migrations
{
    public partial class EventUrls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WhatUrl",
                table: "Schedules",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "When",
                table: "Schedules",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "WhenUrl",
                table: "Schedules",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhereUrl",
                table: "Schedules",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhoUrl",
                table: "Schedules",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WhatUrl",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "When",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "WhenUrl",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "WhereUrl",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "WhoUrl",
                table: "Schedules");
        }
    }
}
