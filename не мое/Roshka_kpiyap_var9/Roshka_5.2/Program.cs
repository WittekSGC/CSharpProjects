using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshka_5._2
{
    class Rectangle
    {
        private int _xPos;
        private int _yPos;
        private int _ln1;
        private int _ln2;

        public Rectangle(int x, int y)
        {
            _xPos = x;
            _yPos = y;
            _ln1 = _xPos;
            _ln2 = _yPos;
        }

        public (int l1, int l2, int l3, int l4) GetLength() //длинны 
        {
            return (_ln1, _ln2, _ln1, _ln2);
        }

        public float GetPerimeter() //периметр
        {
            return ((_ln1 + _ln2) * 2);
        }

        public float GetSquare() //площадь
        {
            return (_ln1 * _ln2);
        }

        public bool SetLength(int l1, int l2, int l3, int l4)
        {
            if ((l1 == l3) && (l2 == l4))
            {
                _ln1 = l1;
                _ln2 = l2;
                return true;
            }
            else return false;
        }

        public bool SquareBool()
        {
            if (_ln1 == _ln2) return true;
            else return false;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a,b");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(a, b);
            float perim = rect.GetPerimeter();
            Console.WriteLine(perim);
            Console.WriteLine(rect.GetSquare());
            Console.WriteLine(rect.GetLength());
        }
    }
}
