using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path="/home/re/develop/AdventOfCode-2017/Day1/inputstring";
            string inputstring=System.IO.File.ReadAllText(path);
            char[]captcha=inputstring.ToCharArray();
            int len = captcha.Length;
            int sum=0;
            //part 1
            int distance = 1;
            //part 2
            distance = len/2;
            for (int i = 0; i < captcha.Length; i++)
            {
                int j= (i+distance)%len;
                if (captcha[i]==captcha[j])
                {
                    int value = (int) char.GetNumericValue(captcha[i]);
sum +=value;
                }
            }
// 1393


            
            Console.WriteLine(value: $"Summe = {sum}");
        }
    }
}
