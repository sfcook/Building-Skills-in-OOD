﻿using System;
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
    }
}
