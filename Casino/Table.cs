using System.Collections;
using System.Collections.Generic;

namespace Casino
{
    /// <summary>
    /// Contains working bets.
    /// </summary>
    public class Table : IEnumerable<Bet>
    {
        public int limit;
        public int minimum;
        public List<Bet> bets;

        public Table()
        {
            bets = new List<Bet>();
        }

        /// <summary>
        /// Adds a bet to table.
        /// </summary>
        /// <param name="bet">Bet to add to table.</param>
        public void PlaceBet(Bet bet)
        {
            if (bet != null && bet.amountBet >= minimum)
            {
                bets.Add(bet);
            }
        }

        /// <summary>
        /// Throws InvalidBet if the bets go over the table limit.
        /// </summary>
        public void IsValid()
        {
            int totalOfBets = 0;

            foreach(Bet bet in bets)
            {
                totalOfBets += bet.amountBet;
            }

            if(totalOfBets > limit)
            {
                throw new InvalidBet();
            }
        }

        public IEnumerator<Bet> GetEnumerator()
        {
            return ((IEnumerable<Bet>)bets).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Bet>)bets).GetEnumerator();
        }

        public override string ToString()
        {
            return "[" + string.Join(", ", bets) + "]";
        }
    }
}
