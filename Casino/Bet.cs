using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Bet
    {
        public int amountBet;
        public Outcome outcome;

        public Bet(int amount, Outcome outcome)
        {

        }

        public int WinAmount()
        {
            throw new NotImplementedException();
        }
        
        public int LoseAmount()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
