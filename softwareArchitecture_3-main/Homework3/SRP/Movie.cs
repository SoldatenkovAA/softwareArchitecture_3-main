namespace Homework3.SRP
{
    public class Movie
    {
        public string Title { get; }
        public int Year {  get; }
        
        public Movie(string title, int year)
        {
            Title = title;
            Year = year;
        }
    }
}
