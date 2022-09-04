using System.Collections.Generic;

namespace ProiectASP.NET5.Entities
{
    public class ShopClient
    {
        public int ShopClientId { get; set; }
        public int ShopId { get; set; }
        public int ClientId { get; set; }

        public virtual Shop Shop { get; set; }
        public virtual Client Client { get; set; }
    }
}
