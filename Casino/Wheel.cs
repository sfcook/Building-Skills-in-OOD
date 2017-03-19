using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Wheel
    {
        public List<Bin<Outcome>> bins { get; set; }
        public Random rng { get; set; }

        public Wheel()
        {
            rng = new Random();
            bins = new List<Bin<Outcome>>();
            
            for(int i = 0; i < 38; i++)
            {
                bins.Add(new Bin<Outcome>());
            }
        }

        public void AddOutcome(int number, Outcome outcome)
        {
            bins[number].Add(outcome);
        }

        public Bin<Outcome> Next()
        {
            int value = rng.Next(38);

            return bins[value];
        }

        public Bin<Outcome> Get(int bin)
        {
            return bins[bin];
        }
    }
}
