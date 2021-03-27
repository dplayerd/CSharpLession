using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
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


            Console.WriteLine("全部項目如下：");

            foreach (var rec in records)
            {
                foreach (var item in rec.Items)
                { 
                    Console.WriteLine($"Name：{item.Name} Day:{rec.PayDay}, Price: {item.Price}");
                }
            }

            Console.WriteLine("\n\n超額項目如下：");
            decimal totalOutPay = 0;
            foreach (var rec in records)
            {
                foreach (var item in rec.Items)
                {
                    if (item.PType == PaymentType.Food &&
                        item.Price > 100)
                    {
                        Console.WriteLine($"食物費超額：{item.Name} ({rec.PayDay})");
                        totalOutPay += item.Price;
                    }

                    if (item.PType == PaymentType.House &&
                        item.Price > 800)
                    {
                        Console.WriteLine($"房屋費用超額：{item.Name} ({rec.PayDay})");
                        totalOutPay += item.Price;
                    }
                }
            }

            Console.WriteLine($"\n\n 共超額{totalOutPay}");

            Console.WriteLine($"\n\n按下 ENter 後結束");
            Console.ReadLine();


            var obj1 =
            new PaymentItem()
            {
                Price = 899,
            };

            var obj2 =
            new PaymentItem()
            {
                Price = 899,
            };

            if (obj1 == obj2)
            { 
            }

            Dictionary<PaymentItem, int> dic = new Dictionary<PaymentItem, int>();
            dic.Add(obj1, 1);

            if (dic.ContainsKey(obj2))
            {
            }
        }
    }
}
