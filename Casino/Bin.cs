using System.Collections.Generic;

// Note: There is a ImmutableHashSet, closer to frozenset, but requires an additional package.

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
