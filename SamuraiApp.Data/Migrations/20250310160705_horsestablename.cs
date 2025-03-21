﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SamuraiApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class horsestablename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Horse_Samurais_SamuraiId",
                table: "Horse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Horse",
                table: "Horse");

            migrationBuilder.RenameTable(
                name: "Horse",
                newName: "Horses");

            migrationBuilder.RenameIndex(
                name: "IX_Horse_SamuraiId",
                table: "Horses",
                newName: "IX_Horses_SamuraiId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Horses",
                table: "Horses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Horses_Samurais_SamuraiId",
                table: "Horses",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Horses_Samurais_SamuraiId",
                table: "Horses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Horses",
                table: "Horses");

            migrationBuilder.RenameTable(
                name: "Horses",
                newName: "Horse");

            migrationBuilder.RenameIndex(
                name: "IX_Horses_SamuraiId",
                table: "Horse",
                newName: "IX_Horse_SamuraiId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Horse",
                table: "Horse",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Horse_Samurais_SamuraiId",
                table: "Horse",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
