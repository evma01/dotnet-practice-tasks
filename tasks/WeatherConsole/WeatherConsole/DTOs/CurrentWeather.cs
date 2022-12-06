using System.Text.Json.Serialization;

public record CurrentWeather
(
    [property:JsonPropertyName("temperature")]
    double TemperatureInCelsius
);