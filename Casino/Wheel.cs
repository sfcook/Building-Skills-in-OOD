using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Wheel
    {
        public List<Bin<Outcome>> bins { get; set; }
        public Random rng { get; set; }

        Wheel()
        {
            throw new NotImplementedException();
        }

        public void AddOutcome(int number, Outcome outcome)
        {
            throw new NotImplementedException();
        }

        public Bin<Outcome> Next()
        {
            throw new NotImplementedException();
        }

        public Bin<Outcome> Get(int bin)
        {
            throw new NotImplementedException();
        }
    }
}
