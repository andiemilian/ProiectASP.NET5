using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectASP.NET5.Entities.DTOs
{
    public class ClientDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int varsta { get; set; }
        public int ShopId { get; set; }
        public ICollection<ShopClient> ShopClient { get; set; }

        public ClientDTO(Client client)
        {
            this.Id=client.Id;
            this.Name=client.Name;
            this.varsta=client.varsta;
            this.ShopId=client.ShopId;
        }
    }
}