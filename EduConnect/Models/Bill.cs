namespace EduConnect.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int CardNumber { get; set; }
        public double Discount { get; set; }
        public string Status { get; set; }

        public Bill() { }
    }
}
