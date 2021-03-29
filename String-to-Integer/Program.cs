using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_to_Integer
{
    class Program
    {
        public static List<char> symbol = new List<char> { '+', '-', '*', '/', ' ', '#', '@', '!' };
        static void Main(string[] args)
        {
            string word = "12.5as-3";
            Console.WriteLine(IntParse(word));   
        }

        public static int IntParse(string s)
        {
            int number = 0;
            int number1 = 0;
            bool dot = false;
            string sign = "";
            for (int i = 0; i < s.Length; i++)
            {
                if ((number != 0 && symbol.Contains(s[i]))||(s[i]>=65 && s[i]<=90)|| (s[i] >= 97 && s[i] <= 122))
                {
                    throw new FormatException();
                    
                }
                if (number != 0 && s[i]=='.')
                {
                    number1 = number;
                    dot = true;
                }
                if (s[i] == '-'&& number==0)
                {
                    sign = "-";
                }
                else if (s[i] >= 48 && s[i] <= 57)
                {
                    int value = s[i];
                    number = (number * 10) + (value-48);
                }
            }
            if (number <= 2147483647 && number >= -2147483647)
            {

            }
            else
            {
                throw new Exception("int value out of range");
            }
            if (sign=="-")
            {
                return number * (-1);
            }
            if(dot==true)
            {
                return number1;
            }
            return number;
        }
       
    }
    
}
