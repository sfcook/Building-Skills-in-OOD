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
            amountBet = amount;
            this.outcome = outcome;
        }

        public int WinAmount()
        {
            return amountBet + (amountBet * outcome.odds);
        }
        
        public int LoseAmount()
        {
            return amountBet;
        }

        public override string ToString()
        {
            return string.Format("{0} on {1}", amountBet, outcome);
        }
    }
}
