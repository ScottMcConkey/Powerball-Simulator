using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerBallSimulator
{
    public abstract class PowerBall
    {
        // Establish a random seed for each ball
        protected Random random = RandomNumber.GetRandomSeed();
        protected int upperBound;
        public string Color { get; set; }
        public int Number { get; set; }
    }

    public class White : PowerBall
    {
        public White()
        {
            upperBound = 70;
            Color = "white";
            Number = random.Next(1, upperBound);
        }
    }

    public class Red : PowerBall
    {
        public Red()
        {
            upperBound = 27;
            Color = "red";
            Number = random.Next(1, upperBound);
        }
    }

    class Game
    {
        Game()
        {

        }
    }

    /// <summary>
	/// Every power ball needs a random number within its appropriate range.
    /// Use this function to generate a random seed that can be used by each
    /// Ball object. The object will determine the range.
	/// </summary>
    class RandomNumber
    {
        public static Random GetRandomSeed()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return random;
        }
    }
}
