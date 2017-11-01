using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using NUnit.Framework;
using test.Models.Data;

namespace test
{
    public class Class1
    {
        [SetUp]
        public void test()
        {
            var poTransaction = new PoTransaction
            {
                sender_id = 12,
                po_info = new PoInfo
                {
                    sidemark = "test",
                    notes = "test",
                    st_address1 = "test",
                    st_city = "test",
                    st_name = "test",
                    st_phone = "test",
                    st_state = "test",
                    st_zip = "test",
                    unit_type = 1,
                    po = 1,
                    line_items = new List<LineItem>
                    {
                        new LineItem
                        {
                            color = "test",
                            control_type = "test",
                            hand_sample = "test",
                            height = 20,
                            width = 20,
                            model = "test",
                            mount = "test",
                            quantity = 20,
                            sidemark = "test",
                            sku = "test",
                            special_instructions = "test"
                        }
                    }
                }
            };

            using (var context = new Context())
            {
                context.PoTransactions.Add(poTransaction);
                context.SaveChanges();
            }
        }

        [Test]
        public void load()
        {
            using (var context = new Context())
            {
                var test = context.PoTransactions.Find();
                var poObject = context.PoTransactions.ToList();

                Assert.That(poObject[0].po_info.line_items.Count, Is.EqualTo(1));
                context.Dispose();
            }
        }
    }
}
