using System.Diagnostics;
using System.Net.Http.Json;
using WeatherConsole;

var citiesWithCoordinates = new Dictionary<string, Coordinate>(){
    { "Budapest", new Coordinate(47.4979, 19.0402) },
    { "Paris", new Coordinate(48.8566, 2.3522) },
    { "Stockholme", new Coordinate(61.20, 15.55) },
    { "London", new Coordinate(51.51, -0.13) },
    { "New York", new Coordinate(40.71, -74.01) },
    { "Toronto", new Coordinate(43.70, -79.42) },
    { "Morocco", new Coordinate(28.50, -10.0) },
    { "Tokyo", new Coordinate(35.69, 139.69) },
    { "Sydney", new Coordinate(-33.87, 151.21) }
};

var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://api.open-meteo.com/v1/forecast/")
};

Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();
foreach (var kvp in citiesWithCoordinates)
{
    string query = WeatherApiHelper.GenerateWeatherRequestUri(kvp.Value);
    Console.WriteLine("City: {0}, Coordinate: {1}, Query: {2}", kvp.Key, kvp.Value, query);

    try
    {
        WeatherResponse response = await httpClient.GetFromJsonAsync<WeatherResponse>(query);
        Console.WriteLine("Response: {0}", response);
    }
    catch (Exception e)
    {
        Console.WriteLine("{0} Exception caught: ", e);
    }
}
stopwatch.Stop();
Console.WriteLine(stopwatch.ElapsedMilliseconds);

stopwatch.Reset();
stopwatch.Start();

var tasks = new List<Task<WeatherResponse?>>();
foreach (var kvp in citiesWithCoordinates)
{
    string query = WeatherApiHelper.GenerateWeatherRequestUri(kvp.Value);
    Task<WeatherResponse?> responseTask = httpClient
        .GetFromJsonAsync<WeatherResponse>(query)
        .ContinueWith<WeatherResponse?>((task) => {
            Console.WriteLine($"City: {kvp.Key}, Coordinate: {kvp.Value}, Query: {query}");
            if (task.IsCompleted)
            {
                Console.WriteLine($"Response: {task.Result}");
            }
            if (task.IsFaulted)
            {
                Console.WriteLine("sad-panda");
            }
            return task.Result;
        });
    tasks.Add(responseTask);
}

await Task.WhenAll(tasks);
stopwatch.Stop();
Console.WriteLine(stopwatch.ElapsedMilliseconds);

//foreach (var task in tasks)
//{
//    Console.WriteLine("Task: {0}", await task);
//}

// Print all the cities' (citiesWithCoordinates) temprature to the console window
// Order doesn't matter
// It should be as time efficent as possible
// Sample http request:
//    string query = RequestHelper.GenerateWeatherRequestUri(new Coordinate(47.4979, 19.0402));
//    WeatherResponse response = await httpClient.GetFromJsonAsync<WeatherResponse>(query);