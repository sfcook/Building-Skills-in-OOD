using System;
using System.Linq;

namespace Casino
{
    /// <summary>
    /// Builds all bins for wheel.
    /// </summary>
    public class BinBuilder
    {
        public void BuildBins(Wheel wheel)
        {
            GenerateStraightBets(wheel);
            GenerateSplitBets(wheel);
            GenerateStreetBets(wheel);
            GenerateCornerBets(wheel);
            GenerateLineBets(wheel);
            GenerateDozenBets(wheel);
            GenerateColumnBets(wheel);
            GenerateEvenMoneyBets(wheel);
            GenerateZeroBets(wheel);
        }

        /// <summary>
        /// Generates all stright bets.
        /// </summary>
        /// <param name="wheel"></param>
        public void GenerateStraightBets(Wheel wheel)
        {
            Outcome outcome;

            // Add 0-36
            for (int iNum = 0; iNum < 37; iNum++)
            {
                outcome = new Outcome(iNum.ToString(), RouletteGame.StraightBet);

                wheel.AddOutcome(iNum, outcome);
            }

            // Add 00
            outcome = new Outcome("00", RouletteGame.StraightBet);

            wheel.AddOutcome(37, outcome);
        }

        /// <summary>
        /// Generates all split bets.
        /// </summary>
        /// <param name="wheel"></param>
        public void GenerateSplitBets(Wheel wheel)
        {
            Outcome outcome;
            int iNum;

            // Add left-right bets
            for (int iRow = 0; iRow < 12; iRow++)
            {
                // First Column
                iNum = (3 * iRow) + 1;

                outcome = new Outcome(iNum + ", " + (iNum + 1), RouletteGame.SplitBet);

                wheel.AddOutcome(iNum, outcome);
                wheel.AddOutcome(iNum + 1, outcome);

                // Second Column
                iNum = (3 * iRow) + 2;

                outcome = new Outcome(iNum + ", " + (iNum + 1), RouletteGame.SplitBet);

                wheel.AddOutcome(iNum, outcome);
                wheel.AddOutcome(iNum + 1, outcome);
            }

            // Add up-down bets
            for (iNum = 1; iNum < 33; iNum++)
            {
                outcome = new Outcome(iNum + ", " + (iNum + 3), RouletteGame.SplitBet);

                wheel.AddOutcome(iNum, outcome);
                wheel.AddOutcome(iNum + 3, outcome);
            }
        }

        /// <summary>
        /// Generates all street bets.
        /// </summary>
        /// <param name="wheel"></param>
        public void GenerateStreetBets(Wheel wheel)
        {
            Outcome outcome;
            int iNum;

            for (int iRow = 0; iRow < 12; iRow++)
            {
                iNum = (3 * iRow) + 1;
                outcome = new Outcome(iNum + ", " + (iNum + 1) + ", " + (iNum + 2), RouletteGame.StreetBet);

                wheel.AddOutcome(iNum, outcome);
                wheel.AddOutcome(iNum + 1, outcome);
                wheel.AddOutcome(iNum + 2, outcome);
            }
        }

        /// <summary>
        /// Generates all corner bets.
        /// </summary>
        /// <param name="wheel"></param>
        public void GenerateCornerBets(Wheel wheel)
        {
            Outcome outcome;
            int iNum;

            for (int iRow = 0; iRow < 11; iRow++)
            {
                // Add first column
                iNum = (3 * iRow) + 1;
                outcome = new Outcome(iNum + ", " + (iNum + 1) + ", " + (iNum + 3) + ", " + (iNum + 4), RouletteGame.CornerBet);

                wheel.AddOutcome(iNum, outcome);
                wheel.AddOutcome(iNum + 1, outcome);
                wheel.AddOutcome(iNum + 3, outcome);
                wheel.AddOutcome(iNum + 4, outcome);

                // Add second column
                iNum = (3 * iRow) + 2;
                outcome = new Outcome(iNum + ", " + (iNum + 1) + ", " + (iNum + 3) + ", " + (iNum + 4), RouletteGame.CornerBet);

                wheel.AddOutcome(iNum, outcome);
                wheel.AddOutcome(iNum + 1, outcome);
                wheel.AddOutcome(iNum + 3, outcome);
                wheel.AddOutcome(iNum + 4, outcome);
            }
        }

        /// <summary>
        /// Generates all line bets.
        /// </summary>
        /// <param name="wheel"></param>
        public void GenerateLineBets(Wheel wheel)
        {
            Outcome outcome;
            int iNum;

            for (int iRow = 0; iRow < 11; iRow++)
            {
                iNum = (3 * iRow) + 1;
                outcome = new Outcome(iNum + ", " + (iNum + 1) + ", " + (iNum + 2) + ", " + (iNum + 3) + ", " + (iNum + 4) + ", " + (iNum + 5), RouletteGame.LineBet);

                wheel.AddOutcome(iNum, outcome);
                wheel.AddOutcome(iNum + 1, outcome);
                wheel.AddOutcome(iNum + 2, outcome);
                wheel.AddOutcome(iNum + 3, outcome);
                wheel.AddOutcome(iNum + 4, outcome);
                wheel.AddOutcome(iNum + 5, outcome);
            }
        }

        /// <summary>
        /// Generates all dozen bets.
        /// </summary>
        /// <param name="wheel"></param>
        public void GenerateDozenBets(Wheel wheel)
        {
            Outcome outcome;

            // For each dozen
            for (int iDozen = 0; iDozen < 3; iDozen++)
            {
                outcome = new Outcome("Dozen " + (iDozen + 1), RouletteGame.DozenBet);

                // For each number in dozen
                for (int iNum = 1; iNum <= 12; iNum++)
                {
                    wheel.AddOutcome((12*iDozen) + iNum, outcome);
                }
            }
        }

        /// <summary>
        /// Generates all column bets.
        /// </summary>
        /// <param name="wheel"></param>
        public void GenerateColumnBets(Wheel wheel)
        {
            Outcome outcome;

            // For each column
            for (int iColumn = 1; iColumn <= 3; iColumn++)
            {
                outcome = new Outcome("Column " + (iColumn), RouletteGame.ColumnBet);

                // For each row in column
                for (int iRow = 0; iRow < 12; iRow++)
                {
                    wheel.AddOutcome((3 * iRow) + iColumn, outcome);
                }
            }
        }

        /// <summary>
        /// Generates all even-money bets.
        /// </summary>
        /// <param name="wheel"></param>
        public void GenerateEvenMoneyBets(Wheel wheel)
        {
            Outcome outcomeRed = new Outcome("Red", RouletteGame.EvenMoneyBet);
            Outcome outcomeBlack = new Outcome("Black", RouletteGame.EvenMoneyBet);
            Outcome outcomeLow = new Outcome("Low", RouletteGame.EvenMoneyBet);
            Outcome outcomeHigh = new Outcome("High", RouletteGame.EvenMoneyBet);
            Outcome outcomeEven = new Outcome("Even", RouletteGame.EvenMoneyBet);
            Outcome outcomeOdd = new Outcome("Odd", RouletteGame.EvenMoneyBet);

            for (int iNum = 1; iNum < 37; iNum++)
            {
                // low/high
                if (iNum < 19)
                {
                    wheel.AddOutcome(iNum, outcomeLow);
                }
                else
                {
                    wheel.AddOutcome(iNum, outcomeHigh);
                }

                // even/odd
                if (iNum % 2 == 0)
                {
                    wheel.AddOutcome(iNum, outcomeEven);
                }
                else
                {
                    wheel.AddOutcome(iNum, outcomeOdd);
                }

                // red/black
                if (RouletteGame.RedNumbers.Contains(iNum))
                {
                    wheel.AddOutcome(iNum, outcomeRed);
                }
                {
                    wheel.AddOutcome(iNum, outcomeBlack);
                }
            }
        }

        /// <summary>
        /// Generates Five Bet special case.
        /// </summary>
        /// <param name="wheel"></param>
        public void GenerateZeroBets(Wheel wheel)
        {
            Outcome outcome = new Outcome("Five Bet", RouletteGame.FiveBet);

            // Add 0-3
            for (int iNum = 0; iNum < 4; iNum++)
            {
                wheel.AddOutcome(iNum, outcome);
            }

            // Add 00
            wheel.AddOutcome(37, outcome);
        }
    }
}
