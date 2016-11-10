using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerBallSimulator
{
    public static class PayoutRules
    {
        public static int CalculateReturnValue(List<int> WhiteActuals, List<int> WhiteGuesses,
            int RedActual, int RedGuess)
        {
            int WhiteMatchCount = 0;
            int RedMatchCount = 0;

            for (int i = 0; i < WhiteActuals.Count; i++)
            {
                for (int j = 0; j < WhiteGuesses.Count; j++)
                {
                    if (WhiteActuals[i] == WhiteGuesses[j])
                    {
                        if (WhiteActuals[i] != 0)
                        {
                            WhiteMatchCount++;
                            WhiteActuals[i] = 0;
                            WhiteGuesses[j] = 0;
                        }
                    }
                }
            }

            if (RedActual == RedGuess)
            {
                RedMatchCount = 1;
            }

            if (WhiteMatchCount == 0 && RedMatchCount == 1)
            {
                return 4;
            }
            else if (WhiteMatchCount == 1 && RedMatchCount == 1)
            {
                return 4;
            }
            else if (WhiteMatchCount == 2 && RedMatchCount == 1)
            {
                return 7;
            }
            else if (WhiteMatchCount == 3 && RedMatchCount == 0)
            {
                return 7;
            }
            else if (WhiteMatchCount == 3 && RedMatchCount == 1)
            {
                return 100;
            }
            else if (WhiteMatchCount == 4 && RedMatchCount == 0)
            {
                return 100;
            }
            else if (WhiteMatchCount == 4 && RedMatchCount == 1)
            {
                return 50000;
            }
            else if (WhiteMatchCount == 5 && RedMatchCount == 0)
            {
                return 1000000;
            }
            // Grand Prize
            else if (WhiteMatchCount == 5 && RedMatchCount == 1)
            {
                return 10000000;
            }
            else
            {
                return 0;
            }
        }
    }
}
