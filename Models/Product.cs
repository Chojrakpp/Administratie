using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administratie.Models
{
    internal class Product
    {
        public int Id { get; set; }

        public string Naam { get; set; }

        public string Omschrijving { get; set; }

        [ForeignKey("ProductCategorien")]
        public int CategorieId { get; set; }

        public ProductCategorie Categorie { get; set; }
    }
}
