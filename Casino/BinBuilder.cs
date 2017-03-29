using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class BinBuilder
    {
        public void BuildBins(Wheel wheel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Generates all stright bets
        /// </summary>
        /// <param name="wheel"></param>
        public void GenerateStraightBets(Wheel wheel)
        {
            Outcome outcome;

            // Add 0-36
            for(int i = 0; i < 37; i++)
            {
                outcome = new Outcome(i.ToString(), RouletteGame.StraightBet);

                wheel.AddOutcome(i, outcome);
            }

            // Add 00
            outcome = new Outcome("00", RouletteGame.StraightBet);

            wheel.AddOutcome(37, outcome);
        }

        /// <summary>
        /// Generates all split bets
        /// </summary>
        /// <param name="wheel"></param>
        public void GenerateSplitBets(Wheel wheel)
        {
            Outcome outcome;
            int num;

            // Add left-right bets
            for(int row = 0; row < 12; row++)
            {
                // First Column
                num = (3 * row) + 1;

                outcome = new Outcome(num + ", " + (num + 1), RouletteGame.SplitBet);

                wheel.AddOutcome(num, outcome);
                wheel.AddOutcome(num + 1, outcome);

                // Second Column
                num = (3 * row) + 2;

                outcome = new Outcome(num + ", " + (num + 1), RouletteGame.SplitBet);

                wheel.AddOutcome(num, outcome);
                wheel.AddOutcome(num + 1, outcome);
            }

            // Add up-down bets
            for (num = 1; num < 33; num++)
            {
                outcome = new Outcome(num + ", " + (num + 3), RouletteGame.SplitBet);

                wheel.AddOutcome(num, outcome);
                wheel.AddOutcome(num + 3, outcome);
            }
        }

        public void GenerateStreetBets(Wheel wheel)
        {
            throw new NotImplementedException();
        }

        public void GenerateCornerBets(Wheel wheel)
        {
            throw new NotImplementedException();
        }

        public void GenerateLineBets(Wheel wheel)
        {
            throw new NotImplementedException();
        }

        public void GenerateDozenBets(Wheel wheel)
        {
            throw new NotImplementedException();
        }

        public void GenerateColumnBets(Wheel wheel)
        {
            throw new NotImplementedException();
        }

        public void GenerateEvenMoneyBets(Wheel wheel)
        {
            throw new NotImplementedException();
        }

        public void GenerateZeroBets(Wheel wheel)
        {
            throw new NotImplementedException();
        }
    }
}
