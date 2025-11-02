using System;

namespace Weather_Generation.WeatherGenerator.Model
{
    public class DiceModel
    {
        private Random rng;

        public int WindDice { get; private set; }
        public int PrecipDice { get; private set; }
        public int TempretureDice { get; private set; }

        private DiceModel(int d1, int d2, int d3)
        {
            WindDice = d1;
            PrecipDice = d2;
            TempretureDice = d3;
        }

        public DiceModel()
        {
            rng = new Random(Guid.NewGuid().GetHashCode());
            WindDice = rng.Next(0, 6);
            PrecipDice = rng.Next(0, 6);
            TempretureDice = rng.Next(0, 6);
        }

        public DiceModel(int seedValue)
        {
            rng = new Random(seedValue);
            WindDice = rng.Next(0, 6);
            PrecipDice = rng.Next(0, 6);
            TempretureDice = rng.Next(0, 6);
        }

        public void RerollWind()
        {
            rng = new Random(Guid.NewGuid().GetHashCode());
            WindDice = rng.Next(0, 6);
        }

        public void RerollWind(int seedValue)
        {
            rng = new Random(seedValue);
            WindDice = rng.Next(0, 6);
        }

        public void RerollPrecip()
        {
            rng = new Random(Guid.NewGuid().GetHashCode());
            PrecipDice = rng.Next(0, 6);
        }

        public void RerollPrecip(int seedValue)
        {
            rng = new Random(seedValue);
            PrecipDice = rng.Next(0, 6);
        }

        public void RerollTemp()
        {
            rng = new Random(Guid.NewGuid().GetHashCode());
            TempretureDice = rng.Next(0, 6);
        }

        public void RerollTemp(int seedValue)
        {
            rng = new Random(seedValue);
            TempretureDice = rng.Next(0, 6);
        }

        public bool EqualsWind(int value)
        {
            return value == WindDice;
        }

        public bool EqualsTemp(int value)
        {
            return value == TempretureDice;
        }

        public bool EqualsPrecip(int value)
        {
            return value == PrecipDice;
        }

        public void ModifyWind(int value)
        {
            WindDice += value;
        }

        public void ModifyTemp(int value)
        {
            TempretureDice += value;
        }

        public void ModifyPrecip(int value)
        {
            PrecipDice += value;
        }

        public DiceModel Copy()
        {
            return new DiceModel(WindDice, PrecipDice, TempretureDice);
        }

        public override string ToString()
        {
            return $"Current Dice Rolls: \nWind: {WindDice}\nTemptreture: {TempretureDice}\nPrecipitation: {PrecipDice}";
        }

    }
}
