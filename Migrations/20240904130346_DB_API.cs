﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taller.Migrations
{
    /// <inheritdoc />
    public partial class DB_API : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Propietarios_PropietarioID",
                table: "Vehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehiculos",
                table: "Vehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Propietarios",
                table: "Propietarios");

            migrationBuilder.RenameTable(
                name: "Vehiculos",
                newName: "vehiculos");

            migrationBuilder.RenameTable(
                name: "Propietarios",
                newName: "propietarios");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_PropietarioID",
                table: "vehiculos",
                newName: "IX_vehiculos_PropietarioID");

            migrationBuilder.AlterColumn<string>(
                name: "TipoVehiculo",
                table: "vehiculos",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "vehiculos",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "vehiculos",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "vehiculos",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NumeroChasis",
                table: "vehiculos",
                type: "varchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "propietarios",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "propietarios",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vehiculos",
                table: "vehiculos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_propietarios",
                table: "propietarios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculos_propietarios_PropietarioID",
                table: "vehiculos",
                column: "PropietarioID",
                principalTable: "propietarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehiculos_propietarios_PropietarioID",
                table: "vehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vehiculos",
                table: "vehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_propietarios",
                table: "propietarios");

            migrationBuilder.DropColumn(
                name: "NumeroChasis",
                table: "vehiculos");

            migrationBuilder.RenameTable(
                name: "vehiculos",
                newName: "Vehiculos");

            migrationBuilder.RenameTable(
                name: "propietarios",
                newName: "Propietarios");

            migrationBuilder.RenameIndex(
                name: "IX_vehiculos_PropietarioID",
                table: "Vehiculos",
                newName: "IX_Vehiculos_PropietarioID");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "TipoVehiculo",
                keyValue: null,
                column: "TipoVehiculo",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "TipoVehiculo",
                table: "Vehiculos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Vehiculos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Vehiculos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Vehiculos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Propietarios",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Propietarios",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehiculos",
                table: "Vehiculos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Propietarios",
                table: "Propietarios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Propietarios_PropietarioID",
                table: "Vehiculos",
                column: "PropietarioID",
                principalTable: "Propietarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
