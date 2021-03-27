using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicWebForm
{
    public class PaymentListMain
    {
        public void Main()
        {
            List<PaymentRecord> records = new List<PaymentRecord>();

            var record1 =
                new PaymentRecord()
                {
                    PayDay = new DateTime(2021, 1, 1),
                    Items = new List<PaymentItem>()
                    {
                        new PaymentItem()
                        {
                            Name = "水費",
                            Price = 200,
                            PType = PaymentType.House
                        }
                    }
                };
            records.Add(record1);

            var record2 =
                new PaymentRecord()
                {
                    PayDay = new DateTime(2021, 1, 2),
                    Items = new List<PaymentItem>()
                    {
                        new PaymentItem()
                        {
                            Name = "丹丹漢堡",
                            Price = 119,
                            PType = PaymentType.Food
                        },
                        new PaymentItem()
                        {
                            Name = "正忠排骨",
                            Price = 89,
                            PType = PaymentType.Food
                        },
                        new PaymentItem()
                        {
                            Name = "50 嵐珍奶",
                            Price = 55,
                            PType = PaymentType.Food
                        },
                        new PaymentItem()
                        {
                            Name = "電費",
                            Price = 899,
                            PType = PaymentType.House
                        },
                    }
                };
            records.Add(record2);


            foreach (var rec in records)
            {
                foreach (var item in rec.Items)
                {
                    if (item.PType == PaymentType.Food &&
                        item.Price > 100)
                        Console.WriteLine($"食物費超額：{item.Name} ({rec.PayDay})");

                    if (item.PType == PaymentType.House &&
                        item.Price > 800)
                        Console.WriteLine($"房屋費用超額：{item.Name} ({rec.PayDay})");
                }
            }
        }
    }
}