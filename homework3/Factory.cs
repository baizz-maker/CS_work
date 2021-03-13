using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Factory
    {
        public Shape packProcess(char choice)
        {
            Random random = new Random();

            int width_once = random.Next(21);
            int height_once = random.Next(21);
            switch (choice)
            {
                case '1':
                    Shape triangle = new Triangle(height_once, width_once );
                    return triangle;

                    break;
                case '2':
                    Shape rectangle = new Rectangle(width_once, height_once);
                    return rectangle;

                    break;
                case '3':
                    Shape square = new Square(width_once);
                    return square;
                    break;
            }
            Shape EmptyShape = new Rectangle(0,0);
            return EmptyShape;
        }
    }
}
