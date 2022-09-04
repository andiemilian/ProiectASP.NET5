using System.Collections.Generic;

namespace ProiectASP.NET5.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int varsta { get; set; }
        public int ShopId { get; set; }
        public ICollection<ShopClient> ShopClient { get; set; }




    }
}
