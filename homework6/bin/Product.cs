using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class Product
    {
        private string ID;
        private string price;
        private string description;
        public string PID { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }

        public Product(string id, string price, string description)
        {   
            ID = id;
            this.price = price;
            this.description = description;

            PID = id;
            Price = price;
            Description = description;

        }

        public override string ToString ()
        {
            return     "ID: "+ PID+" Price: " + Price + " Description: " + Description;
        }
    }
}
