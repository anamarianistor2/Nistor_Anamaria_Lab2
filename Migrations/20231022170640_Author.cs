﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nistor_Anamaria_Lab2.Migrations
{
    public partial class Author : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Authors_AuthorsID",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "AuthorsID",
                table: "Book",
                newName: "AuthorID");

            migrationBuilder.RenameIndex(
                name: "IX_Book_AuthorsID",
                table: "Book",
                newName: "IX_Book_AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Authors_AuthorID",
                table: "Book",
                column: "AuthorID",
                principalTable: "Authors",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Authors_AuthorID",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "Book",
                newName: "AuthorsID");

            migrationBuilder.RenameIndex(
                name: "IX_Book_AuthorID",
                table: "Book",
                newName: "IX_Book_AuthorsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Authors_AuthorsID",
                table: "Book",
                column: "AuthorsID",
                principalTable: "Authors",
                principalColumn: "ID");
        }
    }
}
