namespace CashModel
{
    public class ReceiptLine
    {
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice
        {
            get
            {return Quantity * Price;}
        }
    }
}
