using Weather_Generation.WeatherGenerator.Model.Enums;

namespace Weather_Generation.WeatherGenerator.Model
{
    public class Weather
    {

        public WeatherWindEffects WindEffect { get; private set; }
        public WeatherPrecipEffects PrecipEffect { get; private set; }
        public WeatherTempEffects TempEffect { get; private set; }

        public Weather(WeatherWindEffects wind, WeatherTempEffects temp, WeatherPrecipEffects precip)
        {
            WindEffect = wind;
            PrecipEffect = precip;
            TempEffect = temp;
        }

    }
}
