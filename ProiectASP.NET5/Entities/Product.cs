namespace ProiectASP.NET5.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}
