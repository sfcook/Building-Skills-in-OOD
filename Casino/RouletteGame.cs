using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class RouletteGame
    {
        public const int StraightBet = 35;
        public const int SplitBet = 17;
        public const int StreetBet = 11;
        public const int CornerBet = 8;
        public const int FiveBet = 6;
        public const int LineBet = 5;
        public const int DozenBet = 2;
        public const int ColumnBet = 2;
        public const int EvenMoneyBet = 1;
        public static readonly int[] RedNumbers = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
    }
}
