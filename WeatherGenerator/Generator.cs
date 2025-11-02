using Weather_Generation.WeatherGenerator.Model;
using Weather_Generation.WeatherGenerator.Model.Enums;

namespace Weather_Generation.WeatherGenerator
{
    public class Generator
    {
        private Season season;
        private Biome biome;
        private bool Midwinter = false;
        private DiceModel diceModel;

        public Generator(Season season, Biome biome, bool midwinter)
        {
            this.season = season;
            this.biome = biome;
            Midwinter = midwinter;
            diceModel = new DiceModel();
        }

        public Generator(Season season, Biome biome, bool midwinter, int seedValue) : this(season, biome, midwinter)
        {
            diceModel = new DiceModel(seedValue);
        }
    }
}
