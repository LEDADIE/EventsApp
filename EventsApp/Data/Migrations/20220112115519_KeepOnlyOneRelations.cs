using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsApp.Data.Migrations
{
    public partial class KeepOnlyOneRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participants_Evenements_EvenementId",
                table: "Participants");

            migrationBuilder.DropTable(
                name: "CategorieEvenement");

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_Evenements_EvenementId",
                table: "Participants",
                column: "EvenementId",
                principalTable: "Evenements",
                principalColumn: "EvenementId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participants_Evenements_EvenementId",
                table: "Participants");

            migrationBuilder.CreateTable(
                name: "CategorieEvenement",
                columns: table => new
                {
                    CategoriesCategorieId = table.Column<int>(type: "int", nullable: false),
                    EvenementsEvenementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieEvenement", x => new { x.CategoriesCategorieId, x.EvenementsEvenementId });
                    table.ForeignKey(
                        name: "FK_CategorieEvenement_Categories_CategoriesCategorieId",
                        column: x => x.CategoriesCategorieId,
                        principalTable: "Categories",
                        principalColumn: "CategorieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategorieEvenement_Evenements_EvenementsEvenementId",
                        column: x => x.EvenementsEvenementId,
                        principalTable: "Evenements",
                        principalColumn: "EvenementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategorieEvenement_EvenementsEvenementId",
                table: "CategorieEvenement",
                column: "EvenementsEvenementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_Evenements_EvenementId",
                table: "Participants",
                column: "EvenementId",
                principalTable: "Evenements",
                principalColumn: "EvenementId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
