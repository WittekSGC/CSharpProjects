using System;
using System.IO;

namespace KPI_Test
{
    interface IPerson
    {
        int HPLevel { get; }

        void IncHP(int plusHP);
        void DecHP(int minusHP);
    }

    interface INickname
    {
        string Nick { get; set; }
        string Level { get; set; }
        void Action();

    }
    public class Game : IPerson, INickname
    {
        public int HPLevel { get; } = 120;
        public string Nick { get; set; } = "NoName";
        public string Level { get; set; } = "Level1";

        public int MyHP { get; set; }

        public Game()
        {
            MyHP = HPLevel;
        }

        public Game(string nick, string level, int hp)
        {
            try
            {
                if (hp <= 0) throw new Exception();
                MyHP = hp;
            }
            catch (Exception)
            {
                Console.WriteLine("Health < 0! Standat hp installed: 120");
                MyHP = HPLevel;
            }
            Nick = nick;
            Level = level;
        }

        public void IncHP(int plusHP)
        {
            MyHP += plusHP;
        }

        public void DecHP(int minusHP)
        {
            try
            {
                if (minusHP > MyHP) throw new Exception();
                MyHP -= minusHP;
            }
            catch (Exception)
            {
                Console.WriteLine("Death DAMAGE!");
            }
        }

        public void Action()
        {
            Console.WriteLine("Action complete");
            Console.WriteLine("nickName: " + Nick);
            Console.WriteLine("Level: " + Level);
            Console.WriteLine("HP level: " + MyHP);
        }

        public void PrintOut()
        {
            FileStream file;
            if (Nick != "NoName" && Level != "Level1")
                file = new FileStream($"output{Nick}.txt", FileMode.OpenOrCreate, FileAccess.Write);
            else
                file = new FileStream($"output.txt", FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter writer = new StreamWriter(file);

            writer.WriteLine("Action complete");
            writer.WriteLine("nickName: " + Nick);
            writer.WriteLine("Level: " + Level);
            writer.WriteLine("HP level: " + MyHP);

            writer.Close();
            file.Close();
        }
    }
}
