using System;
using System.ComponentModel;

namespace PowerBallSimulator.Model
{
    public abstract class PowerBall : INotifyPropertyChanged
    {
        // Establish a random seed for each ball
        protected Random random = RandomNumber.GetRandomSeed();
        protected int upperBound;

        private int? _Number;
        public int? Number
        {
            get
            {
                return _Number;
            }
            set
            {
                _Number = value;
                OnPropertyChanged("Number");
            }
        }

        public void Clear()
        {
            Number = null;
        }

        public void AssignNumber()
        {
            Number = random.Next(1, upperBound);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string p)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(p));
            }
        }

    }

    public class WhiteBall : PowerBall
    {
        public WhiteBall()
        {
            upperBound = 70;
        }
    }

    public class RedBall : PowerBall
    {
        public RedBall()
        {
            upperBound = 27;
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
