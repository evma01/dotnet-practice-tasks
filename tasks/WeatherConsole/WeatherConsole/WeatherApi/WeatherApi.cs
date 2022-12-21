using System.Net.Http.Json;
using WeatherConsole;

internal class WeatherApi
{
    private readonly HttpClient _httpClient;

    public WeatherApi()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://api.open-meteo.com/v1/forecast/")
        };
    }

    public async void logWeather(Coordinate coordinate)
    {
        string query = WeatherApiHelper.GenerateWeatherRequestUri(coordinate);

        try
        {
            WeatherResponse response = await this._httpClient.GetFromJsonAsync<WeatherResponse>(query);
            Console.WriteLine("Response: {0}", response);
        }
        catch (Exception e)
        {
            Console.WriteLine("{0} Exception caught: ", e);
        }
    }
}