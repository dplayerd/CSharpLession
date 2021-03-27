using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsoleApp1
{
    public class PaymentRecord
    {
        public DateTime PayDay { get; set; }
        public List<PaymentItem> Items { get; set; }
    }
}