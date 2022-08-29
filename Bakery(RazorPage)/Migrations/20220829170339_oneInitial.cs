using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakery_RazorPage_.Migrations
{
    public partial class oneInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageName", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "A scrumptious mini-carrot cake encrusted with sliced almonds", "carrot_cake.jpg", "Carrot Cake", 8.99m },
                    { 2, "A delicious lemon tart with fresh meringue cooked to perfection", "lemon_tart.jpg", "Lemon Tart", 9.99m },
                    { 3, "Delectable vanilla and chocolate cupcakes", "cupcakes.jpg", "Cupcakes", 5.99m },
                    { 4, "Fresh baked French-style bread", "bread.jpg", "Bread", 1.49m },
                    { 5, "A glazed pear tart topped with sliced almonds and a dash of cinnamon", "pear_tart.jpg", "Pear Tart", 5.99m },
                    { 6, "Rich chocolate frosting cover this chocolate lover's dream", "chocolate_cake.jpg", "Chocolate Cake", 8.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
