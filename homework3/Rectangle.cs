using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    public class Rectangle: Shape
    {   
         
       

        private int width;
        private int height;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
            
        }
       

        public override int Area
        {   
            get { return width * height; }

        }

        

        public override bool inspectShape()
        {
            if (this.height > 0 && this.width > 0)
                return true;
            return false;
        }
    }
}
