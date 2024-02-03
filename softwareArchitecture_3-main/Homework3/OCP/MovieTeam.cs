using Homework3.SRP;

namespace Homework3.OCP
{
    public class MovieTeam
    {
        public Movie Movie { get; }

        public MovieTeam(Movie movie)
        {
            Movie = movie;
        }   

        public void getTeam(ITeam team)
        {
            Console.WriteLine("Участники съемочного процесса фильма " + Movie.Title + ": ");
            team.getMembers();
        }
    }
}
