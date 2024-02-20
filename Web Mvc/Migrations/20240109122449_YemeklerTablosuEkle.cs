using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebUygulamaProje1.Migrations
{
	/// <inheritdoc />
	public partial class YemeklerTablosuEkle : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Yemekler",
				columns: table => new
				{
					Id = table.Column<int>(type: "int ", nullable: false)
					.Annotation("SqlServer:Identity", "1,1"),
					YemekAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Fiyat = table.Column<double>(type: "float", nullable: false),
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Yemekler", x => x.Id);
				}


				);

		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{

			migrationBuilder.DropTable(

				name: "Yemekler");


		}
	}
}
