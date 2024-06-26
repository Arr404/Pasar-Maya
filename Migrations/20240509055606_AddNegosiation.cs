﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pasar_Maya_Api.Migrations
{
    /// <inheritdoc />
    public partial class AddNegosiation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductNegotiations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Negotiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastNegotiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NegoStatus = table.Column<int>(type: "int", nullable: false),
                    NegotiateById = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductNegotiations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductNegotiations_AspNetUsers_NegotiateById",
                        column: x => x.NegotiateById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductNegotiations_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductNegotiations_NegotiateById",
                table: "ProductNegotiations",
                column: "NegotiateById");

            migrationBuilder.CreateIndex(
                name: "IX_ProductNegotiations_ProductId",
                table: "ProductNegotiations",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductNegotiations");
        }
    }
}
