using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_Zholudov_n1
{
    class Rectangle
    {
        private int _xPos;
        private int _yPos;
        private double _height;
        private double _weight;
        private static int _angle = 90;
        private static string _className = "Rectangle";

        public Rectangle(int x1, int y1, int x2, int y2)
        {
            _xPos = x1;
            _xPos = y1;
            _height = y2 - y1;
            _weight = x2 - x1;
        }
        public double GetHeight()
        {
            return _height;
        }
        public double GetWeight()
        {
            return _weight;
        }
        public double GetPerimeter()
        {
            double perimeter = (_height + _weight) * 2;
            return perimeter;
        }

        public void SetRectanglePosition(int xPos, int yPos)
        {
            _xPos = xPos;
            _yPos = yPos;
        }
        public static string GetClassName()
        {
            return _className;
        }
    }
}
