﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class mig_about_nameUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_About",
                table: "About");

            migrationBuilder.RenameTable(
                name: "About",
                newName: "Abouts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abouts",
                table: "Abouts",
                column: "AboutId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Abouts",
                table: "Abouts");

            migrationBuilder.RenameTable(
                name: "Abouts",
                newName: "About");

            migrationBuilder.AddPrimaryKey(
                name: "PK_About",
                table: "About",
                column: "AboutId");
        }
    }
}
