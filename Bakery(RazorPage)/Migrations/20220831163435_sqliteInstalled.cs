using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakery_RazorPage_.Migrations
{
    public partial class sqliteInstalled : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "varchar(70)", nullable: false),
                    description = table.Column<string>(type: "varchar(70)", nullable: false),
                    price = table.Column<decimal>(type: "TEXT", nullable: false),
                    image_name = table.Column<string>(type: "varchar(70)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "description", "image_name", "name", "price" },
                values: new object[] { 1, "A scrumptious mini-carrot cake encrusted with sliced almonds", "carrot_cake.jpg", "Carrot Cake", 8.99m });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "description", "image_name", "name", "price" },
                values: new object[] { 2, "A delicious lemon tart with fresh meringue cooked to perfection", "lemon_tart.jpg", "Lemon Tart", 9.99m });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "description", "image_name", "name", "price" },
                values: new object[] { 3, "Delectable vanilla and chocolate cupcakes", "cupcakes.jpg", "Cupcakes", 5.99m });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "description", "image_name", "name", "price" },
                values: new object[] { 4, "Fresh baked French-style bread", "bread.jpg", "Bread", 1.49m });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "description", "image_name", "name", "price" },
                values: new object[] { 5, "A glazed pear tart topped with sliced almonds and a dash of cinnamon", "pear_tart.jpg", "Pear Tart", 5.99m });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "description", "image_name", "name", "price" },
                values: new object[] { 6, "Rich chocolate frosting cover this chocolate lover's dream", "chocolate_cake.jpg", "Chocolate Cake", 8.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "product");
        }
    }
}
