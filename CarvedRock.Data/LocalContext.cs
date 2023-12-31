﻿using CarvedRock.Data.Entities;
using Microsoft.EntityFrameworkCore;
namespace CarvedRock.Data;
public class LocalContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();

    public LocalContext(DbContextOptions<LocalContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(GetProducts());
        base.OnModelCreating(modelBuilder);
    }

    private IEnumerable<Product> GetProducts()
    {

        return new List<Product>(){
        new Product
            {
                Id = 1,
                Name = "Trailblazer",
                Category = "boots",
                Price = 69.99,
                Description = "Great support in this high-top to take you to great heights and trails.",
                ImgUrl = "https://www.pluralsight.com/content/dam/pluralsight2/teach/author-tools/carved-rock-fitness/img-brownboots.jpg"
            },
            new Product {
                Id = 2,
                Name = "Coastliner",
                Category = "boots",
                Price = 49.99,
                Description =
                    "Easy in and out with this lightweight but rugged shoe with great ventilation to get your around shores, beaches, and boats.",
                ImgUrl = "https://www.pluralsight.com/content/dam/pluralsight2/teach/author-tools/carved-rock-fitness/img-greyboots.jpg"
            },
            new Product
            {
                Id = 3,
                Name = "Woodsman",
                Category = "boots",
                Price = 64.99,
                Description =
                    "All the insulation and support you need when wandering the rugged trails of the woods and backcountry.",
                ImgUrl = "/images/shutterstock_222721876.jpg"
            },
            new Product
            {
                Id = 4,
                Name = "Billy",
                Category = "boots",
                Price = 79.99,
                Description =
                    "Get up and down rocky terrain like a billy-goat with these awesome high-top boots with outstanding support.",
                ImgUrl = "/images/shutterstock_475046062.jpg"
            }};
    }
}
