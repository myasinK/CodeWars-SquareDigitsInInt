using System;
using System.Text;

namespace Kata_SquareDigits
{
    public static class SquareDigits
    {
        public static void SquareEach(int num)
        {
            var num2String = num.ToString();
            var sb = new StringBuilder("");
            foreach (var c in num2String)
            {
                var x = Char.GetNumericValue(c);
                var y = (x*x).ToString();
                sb.Insert(sb.Length, y);
            }
            //sb.Length
            Console.WriteLine(sb);
        }
    }
}