using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DrinksMarket.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet <Order> Orders { get; set; }
        public DbSet <OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Cofee Drinks" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Tea Drinks" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Homemade Lemonades" });

            //seed drinks

            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                DrinkId = 1,
                Name = "Espresso",
                Price = 2.5M,
                ShortDescription = "Locally-roasted organic blend",
                LongDescription =
                    "We can serve it with one or two shots of espresso. You can drink it here at our comfortable place or take it to go!",
                CategoryId = 1,
                ImageUrl = "https://i.postimg.cc/RFMt8S0D/espresso.png",
                IsDrinkOfTheWeek = true,
            });
            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                DrinkId = 2,
                Name = "Black Tea",
                Price = 25M,
                ShortDescription = "Stronger in flavor with less caffeine than coffee.",
                LongDescription =
                "We can serve it with one or two shots of espresso. You can drink it here at our comfortable place or take it to go!",
                CategoryId = 2,
                ImageUrl = "https://i.postimg.cc/BnrchfDr/black-tea.jpg",
                IsDrinkOfTheWeek = false,
            });
            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                DrinkId = 3,
                Name = "Cappuccino",
                Price = 4.5M,
                ShortDescription = "Barista's favorite drink!",
                LongDescription =
                "Dark, rich espresso lies in wait under a smoothed and stretched layer of thick milk foam. An alchemy of barista artistry and craft.",
                CategoryId = 1,
                ImageUrl = "https://i.postimg.cc/LXRkpkxv/cappuccino.jpg",
                IsDrinkOfTheWeek = true,
            });
            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                DrinkId = 4,
                Name = "Coffee with Milk",
                Price = 3M,
                ShortDescription = "Locally-roasted organic blend with a splash of milk.",
                LongDescription =
                "Espresso meets a dollop of whipped cream to enhance the rich and caramelly flavors of a straight-up shot.",
                CategoryId = 1,
                ImageUrl = "https://i.postimg.cc/d1B2t7XF/coffee-milk.jpg",
                IsDrinkOfTheWeek = false,
            });
            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                DrinkId = 5,
                Name = "Cold Brew",
                Price = 5.5M,
                ShortDescription = "Smooth and deliciously drinkable!",
                LongDescription =
                "Handcrafted in small batches daily, slow-steeped in cool water for 20 hours, without touching heat Cold Brew is made from our custom blend of beans grown to steep long and cold for a super-smooth flavor.",
                CategoryId = 1,
                ImageUrl = "https://i.postimg.cc/05VYTwDd/cold-brew.jpg",
                IsDrinkOfTheWeek = false,
            });
            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                DrinkId = 6,
                Name = "Iced Matcha",
                Price = 6M,
                ShortDescription = "Unique and tasty drink.",
                LongDescription =
                "Smooth and creamy matcha sweetened just right and served with milk over ice. Green has never tasted so good.",
                CategoryId = 1,
                ImageUrl = "https://i.postimg.cc/vT25fJbS/cold-matcha.jpg",
                IsDrinkOfTheWeek = true,
            });

            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                DrinkId = 7,
                Name = "Fruit Tea",
                Price = 3.5M,
                ShortDescription = "We offer many kinds and flavours.",
                LongDescription =
             "This boldly flavored tea is made with a combination of our flavored fruit juices blend and the best fruit tea blends.",
                CategoryId = 2,
                ImageUrl = "https://i.postimg.cc/13hbq2Xz/fruit-tea.jpg",
                IsDrinkOfTheWeek = false,
            });
            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                DrinkId = 8,
                Name = "Iced Coffee",
                Price = 3.55M,
                ShortDescription = "Cold version of regular coffee.",
                LongDescription =
                "Freshly brewed Local Iced Coffee Blend with milk served chilled and sweetened over ice. An absolutely, seriously, refreshingly lift to any day.",
                CategoryId = 1,
                ImageUrl = "https://i.postimg.cc/WbKM3c9d/iced-coffee.jpg",
                IsDrinkOfTheWeek = true,
            });
            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                DrinkId = 9,
                Name = "Iced Green Tea",
                Price = 4M,
                ShortDescription = "Refreshing and revitalizing bevarage.",
                LongDescription =
             "Premium green tea is shaken with ice. It's the ideal iced tea—a rich and flavorful green tea journey awaits you.",
                CategoryId = 2,
                ImageUrl = "https://i.postimg.cc/1zyTWFph/iced-green-tea.jpg",
                IsDrinkOfTheWeek = true,
            });
            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                DrinkId = 10,
                Name = "Iced Tea",
                Price = 3.5M,
                ShortDescription = "Refreshing caffeine-free drink idea.",
                LongDescription =
                "A blend of hibiscus, lemongrass and apple, handshaken with ice. A refreshingly vibrant tea infused with the color of passion.",
                CategoryId = 2,
                ImageUrl = "https://i.postimg.cc/R0xK7Qx9/iced-tea.jpg",
                IsDrinkOfTheWeek = false,
            });
            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                DrinkId = 11,
                Name = "Latte",
                Price = 4.5M,
                ShortDescription = "One-third espresso, two-thirds heated milk and a little foam.",
                LongDescription =
                   "Our dark, rich espresso balanced with steamed milk and a light layer of foam. A perfect milk-forward warm-up.",
                CategoryId = 1,
                ImageUrl = "https://i.postimg.cc/0yw7KX3c/latte.jpg",
                IsDrinkOfTheWeek = false,
            });
            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                DrinkId = 12,
                Name = "Lavender Lemonade",
                Price = 5M,
                ShortDescription = "The most refreshing lavender lemonade for summer!",
                LongDescription =
                "This lemonade perfumes floral flavors that are sweet, yet refreshingly succulent. It is perfect for summer parties, brunch or an afternoon at the park.",
                CategoryId = 3,
                ImageUrl = "https://i.postimg.cc/bwxWHgS9/lavender.jpg",
                IsDrinkOfTheWeek = false,
            });
            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                DrinkId = 13,
                Name = "Old-Fashioned Lemonade",
                Price = 3.5M,
                ShortDescription = "Sweet and simple classic lemonade.",
                LongDescription =
                     "Lightly flavored and oh-so-refreshing! Our classic lemonade recipe is the best! And trust us when we say that this is one of our best-sellers! ",
                CategoryId = 3,
                ImageUrl = "https://i.postimg.cc/MGtLgGDc/lemonade.jpg",
                IsDrinkOfTheWeek = true,
            });
            modelBuilder.Entity<Drink>().HasData(new Drink
            {
                DrinkId = 14,
                Name = "Raspberry Lemonade",
                Price = 4.5M,
                ShortDescription = "Taste tart raspberry sweetness coupled with minty coolness.",
                LongDescription =
                "Ask for a refreshing glass of Raspberry Lemonade and you won't regret it! It's both sweet and tangy and sure to be delicious.",
                CategoryId = 3,
                ImageUrl = "https://i.postimg.cc/ZRRQmh7w/raspberry1.jpg",
                IsDrinkOfTheWeek = true,
            });

        }
    }
}
