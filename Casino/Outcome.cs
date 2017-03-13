using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Outcome
    {
        public string name { get; set; }
        public int odds { get; set; }

        public Outcome(string name, int odds)
        {
            this.name = name;
            this.odds = odds;
        }

        public double winAmount(double amount)
        {
            return amount * odds;
        }
    }
}
