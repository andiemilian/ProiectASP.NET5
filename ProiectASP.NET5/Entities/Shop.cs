using System.Collections.Generic;

namespace ProiectASP.NET5.Entities
{
    public class Shop
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public int ProductId { get; set; }
        public int ShopClientId { get; set; }
        public int WebsiteUrl { get; set; }

        public ICollection<Product> Products { get; set; }

        public Website Website { get; set; }

        public ICollection<ShopClient> ShopClient { get; set; }
    }
}
