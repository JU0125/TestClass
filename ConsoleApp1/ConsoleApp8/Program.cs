using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        /// <summary>
        /// 確認一個快樂號碼需按照以下幾個步驟
        /// 從任意正整數開始，將它以每位數的平方的總和取代
        /// 重複這個步驟，直到它等於 1 或是陷入無窮迴圈(不包含1 )
        /// 那些結果等於 1 的號碼就是快樂的
        /// n 為快樂號碼即回傳 true，反之則回傳 false
        /// </summary>
        /// <param name=""></param>
        static void Main(string[] args)
        {
            bool happyNumber = IsHappyNumber(5);
            Console.Write(happyNumber); // 顯示結果
            Console.Read();
        }

        public static bool IsHappyNumber(int n)
        {

            List<int> templist = new List<int>();

            while (n > 0)
            {
                int temp = 0;
                while (n > 0)
                {
                    int i = n % 10;

                    temp += i * i;
                    n = n / 10;
                }

                if (templist.Contains(temp))
                {
                    return false;
                }
                else
                {
                    templist.Add(temp);
                }

                if (temp == 1)
                {
                    return true;
                }
                n = temp;
            }
            return false;
        }
    }
}
