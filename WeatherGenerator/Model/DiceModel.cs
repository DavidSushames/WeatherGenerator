using System;

namespace Weather_Generation.WeatherGenerator.Model
{
    public class DiceModel
    {
        private Random rng;

        public int WindDice { get; private set; }
        public int PrecipDice { get; private set; }
        public int TempretureDice { get; private set; }

        public DiceModel()
        {
            rng = new Random(Guid.NewGuid().GetHashCode());
            WindDice = rng.Next(1, 7);
            PrecipDice = rng.Next(1, 7);
            TempretureDice = rng.Next(1, 7);
        }

        public DiceModel(int seedValue)
        {
            rng = new Random(seedValue);
            WindDice = rng.Next(1, 7);
            PrecipDice = rng.Next(1, 7);
            TempretureDice = rng.Next(1, 7);
        }

        public void RerollWind()
        {
            rng = new Random(Guid.NewGuid().GetHashCode());
            WindDice = rng.Next(1, 7);
        }

        public void RerollWind(int seedValue)
        {
            rng = new Random(seedValue);
            WindDice = rng.Next(1, 7);
        }

        public void RerollPrecip()
        {
            rng = new Random(Guid.NewGuid().GetHashCode());
            PrecipDice = rng.Next(1, 7);
        }

        public void RerollPrecip(int seedValue)
        {
            rng = new Random(seedValue);
            PrecipDice = rng.Next(1, 7);
        }

        public void RerollTemp()
        {
            rng = new Random(Guid.NewGuid().GetHashCode());
            TempretureDice = rng.Next(1, 7);
        }

        public void RerollTemp(int seedValue)
        {
            rng = new Random(seedValue);
            TempretureDice = rng.Next(1, 7);
        }

    }
}
