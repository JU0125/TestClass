using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        /// <summary>
        /// 對調二個數值。寫一支函數, 傳入二個數字,傳回一個陣列內含傳入的二個數字, 並且按大小排列
        /// </summary>
        /// <param name=""></param>
        static void Main(string[] args)
        {
            // 大high;小low
            string highlow = Gethighlow(9, 2); 
            Console.Write("["+highlow+"]"); // 顯示結果
            Console.Read();
        }

        public static string Gethighlow(int Value1, int Value2)
        {
            if (Value1 == Value2)
            {
                return Value1 + "," + Value2; ;
            }
            else if (Value1>Value2)
            {
                return Value2+","+Value1;
            }
            else 
            {
                return Value1+ "," +Value2;
            }
        }
    }
}
