using System;

namespace Casino
{
    /// <summary>
    /// Outcome on which a single bet can be placed.
    /// </summary>
    public class Outcome
    {
        public string name { get; set; }
        public int odds { get; set; }

        public Outcome(string name, int odds)
        {
            this.name = name;
            this.odds = odds;
        }

        /// <summary>
        /// Calculates the amount that was won.
        /// </summary>
        /// <param name="amount">Amount that was bet.</param>
        /// <returns>Amount that was won.</returns>
        public double WinAmount(double amount)
        {
            return amount * odds;
        }

        public override bool Equals(Object obj)
        {
            var outcome = obj as Outcome;

            if (outcome == null)
            {
                return false;
            }

            return outcome.name == this.name;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}:1)", name, odds);
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
    }
}
