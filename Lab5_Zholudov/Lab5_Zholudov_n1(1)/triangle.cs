using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_Zholudov_n1_1_ //VARIANT 4
{
    class Triangle
    {
        private int _xPos1;
        private int _xPos2;
        private int _xPos3;
        private int _yPos1;
        private int _yPos2;
        private int _yPos3;
        private double _length1;
        private double _length2;
        private double _length3;
        private double _angle1;
        private double _angle2;
        private double _angle3;
        private static string _className = "Triangle";

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            _length1 = Math.Sqrt( Math.Pow(Math.Abs(y2 - y1), 2) + Math.Pow(Math.Abs(x2 - x1), 2));
            _length2 = Math.Sqrt( Math.Pow(Math.Abs(y3 - y2), 2) + Math.Pow(Math.Abs(x3 - x2), 2));
            _length3 = Math.Sqrt( Math.Pow(Math.Abs(y1 - y3), 2) + Math.Pow(Math.Abs(x1 - x3), 2));
        }

        public double GetLength(int n)
        {
            if (n == 1) return _length1;
            else if (n == 2) return _length2;
            else if (n == 3) return _length3;
            else return 0;
        }

        public double GetPerimeter()
        {
            return _length1 + _length2 + _length3;
        }

        public void ChangePositions(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            _xPos1 = x1;
            _xPos2 = x2;
            _xPos3 = x3;
            _yPos1 = y1;
            _yPos2 = y2;
            _yPos3 = y3;
        }

        public (int x1, int y1, int x2, int y2, int x3, int y3) GetPositions()
        {
            return (_xPos1, _yPos1, _xPos2, _yPos2, _xPos3, _yPos3);
        }

        public void SetClassName(string name)
        {
            _className = name;
        }

        /*public double GetAngle(int n)
        {
            if (n == 1)
            {
                _angle1 = Math.Acos((Math.Pow(_length1,2)+Math.Pow(_length2,2)-Math.Pow(_length3,2))/2*_length1*_length2);
                return _angle1;
            }
            else if (n == 2)
            {
                _angle2 = Math.Acos((Math.Pow(_length2, 2) + Math.Pow(_length3, 2) - Math.Pow(_length1, 2)) / 2 * _length2 * _length3);
                return _angle2;
            }
            else if (n==3)
            {
                _angle3 = Math.Acos((Math.Pow(_length3, 2) + Math.Pow(_length1, 2) - Math.Pow(_length2, 2)) / 2 * _length3 * _length1);
                return _angle3;
            } else
            return 0;
        }*/
    }
}
