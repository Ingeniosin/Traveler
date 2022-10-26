using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Traveler.Migrations
{
    public partial class sync1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MotivoViajeId",
                table: "Turistas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TiposTelefono",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    EsCelular = table.Column<bool>(type: "boolean", nullable: false),
                    EsFijo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposTelefono", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TuristasCorreos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: true),
                    TuristaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuristasCorreos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TuristasCorreos_Turistas_TuristaId",
                        column: x => x.TuristaId,
                        principalTable: "Turistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TuristasTelefonos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Numero = table.Column<string>(type: "text", nullable: true),
                    TipoTelefonoId = table.Column<int>(type: "integer", nullable: false),
                    EsWhatsapp = table.Column<bool>(type: "boolean", nullable: false),
                    EsLlamada = table.Column<bool>(type: "boolean", nullable: false),
                    EsSms = table.Column<bool>(type: "boolean", nullable: false),
                    EsPrincipal = table.Column<bool>(type: "boolean", nullable: false),
                    TuristaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuristasTelefonos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TuristasTelefonos_TiposTelefono_TipoTelefonoId",
                        column: x => x.TipoTelefonoId,
                        principalTable: "TiposTelefono",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TuristasTelefonos_Turistas_TuristaId",
                        column: x => x.TuristaId,
                        principalTable: "Turistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Turistas_MotivoViajeId",
                table: "Turistas",
                column: "MotivoViajeId");

            migrationBuilder.CreateIndex(
                name: "IX_TuristasCorreos_TuristaId",
                table: "TuristasCorreos",
                column: "TuristaId");

            migrationBuilder.CreateIndex(
                name: "IX_TuristasTelefonos_TipoTelefonoId",
                table: "TuristasTelefonos",
                column: "TipoTelefonoId");

            migrationBuilder.CreateIndex(
                name: "IX_TuristasTelefonos_TuristaId",
                table: "TuristasTelefonos",
                column: "TuristaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Turistas_MotivosViaje_MotivoViajeId",
                table: "Turistas",
                column: "MotivoViajeId",
                principalTable: "MotivosViaje",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turistas_MotivosViaje_MotivoViajeId",
                table: "Turistas");

            migrationBuilder.DropTable(
                name: "TuristasCorreos");

            migrationBuilder.DropTable(
                name: "TuristasTelefonos");

            migrationBuilder.DropTable(
                name: "TiposTelefono");

            migrationBuilder.DropIndex(
                name: "IX_Turistas_MotivoViajeId",
                table: "Turistas");

            migrationBuilder.DropColumn(
                name: "MotivoViajeId",
                table: "Turistas");
        }
    }
}
