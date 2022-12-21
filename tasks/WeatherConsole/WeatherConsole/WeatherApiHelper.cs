using System.Net.Http.Json;

namespace WeatherConsole;

public static class WeatherApiHelper
{
    public static string GenerateWeatherRequestUri(Coordinate coordinate)
    {
        return $"?current_weather=true&latitude={coordinate.Latitude}&longitude={coordinate.Longitude}";
    }
    public static async Task<WeatherResponse> GetWeatherResponse(string query, HttpClient httpClient)
    {
        return await httpClient.GetFromJsonAsync<WeatherResponse>(query);
    }
}