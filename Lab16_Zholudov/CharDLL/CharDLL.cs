using System;

namespace CharDLL
{
    public class CharDLL
    {
        public static string DetectChar(char parametr)
        {
            string numbers = "1234567890", liters = "qwertyuiopasdfghjklzxcvbnm", punctuation = "`~!@#$%^&*()_+=-\"№;:?(";
            string retstr = "";
            bool findet = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (parametr == numbers[i])
                {
                    findet = true;
                    retstr = "char is number";
                    break;
                }
            }

            if (!findet)
            {
                parametr = parametr.ToString().ToLower().ToCharArray()[0];
                for (int i = 0; i < liters.Length; i++)
                {
                    if (parametr == liters[i])
                    {
                        findet = true;
                        retstr = "char is letter";
                        break;
                    }
                }
            }
            
            if (!findet)
            {
                for (int i = 0; i < punctuation.Length; i++)
                {
                    if (parametr == punctuation[i])
                    {
                        findet = true;
                        retstr = "char is punctuation symbol";
                        break;
                    }
                }
            }

            if (!findet) retstr = "unknown symbol";

            return retstr;
        }
    }
}
