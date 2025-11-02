using Weather_Generation.WeatherGenerator.Model;
using Weather_Generation.WeatherGenerator.Model.Enums;

namespace Weather_Generation.WeatherGenerator
{
    public class Generator
    {
        private Season Season { get; }
        private Biome Biome { get; }
        private bool Midwinter { get; set; }
        private DiceModel DiceModel { get; }
        public Weather Weather { get; private set; }

        //refactor this to make generator once, then regen as many times as needs be.
        public Generator(Season season, Biome biome, bool midwinter)
        {
            Season = season;
            Biome = biome;
            Midwinter = midwinter;
            DiceModel = new DiceModel();
            Weather = GenerateWeather();
        }

        public Generator(Season season, Biome biome, bool midwinter, int seedValue) : this(season, biome, midwinter)
        {
            DiceModel = new DiceModel(seedValue);
            Weather = GenerateWeather();
        }

        private DiceModel SeasonalModifiers(DiceModel model, Season season)
        {
            DiceModel m2 = model.Copy();
            if (season == Season.SPRING)
                m2.ModifyPrecip(1);
            if (season == Season.SUMMER)
                m2.ModifyTemp(1);
            if (season == Season.AUTUMN)
                m2.ModifyWind(1);
            if (season == Season.WINTER)
                m2.ModifyTemp(-1);
            return m2;
        }

        private DiceModel BiomeModifiers(DiceModel model, Biome biome)
        {
            DiceModel m2 = model.Copy();
            if (biome == Biome.TROPICS)
            {
                m2.ModifyTemp(1);
                m2.ModifyPrecip(1);
            }
            if (biome == Biome.TAIGA)
            {
                m2.ModifyTemp(-1);
                m2.ModifyWind(1);
            }
            if (biome == Biome.DESERT)
                m2.ModifyPrecip(-1);
            //nothing for continental :(
            return m2;
        }

        private Weather GenerateWeather()
        {
            DiceModel weatherDice = DiceModel.Copy();
            if (weatherDice == null)
                weatherDice = new DiceModel();
            weatherDice = SeasonalModifiers(weatherDice, Season);
            weatherDice = BiomeModifiers(weatherDice, Biome);
            WeatherWindEffects wind = (WeatherWindEffects)weatherDice.WindDice;
            WeatherPrecipEffects precip = (WeatherPrecipEffects)weatherDice.PrecipDice;
            WeatherTempEffects temp = (WeatherTempEffects)weatherDice.TempretureDice;
            return new Weather(Season, Biome, wind, temp, precip);
        }

    }
}
