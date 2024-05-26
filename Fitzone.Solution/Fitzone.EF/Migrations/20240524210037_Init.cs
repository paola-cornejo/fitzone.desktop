using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitzone.EF.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Socio",
                columns: table => new
                {
                    idSocio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numeroDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    calle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    calleNumero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idBarrio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socio", x => x.idSocio);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Socio");
        }
    }
}
