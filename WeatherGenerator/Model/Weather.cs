using Weather_Generation.WeatherGenerator.Model.Enums;

namespace Weather_Generation.WeatherGenerator.Model
{
    public class Weather
    {
        public Season Season { get; private set; }
        public Biome Biome { get; private set; }
        public WeatherWindEffects WindEffect { get; private set; }
        public WeatherPrecipEffects PrecipEffect { get; private set; }
        public WeatherTempEffects TempEffect { get; private set; }

        public Weather(Season season, Biome biome, WeatherWindEffects wind, WeatherTempEffects temp, WeatherPrecipEffects precip)
        {
            Season = season;
            Biome = biome;
            WindEffect = wind;
            PrecipEffect = precip;
            TempEffect = temp;
        }
    }
}
