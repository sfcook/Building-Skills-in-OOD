using System;
using System.Collections;
using System.Collections.Generic;

namespace Casino
{
    public class Table : IEnumerable<Bet>
    {
        public int limit;
        public int minimum;
        public List<Bet> bets;

        public Table()
        {

        }

        public void PlaceBet(Bet bet)
        {
            throw new NotImplementedException();
        }

        public void IsValid()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
