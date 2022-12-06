using System.Text.Json.Serialization;

public record WeatherResponse
(
    [property:JsonPropertyName("current_weather")]
    CurrentWeather CurrentWeather
);
