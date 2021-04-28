using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    public class ProductDetail
    {

        private string price;
        private string description;

        public string ProductPrice { get; set; }
        public string ProductDescription { get; set; }

        public ProductDetail(string price, string descript)
        {
            this.ProductPrice = price;
            this.ProductDescription = descript;


            this.price = price;
            this.description = descript;

        }

        public ProductDetail()
        {
            this.ProductPrice = "0";
            this.ProductDescription = "0";


            this.price = "0";
            this.description = "0";
        }
        

        public override bool Equals(object obj)
        {
            ProductDetail d = obj as ProductDetail;

            return ProductPrice == d.ProductPrice && ProductDescription == d.ProductDescription;
        }

        public override int GetHashCode()
        {
            return description.GetHashCode();
        }

        public override string ToString()
        {
            return " Price: " + ProductPrice + " Description: " + ProductDescription;
        }
    }
}
