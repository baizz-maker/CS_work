using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class Order
    {
        private string orderID;

        private float total;

        private List<ProductDetail> details;

        public List<ProductDetail> detail_list { get; set; } = new List<ProductDetail>();  //储存订单中各产品的信息
        public StringBuilder OrderID { get; set; } = new StringBuilder();

        public float TotalAmount { get; set; } 
        public  void addProduct(Product p)  //向订单中添加产品详情
        {
            ProductDetail detail_current = new ProductDetail(p.Price, p.Description);
            detail_list.Add(detail_current);

            TotalAmount += float.Parse(p.Price);
            OrderID.Append(p.PID).Append(DateTime.Now.Hour).Append(DateTime.Now.Minute).Append(DateTime.Now.Second); //生成订单id
            orderID = OrderID.ToString();
            total = TotalAmount;
        }

        public override bool Equals(object obj)
        {
            Order t = obj as Order;

            return t.OrderID == OrderID;
        }

        public override int GetHashCode()
        {
            return OrderID.GetHashCode();
        }

        public override string ToString()
        {
            return "ID: "+ OrderID.ToString() + " Total: " + TotalAmount ;
        }
    }
}
