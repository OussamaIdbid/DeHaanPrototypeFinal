using System;
using System.Collections.Generic;
using System.Linq;

namespace CashModel
{
    public class Receipt
    {
        public  DateTime CreateDateTime { get; set; }
        public List<ReceiptLine> Lines { get; set; } = new List<ReceiptLine>();
        public decimal TotalPrice {
            get {
                return Lines.Sum(q => q.TotalPrice);
            }
        }
    }
}
    