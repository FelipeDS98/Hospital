using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospiEnCasa.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Historia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Entorno = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarjetaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HorasLaborales = table.Column<int>(type: "int", nullable: true),
                    Parentesco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistroRethus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitud = table.Column<float>(type: "real", nullable: true),
                    Longitud = table.Column<float>(type: "real", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FamiliarId = table.Column<int>(type: "int", nullable: true),
                    EnfermeraId = table.Column<int>(type: "int", nullable: true),
                    MedicoId = table.Column<int>(type: "int", nullable: true),
                    HistoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persona_Historia_HistoriaId",
                        column: x => x.HistoriaId,
                        principalTable: "Historia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Persona_EnfermeraId",
                        column: x => x.EnfermeraId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Persona_FamiliarId",
                        column: x => x.FamiliarId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Persona_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SugerenciaCuidado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SugerenciaCuidado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SugerenciaCuidado_Historia_HistoriaId",
                        column: x => x.HistoriaId,
                        principalTable: "Historia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SignoVital",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false),
                    Signo = table.Column<int>(type: "int", nullable: false),
                    PacienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignoVital", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignoVital_Persona_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persona_EnfermeraId",
                table: "Persona",
                column: "EnfermeraId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_FamiliarId",
                table: "Persona",
                column: "FamiliarId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_HistoriaId",
                table: "Persona",
                column: "HistoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_MedicoId",
                table: "Persona",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_SignoVital_PacienteId",
                table: "SignoVital",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_SugerenciaCuidado_HistoriaId",
                table: "SugerenciaCuidado",
                column: "HistoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SignoVital");

            migrationBuilder.DropTable(
                name: "SugerenciaCuidado");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Historia");
        }
    }
}
