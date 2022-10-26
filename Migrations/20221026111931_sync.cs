using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traveler.Migrations
{
    public partial class sync : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TuristasMediosTransporteLlegada_TuristaId",
                table: "TuristasMediosTransporteLlegada");

            migrationBuilder.DropIndex(
                name: "IX_TuristasMediosTransporteCiudad_TuristaId",
                table: "TuristasMediosTransporteCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_TuristasMediosTransporteLlegada_TuristaId_MedioTransporteId",
                table: "TuristasMediosTransporteLlegada",
                columns: new[] { "TuristaId", "MedioTransporteId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TuristasMediosTransporteCiudad_TuristaId_MedioTransporteId",
                table: "TuristasMediosTransporteCiudad",
                columns: new[] { "TuristaId", "MedioTransporteId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TuristasMediosTransporteLlegada_TuristaId_MedioTransporteId",
                table: "TuristasMediosTransporteLlegada");

            migrationBuilder.DropIndex(
                name: "IX_TuristasMediosTransporteCiudad_TuristaId_MedioTransporteId",
                table: "TuristasMediosTransporteCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_TuristasMediosTransporteLlegada_TuristaId",
                table: "TuristasMediosTransporteLlegada",
                column: "TuristaId");

            migrationBuilder.CreateIndex(
                name: "IX_TuristasMediosTransporteCiudad_TuristaId",
                table: "TuristasMediosTransporteCiudad",
                column: "TuristaId");
        }
    }
}
