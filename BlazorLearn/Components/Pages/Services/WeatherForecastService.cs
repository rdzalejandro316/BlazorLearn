namespace BlazorApp1.Components.Pages.Services;

public class WeatherForecastService
{
    public async Task<WeatherForecast[]> GetForecastAsync()
    {
        await Task.Delay(500);

        var startDate = DateOnly.FromDateTime(DateTime.Now);
        var summaries = new[] { 
            "Freezing", "Bracing","Chilly", "Cool","Mild",
            "Warm","Balmy", "Hot","Sweltering", "Scorching" 
        };
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = startDate.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = summaries[Random.Shared.Next(summaries.Length)]
        }).ToArray();
    }
}
