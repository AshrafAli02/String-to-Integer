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
            string word = "2147483649";
            Console.WriteLine(IntParse(word));
            
        }

        public static int IntParse(string s)
        {
            int number = 0;
            string sign = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (number != 0 && symbol.Contains(s[i]))
                {
                    throw new FormatException();
                    
                }
                if (number != 0 && s[i]=='.')
                {
                    return number;
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
            return number;
        }
        //public static int Digit(char ch)
        //{
        //    int value = ch;
        //    int digit = 0;
        //    switch(value)
        //    {
        //        case 48:
        //            digit = 0;
        //            break;
        //        case 49:
        //            digit = 1;
        //            break;
        //        case 50:
        //            digit = 2;
        //            break;
        //        case 51:
        //            digit = 3;
        //            break;
        //        case 52:
        //            digit = 4;
        //            break;
        //        case 53:
        //            digit = 5;
        //            break;
        //        case 54:
        //            digit = 6;
        //            break;
        //        case 55:
        //            digit = 7;
        //            break;
        //        case 56:
        //            digit = 8;
        //            break;
        //        case 57:
        //            digit = 9;
        //            break;
        //    }
        //    return digit;
        //}
       
    }
    
}
