using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0, 1, 2, 分別代表剪刀, 石頭, 布
            string winner = GetWinner(1, 0); // 玩家1出石頭，玩家2出剪刀
            Console.Write(winner); // 顯示結果
            Console.Read();
        }

        public static string GetWinner(int player1Value, int player2Value)
        {
            //平手
            if (player1Value == player2Value)
            {
                return "平手";
            }
            else if ((player1Value == 0 && player2Value == 1) || // 玩家1出剪刀，玩家2出石頭，玩家2勝利
                     (player1Value == 1 && player2Value == 2) || // 玩家1出石頭，玩家2出布  ，玩家2勝利
                     (player1Value == 2 && player2Value == 0))   // 玩家1出布  ，玩家2出剪刀，玩家2勝利
            {
                return "player_2勝利";
            }
            else // 其餘情況皆是玩家1勝利
            {
                return "player_1勝利";
            }
        }
    }
}
