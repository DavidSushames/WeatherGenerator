using System;

namespace Weather_Generation.WeatherGenerator.Model
{
    public class DiceModel
    {
        private Random rng;
        public int TemperatureDice { get; private set; }

        private DiceModel(int d1, int d2, int d3)
        {
            TemperatureDice = d3;
        }

        public DiceModel()
        {
            rng = new Random(Guid.NewGuid().GetHashCode());
            TemperatureDice = rng.Next(0, 6);
        }

        public DiceModel(int seedValue)
        {
            rng = new Random(seedValue);
            TemperatureDice = rng.Next(0, 6);
        }
        public void RerollTemp()
        {
            rng = new Random(Guid.NewGuid().GetHashCode());
            TemperatureDice = rng.Next(0, 6);
        }
        public void RerollTemp(int seedValue)
        {
            rng = new Random(seedValue);
            TemperatureDice = rng.Next(0, 6);
        }

        public bool EqualsTemp(int value)
        {
            return value == TemperatureDice;
        }

        public void ModifyTemp(int value)
        {
            TemperatureDice += value;
        }

        public DiceModel Copy()
        {
            return new DiceModel(TemperatureDice);
        }

        public override string ToString()
        {
            return $"Current Dice Rolls: Tempterature: {TemperatureDice}";
        }

    }
}