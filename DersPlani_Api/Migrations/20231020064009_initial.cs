using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DersPlani_Api.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ogretmenler",
                columns: table => new
                {
                    OgretmenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgretmenAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgretmenSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogretmenler", x => x.OgretmenId);
                });

            migrationBuilder.CreateTable(
                name: "Sınıflar",
                columns: table => new
                {
                    SınıfId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SınıfAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sınıflar", x => x.SınıfId);
                });

            migrationBuilder.CreateTable(
                name: "Dersler",
                columns: table => new
                {
                    DersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgretmenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.DersId);
                    table.ForeignKey(
                        name: "FK_Dersler_Ogretmenler_OgretmenId",
                        column: x => x.OgretmenId,
                        principalTable: "Ogretmenler",
                        principalColumn: "OgretmenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DersSınıf",
                columns: table => new
                {
                    DerslerDersId = table.Column<int>(type: "int", nullable: false),
                    SınıflarSınıfId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersSınıf", x => new { x.DerslerDersId, x.SınıflarSınıfId });
                    table.ForeignKey(
                        name: "FK_DersSınıf_Dersler_DerslerDersId",
                        column: x => x.DerslerDersId,
                        principalTable: "Dersler",
                        principalColumn: "DersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DersSınıf_Sınıflar_SınıflarSınıfId",
                        column: x => x.SınıflarSınıfId,
                        principalTable: "Sınıflar",
                        principalColumn: "SınıfId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Saatler",
                columns: table => new
                {
                    SaatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersSaati = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: false),
                    SınıfId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saatler", x => x.SaatId);
                    table.ForeignKey(
                        name: "FK_Saatler_Dersler_DersId",
                        column: x => x.DersId,
                        principalTable: "Dersler",
                        principalColumn: "DersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Saatler_Sınıflar_SınıfId",
                        column: x => x.SınıfId,
                        principalTable: "Sınıflar",
                        principalColumn: "SınıfId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_OgretmenId",
                table: "Dersler",
                column: "OgretmenId");

            migrationBuilder.CreateIndex(
                name: "IX_DersSınıf_SınıflarSınıfId",
                table: "DersSınıf",
                column: "SınıflarSınıfId");

            migrationBuilder.CreateIndex(
                name: "IX_Saatler_DersId",
                table: "Saatler",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_Saatler_SınıfId",
                table: "Saatler",
                column: "SınıfId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DersSınıf");

            migrationBuilder.DropTable(
                name: "Saatler");

            migrationBuilder.DropTable(
                name: "Dersler");

            migrationBuilder.DropTable(
                name: "Sınıflar");

            migrationBuilder.DropTable(
                name: "Ogretmenler");
        }
    }
}
