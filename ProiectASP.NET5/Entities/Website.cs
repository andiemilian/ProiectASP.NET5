namespace ProiectASP.NET5.Entities
{
    public class Website
    {
        public int Url { get; set; }
        public int ShopID { get; set; }
        public Shop Shop { get; set; }

    }
}
