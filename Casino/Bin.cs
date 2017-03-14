using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Casino
{
    /// <summary>
    /// Collection of Outcomes.
    /// </summary>
    /// <typeparam name="Outcome"></typeparam>
    public class Bin<Outcome> : HashSet<Outcome>
    {
        public Bin() : base()
        {

        }

        public Bin(IEnumerable<Outcome> collection) : base(collection)
        {

        }
    }
}
