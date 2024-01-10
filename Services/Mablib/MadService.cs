namespace TwoToSevenEndPoints.Services.Madlib
{
    public class MadService : IMadService
    {
        public string Madlib(string day, string city, string drink, string weather)
        {
            return $"My name is {day}, I'm from {city}. I enjoy drinking a cool refreshing {drink} on a nice {weather} day.";
        }
    }
}