using System;
using System.Collections.Generic;

namespace Casino
{
    /// <summary>
    /// Contains bins and can select one at random.
    /// </summary>
    public class Wheel
    {
        public List<Bin<Outcome>> bins { get; set; }
        public Random rng { get; set; }
        public Dictionary<string, Outcome> allOutcomes { get; set; }

        public Wheel()
        {
            rng = new Random();
            bins = new List<Bin<Outcome>>();
            allOutcomes = new Dictionary<string, Outcome>();
            
            for(int i = 0; i < 38; i++)
            {
                bins.Add(new Bin<Outcome>());
            }
        }

        /// <summary>
        /// Adds outcome to bin based on number.
        /// </summary>
        /// <param name="number">Index of bin.</param>
        /// <param name="outcome">Outcome that relates to bin.</param>
        public void AddOutcome(int number, Outcome outcome)
        {
            if (number < 0 || number >= bins.Count)
                return;

            // add outcome to bin
            bins[number].Add(outcome);

            // add outcome to allOutcomes
            if (!allOutcomes.ContainsKey(outcome.name))
            {
                allOutcomes.Add(outcome.name, outcome);
            }
        }

        /// <summary>
        /// Select a bin at random.
        /// </summary>
        /// <returns>Selected Bin object.</returns>
        public Bin<Outcome> Next()
        {
            int value = rng.Next(38);

            return bins[value];
        }

        /// <summary>
        /// Gets a bin based on index.
        /// </summary>
        /// <param name="bin">Index of bin.</param>
        /// <returns>Bin object at index.</returns>
        public Bin<Outcome> Get(int bin)
        {
            if (bin < 0 || bin >= bins.Count)
                return null;

            return bins[bin];
        }

        /// <summary>
        /// Gets outcome mapping of all outcomes.
        /// </summary>
        /// <param name="name">Name of outcome.</param>
        /// <returns>Outcome if found.</returns>
        public Outcome GetOutcome(string name)
        {
            if (allOutcomes.ContainsKey(name))
            {
                return allOutcomes[name];
            }

            return null;
        }
    }
}
