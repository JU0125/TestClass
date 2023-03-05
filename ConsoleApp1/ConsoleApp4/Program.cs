using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Parse("2023/02/24 18:15");//2023/02/24 10:50

            // 早上9:00
            DateTime startTime = dt.Date.AddHours(9);

            // 下午 1:30
            DateTime endTime = dt.Date.AddHours(13).AddMinutes(30);

            // 判斷是否為台股交易日的時間區間
            if (dt >= startTime && dt <= endTime)
            {
                Console.Write("今天是台股交易日。");
            }
            else
            {
                Console.Write("今天不是台股交易日。");
            }

            Console.Read();
        }
    }
}
