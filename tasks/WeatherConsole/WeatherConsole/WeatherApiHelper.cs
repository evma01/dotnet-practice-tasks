namespace WeatherConsole;

public static class WeatherApiHelper
{
    public static string GenerateWeatherRequestUri(Coordinate coordinate)
    {
        return $"?current_weather=true&latitude={coordinate.Latitude}&longitude={coordinate.Longitude}";
    }
}