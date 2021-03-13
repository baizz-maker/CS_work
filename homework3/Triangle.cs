using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Triangle: Shape
    {
        private int height;
        private int width;

        public Triangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }
        public override int Area { get { return height * width / 2; } }

        public  override bool inspectShape()
        {
            if (width > 0 && height > 0)
                return true;
            return false;
        }
    }
}
