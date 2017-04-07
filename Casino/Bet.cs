namespace Casino
{
    /// <summary>
    /// Contains amount bet and outcome bet on
    /// </summary>
    public class Bet
    {
        public int amountBet;
        public Outcome outcome;

        public Bet(int amount, Outcome outcome)
        {
            amountBet = amount;
            this.outcome = outcome;
        }

        /// <summary>
        /// Computes amount won icluding bet.
        /// </summary>
        /// <returns>Amount won.</returns>
        public int WinAmount()
        {
            return amountBet + (amountBet * outcome.odds);
        }
        
        /// <summary>
        /// Computes amount lost.
        /// </summary>
        /// <returns></returns>
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
