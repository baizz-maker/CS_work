using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace homework6
{
    class OrderService
    {
        private List<Order> orders;
        public List<Order> Orders { set; get; } = new List<Order>();

        public void addOrder(Order order)
        {
            if (Orders.Contains(order))
                throw new Exception1("订单已存在");
            else
                Orders.Add(order);
        }

        public void deleteOrder(string orderid)
        {

            var target = Orders.Where(order => order.OrderID.ToString() == orderid);
            List<Order> list = target.ToList<Order>();
            if (list.Count() == 0)
                throw new Exception2("订单页为空或未能查询到指定订单");
            else
                Orders = (List<Order>)Orders.Except(list);
        }

        public string searchOrder(string orderid)
        {
            var target = Orders.Where(order => order.OrderID.ToString() == orderid);


            return target.FirstOrDefault().ToString();

        }

        public bool Export()
        {
            try
            {
                for (int i = 0; i < Orders.Count; i++)
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                    using (FileStream file = new FileStream("test.xml", FileMode.Create))
                    {
                        xmlSerializer.Serialize(file, Orders);

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            Console.WriteLine(File.ReadAllText("test.xml"));
            return true;
        }
        public bool Import()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                using(FileStream file = new FileStream("test.xml", FileMode.Open))
                {
                    List<Order> list = (List<Order>)xmlSerializer.Deserialize(file);
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
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

