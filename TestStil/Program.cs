using System;

namespace TestStil
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(IsAllowedChar1('5'));
            //Console.WriteLine(IsAllowedChar2('5'));
            //Console.WriteLine(IsAllowedChar1('x'));
            //Console.WriteLine(IsAllowedChar2('x'));
            Console.WriteLine(CheckLetters("ANAana111"));
        }
        static double CheckLetters(string s)
        {
            bool result = false; int x = 0, y = 0;
            double p = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 97 || s[i] == 65 || s[i] == 101 || s[i] == 69 || s[i] == 105 || s[i] == 73 || s[i] == 111 || s[i] == 79 || s[i] == 117 || s[i] == 85)
                {
                    x++;
                    result = true;
                }

                string ss = s.ToLower(); int c = 0;

                if ((ss[i] == 'a' || ss[i] == 'b' || ss[i] == 'c' || ss[i] == 'd' || ss[i] == 'e' || ss[i] == 'f' ||
                    ss[i] == 'g' || ss[i] == 'h' || ss[i] == 'i' || ss[i] == 'j' || ss[i] == 'k' || ss[i] == 'l' ||
                    ss[i] == 'm' || ss[i] == 'n' || ss[i] == 'o' || ss[i] == 'q' || ss[i] == 'p' || ss[i] == 'r' ||
                    ss[i] == 's' || ss[i] == 't' || ss[i] == 'u' || ss[i] == 'v' || ss[i] == 'w' || ss[i] == 'x' ||
                    ss[i] == 'y' || ss[i] == 'z') && ss[i] != 'a' && ss[i] != 'e' && ss[i] != 'i' && ss[i] != 'o' && ss[i] != 'u') c++;

                if (c > 0) y++;
                result = false;

            }

            if (result == false)
                p = (double)y / (x + y) * 100;
            else if (result == true)
                p = (double)y / (x + y) * 100;

            return p;
        }

        //static bool IsEnabled2()
        //{
        //    return GetStatus() == "enabled";
        //}
        static bool IsAllowedChar1(char c)
        {
            if (Char.IsDigit(c) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsAllowedChar2(char c)
        {
            return Char.IsDigit(c);
        }
        static bool IsPanagram(string text)
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (text.ToLower().IndexOf(c) == -1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
