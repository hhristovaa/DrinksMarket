using Microsoft.EntityFrameworkCore.Migrations;

namespace DrinksMarket.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    DrinkId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    IsDrinkOfTheWeek = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.DrinkId);
                    table.ForeignKey(
                        name: "FK_Drinks_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Cofee Drinks", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Tea Drinks", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Homemade Lemonades", null });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "DrinkId", "CategoryId", "ImageUrl", "IsDrinkOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://i.postimg.cc/RFMt8S0D/espresso.png", true, "We can serve it with one or two shots of espresso. You can drink it here at our comfortable place or take it to go!", "Espresso", 2.5m, "Locally-roasted organic blend" },
                    { 3, 1, "https://i.postimg.cc/LXRkpkxv/cappuccino.jpg", true, "Dark, rich espresso lies in wait under a smoothed and stretched layer of thick milk foam. An alchemy of barista artistry and craft.", "Cappuccino", 4.5m, "Barista's favorite drink!" },
                    { 4, 1, "https://i.postimg.cc/d1B2t7XF/coffee-milk.jpg", false, "Espresso meets a dollop of whipped cream to enhance the rich and caramelly flavors of a straight-up shot.", "Coffee with Milk", 3m, "Locally-roasted organic blend with a splash of milk." },
                    { 5, 1, "https://i.postimg.cc/05VYTwDd/cold-brew.jpg", false, "Handcrafted in small batches daily, slow-steeped in cool water for 20 hours, without touching heat Cold Brew is made from our custom blend of beans grown to steep long and cold for a super-smooth flavor.", "Cold Brew", 5.5m, "Smooth and deliciously drinkable!" },
                    { 6, 1, "https://i.postimg.cc/vT25fJbS/cold-matcha.jpg", true, "Smooth and creamy matcha sweetened just right and served with milk over ice. Green has never tasted so good.", "Iced Matcha", 6m, "Unique and tasty drink." },
                    { 8, 1, "https://i.postimg.cc/WbKM3c9d/iced-coffee.jpg", true, "Freshly brewed Local Iced Coffee Blend with milk served chilled and sweetened over ice. An absolutely, seriously, refreshingly lift to any day.", "Iced Coffee", 3.55m, "Cold version of regular coffee." },
                    { 11, 1, "https://i.postimg.cc/0yw7KX3c/latte.jpg", false, "Our dark, rich espresso balanced with steamed milk and a light layer of foam. A perfect milk-forward warm-up.", "Latte", 4.5m, "One-third espresso, two-thirds heated milk and a little foam." },
                    { 2, 2, "https://i.postimg.cc/BnrchfDr/black-tea.jpg", false, "We can serve it with one or two shots of espresso. You can drink it here at our comfortable place or take it to go!", "Black Tea", 25m, "Stronger in flavor with less caffeine than coffee." },
                    { 7, 2, "https://i.postimg.cc/13hbq2Xz/fruit-tea.jpg", false, "This boldly flavored tea is made with a combination of our flavored fruit juices blend and the best fruit tea blends.", "Fruit Tea", 3.5m, "We offer many kinds and flavours." },
                    { 9, 2, "https://i.postimg.cc/1zyTWFph/iced-green-tea.jpg", true, "Premium green tea is shaken with ice. It's the ideal iced tea—a rich and flavorful green tea journey awaits you.", "Iced Green Tea", 4m, "Refreshing and revitalizing bevarage." },
                    { 10, 2, "https://i.postimg.cc/R0xK7Qx9/iced-tea.jpg", false, "A blend of hibiscus, lemongrass and apple, handshaken with ice. A refreshingly vibrant tea infused with the color of passion.", "Iced Tea", 3.5m, "Refreshing caffeine-free drink idea." },
                    { 12, 3, "https://i.postimg.cc/bwxWHgS9/lavender.jpg", false, "This lemonade perfumes floral flavors that are sweet, yet refreshingly succulent. It is perfect for summer parties, brunch or an afternoon at the park.", "Lavender Lemonade", 5m, "The most refreshing lavender lemonade for summer!" },
                    { 13, 3, "https://i.postimg.cc/MGtLgGDc/lemonade.jpg", true, "Lightly flavored and oh-so-refreshing! Our classic lemonade recipe is the best! And trust us when we say that this is one of our best-sellers! ", "Old-Fashioned Lemonade", 3.5m, "Sweet and simple classic lemonade." },
                    { 14, 3, "https://i.postimg.cc/ZRRQmh7w/raspberry1.jpg", true, "Ask for a refreshing glass of Raspberry Lemonade and you won't regret it! It's both sweet and tangy and sure to be delicious.", "Raspberry Lemonade", 4.5m, "Taste tart raspberry sweetness coupled with minty coolness." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_CategoryId",
                table: "Drinks",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
