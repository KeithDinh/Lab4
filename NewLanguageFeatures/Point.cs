using System;
using System.Collections.Generic;
using System.Text;

namespace NewLanguageFeatures
{
    public class Point
    {
        List<Point> Square = new List<Point>
        {
            new Point { X=0, Y=5 },
            new Point { X=5, Y=5 },
            new Point { X=5, Y=0 },
            new Point { X=0, Y=0 }
        };
        public int X { get; set; }
        public int Y { get; set; }
    }
}
