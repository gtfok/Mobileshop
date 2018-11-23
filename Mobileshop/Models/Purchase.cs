using System;


namespace Mobileshop.Models
{
    public class Purchase
    {
            public int PurchaseId { get; set; }
            public int PhoneID { get; set; }
            public string Owner { get; set; }
            public string Address { get; set; }
            public DateTime Date { get; set; }
    }
}