using Microsoft.EntityFrameworkCore.Migrations;

namespace HospiEnCasa.App.Persistencia.Migrations
{
    public partial class CambiosAppContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Historia_HistoriaId",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Persona_EnfermeraId",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Persona_FamiliarId",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Persona_MedicoId",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_SignoVital_Persona_PacienteId",
                table: "SignoVital");

            migrationBuilder.DropForeignKey(
                name: "FK_SugerenciaCuidado_Historia_HistoriaId",
                table: "SugerenciaCuidado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SugerenciaCuidado",
                table: "SugerenciaCuidado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SignoVital",
                table: "SignoVital");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persona",
                table: "Persona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Historia",
                table: "Historia");

            migrationBuilder.RenameTable(
                name: "SugerenciaCuidado",
                newName: "SugerenciasCuidado");

            migrationBuilder.RenameTable(
                name: "SignoVital",
                newName: "SignosVitales");

            migrationBuilder.RenameTable(
                name: "Persona",
                newName: "Personas");

            migrationBuilder.RenameTable(
                name: "Historia",
                newName: "Historias");

            migrationBuilder.RenameIndex(
                name: "IX_SugerenciaCuidado_HistoriaId",
                table: "SugerenciasCuidado",
                newName: "IX_SugerenciasCuidado_HistoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_SignoVital_PacienteId",
                table: "SignosVitales",
                newName: "IX_SignosVitales_PacienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Persona_MedicoId",
                table: "Personas",
                newName: "IX_Personas_MedicoId");

            migrationBuilder.RenameIndex(
                name: "IX_Persona_HistoriaId",
                table: "Personas",
                newName: "IX_Personas_HistoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Persona_FamiliarId",
                table: "Personas",
                newName: "IX_Personas_FamiliarId");

            migrationBuilder.RenameIndex(
                name: "IX_Persona_EnfermeraId",
                table: "Personas",
                newName: "IX_Personas_EnfermeraId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SugerenciasCuidado",
                table: "SugerenciasCuidado",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignosVitales",
                table: "SignosVitales",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Historias",
                table: "Historias",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Historias_HistoriaId",
                table: "Personas",
                column: "HistoriaId",
                principalTable: "Historias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Personas_EnfermeraId",
                table: "Personas",
                column: "EnfermeraId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Personas_FamiliarId",
                table: "Personas",
                column: "FamiliarId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Personas_MedicoId",
                table: "Personas",
                column: "MedicoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SignosVitales_Personas_PacienteId",
                table: "SignosVitales",
                column: "PacienteId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SugerenciasCuidado_Historias_HistoriaId",
                table: "SugerenciasCuidado",
                column: "HistoriaId",
                principalTable: "Historias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Historias_HistoriaId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Personas_EnfermeraId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Personas_FamiliarId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Personas_MedicoId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_SignosVitales_Personas_PacienteId",
                table: "SignosVitales");

            migrationBuilder.DropForeignKey(
                name: "FK_SugerenciasCuidado_Historias_HistoriaId",
                table: "SugerenciasCuidado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SugerenciasCuidado",
                table: "SugerenciasCuidado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SignosVitales",
                table: "SignosVitales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Historias",
                table: "Historias");

            migrationBuilder.RenameTable(
                name: "SugerenciasCuidado",
                newName: "SugerenciaCuidado");

            migrationBuilder.RenameTable(
                name: "SignosVitales",
                newName: "SignoVital");

            migrationBuilder.RenameTable(
                name: "Personas",
                newName: "Persona");

            migrationBuilder.RenameTable(
                name: "Historias",
                newName: "Historia");

            migrationBuilder.RenameIndex(
                name: "IX_SugerenciasCuidado_HistoriaId",
                table: "SugerenciaCuidado",
                newName: "IX_SugerenciaCuidado_HistoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_SignosVitales_PacienteId",
                table: "SignoVital",
                newName: "IX_SignoVital_PacienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Personas_MedicoId",
                table: "Persona",
                newName: "IX_Persona_MedicoId");

            migrationBuilder.RenameIndex(
                name: "IX_Personas_HistoriaId",
                table: "Persona",
                newName: "IX_Persona_HistoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Personas_FamiliarId",
                table: "Persona",
                newName: "IX_Persona_FamiliarId");

            migrationBuilder.RenameIndex(
                name: "IX_Personas_EnfermeraId",
                table: "Persona",
                newName: "IX_Persona_EnfermeraId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SugerenciaCuidado",
                table: "SugerenciaCuidado",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignoVital",
                table: "SignoVital",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persona",
                table: "Persona",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Historia",
                table: "Historia",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Historia_HistoriaId",
                table: "Persona",
                column: "HistoriaId",
                principalTable: "Historia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Persona_EnfermeraId",
                table: "Persona",
                column: "EnfermeraId",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Persona_FamiliarId",
                table: "Persona",
                column: "FamiliarId",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Persona_MedicoId",
                table: "Persona",
                column: "MedicoId",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SignoVital_Persona_PacienteId",
                table: "SignoVital",
                column: "PacienteId",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SugerenciaCuidado_Historia_HistoriaId",
                table: "SugerenciaCuidado",
                column: "HistoriaId",
                principalTable: "Historia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
