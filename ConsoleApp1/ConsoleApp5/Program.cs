using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        /// <summary>
        /// 如何取得一個正整數的每一位數,傳回int[]
        /// 12345，傳回int[](1,2,3,4,5)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("請輸入一個整數：");
            int input = int.Parse(Console.ReadLine());

            // 將整數的每個位數存入整數陣列中
            int[] digits = input.ToString().ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();

            Console.Write("整數陣列為：[");
            for (int i = 0; i < digits.Length; i++)
            {
                Console.Write(digits[i]);
                if (i < digits.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.Write("]");

            Console.Read();
        }
    }
}
