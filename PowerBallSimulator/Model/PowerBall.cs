using System;

namespace PowerBallSimulator.Model
{
    public abstract class PowerBall
    {
        // Establish a random seed for each ball
        protected Random random = RandomNumber.GetRandomSeed();
        protected int upperBound;
        public string Color { get; set; }
        public int Number { get; set; }
    }

    public class WhiteBall : PowerBall
    {
        public WhiteBall()
        {
            upperBound = 70;
            Color = "white";
            Number = random.Next(1, upperBound);
        }
    }

    public class RedBall : PowerBall
    {
        public RedBall()
        {
            upperBound = 27;
            Color = "red";
            Number = random.Next(1, upperBound);
        }
    }

    class RandomNumber
    {
        public static Random GetRandomSeed()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return random;
        }
    }
}
