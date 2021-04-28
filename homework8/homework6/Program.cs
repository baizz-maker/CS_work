using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("1", "10", "toy");
            Product p2 = new Product("2", "20", "cooker");
            Product p3 = new Product("3", "30", "e-card");
            Order order1 = new Order();
            Order order2 = new Order();
            order1.addProduct(p1);
            order1.addProduct(p3);
            order2.addProduct(p2);
            
          
                
                OrderService service = new OrderService();
                service.addOrder(order1);
                service.addOrder(order2);
                service.deleteOrder(order2.OrderID.ToString());

                //service.Export("test.xml");
                //service.Import("test.xml");
                //Console.WriteLine(order2.ToString());
               Console.WriteLine(service.searchOrder(order2.OrderID.ToString()));
                
            
            /*catch(Exception1 e)
            {   

                Console.WriteLine(e.Message);
            }
            catch (Exception2 e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/

            Console.ReadKey();


        }
    }
}
