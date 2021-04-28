using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace homework6
{
    public class OrderService
    {
        private List<Order> orders;
        public List<Order> Orders { set; get; } = new List<Order>();

        public void addOrder(Order order)
        {
            if (Orders.Contains(order))
                throw new Exception1("订单已存在");
            
            else
                Orders.Add(order);
            orders = Orders;
        }

        public void deleteOrder(string orderid)
        {

            var currentOrder = Orders.Where(o => o.OrderID.ToString() == orderid).FirstOrDefault();
            if (currentOrder == null)
                throw new InvalidOperationException("要删除的订单不存在");

            Orders.Remove(currentOrder);

        }

        public string searchOrder(string orderid)
        {
            var target = Orders.Where(order => order.OrderID.ToString() == orderid).FirstOrDefault();
            if (target == null)
                throw new InvalidOperationException("要查询的订单不存在");
            else
                return target.ToString();

        }

        public bool Export(string filename)
        {
            
            
                for (int i = 0; i < Orders.Count; i++)
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                    using (FileStream file = new FileStream(filename, FileMode.Create))
                    {
                        xmlSerializer.Serialize(file, Orders);

                    }
                }
            Console.WriteLine(File.ReadAllText(filename));
            return true;
        }
        public List<Order> Import(string filename)
        {
                            
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                using(FileStream file = new FileStream(filename, FileMode.Open))
                {
                    List<Order> list = (List<Order>)xmlSerializer.Deserialize(file);
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i]);
                    }
                return list;
            }
            
            
        }
    }
}
        

    class Exception1 : Exception
    {
        public Exception1(string message) : base(message) { }

    };
    class Exception2 : Exception
    {
        public Exception2(string message) : base(message) { }

    };

