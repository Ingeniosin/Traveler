using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Traveler.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    EsHombre = table.Column<bool>(type: "boolean", nullable: false),
                    EsMujer = table.Column<bool>(type: "boolean", nullable: false),
                    EsOtro = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MediosTransporte",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    EsAutoParticular = table.Column<bool>(type: "boolean", nullable: false),
                    EsTaxi = table.Column<bool>(type: "boolean", nullable: false),
                    EsColectivo = table.Column<bool>(type: "boolean", nullable: false),
                    EsBus = table.Column<bool>(type: "boolean", nullable: false),
                    EsTren = table.Column<bool>(type: "boolean", nullable: false),
                    EsAvion = table.Column<bool>(type: "boolean", nullable: false),
                    EsBarco = table.Column<bool>(type: "boolean", nullable: false),
                    EsBicicleta = table.Column<bool>(type: "boolean", nullable: false),
                    EsMoto = table.Column<bool>(type: "boolean", nullable: false),
                    EsOtro = table.Column<bool>(type: "boolean", nullable: false),
                    EsLlegada = table.Column<bool>(type: "boolean", nullable: false),
                    EsCiudad = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediosTransporte", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotivosViaje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    EsTrabajo = table.Column<bool>(type: "boolean", nullable: false),
                    EsEstudio = table.Column<bool>(type: "boolean", nullable: false),
                    EsTurismo = table.Column<bool>(type: "boolean", nullable: false),
                    EsOtro = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotivosViaje", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    PermisosAdministrador = table.Column<bool>(type: "boolean", nullable: false),
                    PermisosOperador = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposDocumentoIdentidad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    EsRegistroCivil = table.Column<bool>(type: "boolean", nullable: false),
                    EsTarjetaIdentidad = table.Column<bool>(type: "boolean", nullable: false),
                    EsCedulaCiudadania = table.Column<bool>(type: "boolean", nullable: false),
                    EsTarjetaExtranjeria = table.Column<bool>(type: "boolean", nullable: false),
                    EsCedulaExtranjeria = table.Column<bool>(type: "boolean", nullable: false),
                    EsPasaporte = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDocumentoIdentidad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposOrganizacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    EsHotel = table.Column<bool>(type: "boolean", nullable: false),
                    EsAgencia = table.Column<bool>(type: "boolean", nullable: false),
                    EsHostal = table.Column<bool>(type: "boolean", nullable: false),
                    EsRestaurante = table.Column<bool>(type: "boolean", nullable: false),
                    EsOtro = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposOrganizacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ubicaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Pais = table.Column<string>(type: "text", nullable: true),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    Ciudad = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatosPersonales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PrimerNombre = table.Column<string>(type: "text", nullable: false),
                    SegundoNombre = table.Column<string>(type: "text", nullable: true),
                    PrimerApellido = table.Column<string>(type: "text", nullable: false),
                    SegundoApellido = table.Column<string>(type: "text", nullable: true),
                    TipoDocumentoIdentidadId = table.Column<int>(type: "integer", nullable: false),
                    Identificacion = table.Column<string>(type: "text", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    GeneroId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosPersonales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DatosPersonales_Generos_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Generos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DatosPersonales_TiposDocumentoIdentidad_TipoDocumentoIdenti~",
                        column: x => x.TipoDocumentoIdentidadId,
                        principalTable: "TiposDocumentoIdentidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organizaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    TipoOrganizacionId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizaciones_TiposOrganizacion_TipoOrganizacionId",
                        column: x => x.TipoOrganizacionId,
                        principalTable: "TiposOrganizacion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Turistas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DatosPersonalesId = table.Column<int>(type: "integer", nullable: false),
                    OrigenId = table.Column<int>(type: "integer", nullable: false),
                    DestinoId = table.Column<int>(type: "integer", nullable: false),
                    LlegoEnGrupo = table.Column<bool>(type: "boolean", nullable: false),
                    CantidadPersonasGrupo = table.Column<int>(type: "integer", nullable: true),
                    FechaLlegada = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FechaSalida = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Presupuesto = table.Column<decimal>(type: "numeric", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turistas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turistas_DatosPersonales_DatosPersonalesId",
                        column: x => x.DatosPersonalesId,
                        principalTable: "DatosPersonales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Turistas_Ubicaciones_DestinoId",
                        column: x => x.DestinoId,
                        principalTable: "Ubicaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Turistas_Ubicaciones_OrigenId",
                        column: x => x.OrigenId,
                        principalTable: "Ubicaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreCompleto = table.Column<string>(type: "text", nullable: true),
                    Correo = table.Column<string>(type: "text", nullable: true),
                    EsActivo = table.Column<bool>(type: "boolean", nullable: false),
                    RolId = table.Column<int>(type: "integer", nullable: false),
                    DatosPersonalesId = table.Column<int>(type: "integer", nullable: false),
                    UltimoAcceso = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_DatosPersonales_DatosPersonalesId",
                        column: x => x.DatosPersonalesId,
                        principalTable: "DatosPersonales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles_RolId",
                        column: x => x.RolId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TuristasEquipamiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TuristaId = table.Column<int>(type: "integer", nullable: false),
                    Detalle = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuristasEquipamiento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TuristasEquipamiento_Turistas_TuristaId",
                        column: x => x.TuristaId,
                        principalTable: "Turistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TuristasMediosTransporteCiudad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TuristaId = table.Column<int>(type: "integer", nullable: false),
                    MedioTransporteId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuristasMediosTransporteCiudad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TuristasMediosTransporteCiudad_MediosTransporte_MedioTransp~",
                        column: x => x.MedioTransporteId,
                        principalTable: "MediosTransporte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TuristasMediosTransporteCiudad_Turistas_TuristaId",
                        column: x => x.TuristaId,
                        principalTable: "Turistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TuristasMediosTransporteLlegada",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TuristaId = table.Column<int>(type: "integer", nullable: false),
                    MedioTransporteId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuristasMediosTransporteLlegada", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TuristasMediosTransporteLlegada_MediosTransporte_MedioTrans~",
                        column: x => x.MedioTransporteId,
                        principalTable: "MediosTransporte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TuristasMediosTransporteLlegada_Turistas_TuristaId",
                        column: x => x.TuristaId,
                        principalTable: "Turistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DatosPersonales_GeneroId",
                table: "DatosPersonales",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_DatosPersonales_Identificacion",
                table: "DatosPersonales",
                column: "Identificacion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DatosPersonales_TipoDocumentoIdentidadId",
                table: "DatosPersonales",
                column: "TipoDocumentoIdentidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizaciones_TipoOrganizacionId",
                table: "Organizaciones",
                column: "TipoOrganizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Turistas_DatosPersonalesId",
                table: "Turistas",
                column: "DatosPersonalesId");

            migrationBuilder.CreateIndex(
                name: "IX_Turistas_DestinoId",
                table: "Turistas",
                column: "DestinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Turistas_OrigenId",
                table: "Turistas",
                column: "OrigenId");

            migrationBuilder.CreateIndex(
                name: "IX_TuristasEquipamiento_TuristaId",
                table: "TuristasEquipamiento",
                column: "TuristaId");

            migrationBuilder.CreateIndex(
                name: "IX_TuristasMediosTransporteCiudad_MedioTransporteId",
                table: "TuristasMediosTransporteCiudad",
                column: "MedioTransporteId");

            migrationBuilder.CreateIndex(
                name: "IX_TuristasMediosTransporteCiudad_TuristaId",
                table: "TuristasMediosTransporteCiudad",
                column: "TuristaId");

            migrationBuilder.CreateIndex(
                name: "IX_TuristasMediosTransporteLlegada_MedioTransporteId",
                table: "TuristasMediosTransporteLlegada",
                column: "MedioTransporteId");

            migrationBuilder.CreateIndex(
                name: "IX_TuristasMediosTransporteLlegada_TuristaId",
                table: "TuristasMediosTransporteLlegada",
                column: "TuristaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_DatosPersonalesId",
                table: "Usuarios",
                column: "DatosPersonalesId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RolId",
                table: "Usuarios",
                column: "RolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MotivosViaje");

            migrationBuilder.DropTable(
                name: "Organizaciones");

            migrationBuilder.DropTable(
                name: "TuristasEquipamiento");

            migrationBuilder.DropTable(
                name: "TuristasMediosTransporteCiudad");

            migrationBuilder.DropTable(
                name: "TuristasMediosTransporteLlegada");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "TiposOrganizacion");

            migrationBuilder.DropTable(
                name: "MediosTransporte");

            migrationBuilder.DropTable(
                name: "Turistas");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "DatosPersonales");

            migrationBuilder.DropTable(
                name: "Ubicaciones");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "TiposDocumentoIdentidad");
        }
    }
}
