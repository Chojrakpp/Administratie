using Administratie.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administratie
{
    internal class MyDbContext: DbContext
    {
        DbSet<Product> Producten { get; set; }

        DbSet<ProductCategorie> ProductenCategorien { get; set; }

        public void InitiateDatabase()
        {
            ProductCategorie voedsel = new ProductCategorie { Naam = "voedsel" };
            ProductenCategorien.Add(voedsel);
            Product product = new Product() { Naam = "vlees", Categorie = voedsel, Omschrijving = "omschrijving van mijn product"};
            Producten.Add(product);
            SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-RS1U0QK\SQLEXPRESS;Database=AdministratieDB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true;");
        }
    }
}
