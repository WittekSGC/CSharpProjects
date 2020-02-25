using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setchko_5._2
{
    class Money
    {
        protected int _first; //номинал
        protected int _second; //количество

        public Money(int nominal, int number)
        {
            _first = nominal;
            _second = number;
        }

        public (int nominal, int number) GetNomAndNum()
        {
            return (_first, _second);
        }

        public bool GetBuy(int n)
        {
            if (_first * _second >= n) return true;
            else return false;
        }

        public int GetBuyCount(int n)
        {
            if (GetBuy(n) == false) return 0;
            else
            {
                return (int)(_first * _second) / n;
            }
        }

        public void SetNominal(int count)
        {
            _first = count;
        }

        public void SetNumber(int count)
        {
            _second = count;
        }

        public int MoneyCount()
        {
            return _first * _second;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номинал и количество купюр:\nколичество = ");
            int kol = int.Parse(Console.ReadLine());
            Console.Write("номинал купюр = ");
            int nom = int.Parse(Console.ReadLine());

            Money money = new Money(nom, kol);

            Console.Write("Введите цену товара: ");
            int price = int.Parse(Console.ReadLine());
            if (money.GetBuy(price)) Console.WriteLine("Вы можете купить этот товар, а именно " + money.GetBuyCount(price) + " штук");
            else Console.WriteLine("Вам не хватит денег на покупку этого товара");
            Console.WriteLine("Сумма ваших денег: " + money.MoneyCount());
            Console.WriteLine("Изменить номинал и количество купюр: ");
            money.SetNominal(int.Parse(Console.ReadLine()));
            money.SetNumber(int.Parse(Console.ReadLine()));
            Console.WriteLine("Текущая сумма: " + money.MoneyCount());
            Console.ReadKey();
        }
    }
}
