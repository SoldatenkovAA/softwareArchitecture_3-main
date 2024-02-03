using Homework3.SRP;
using Homework3.OCP;
using Homework3.LSP;
using Homework3.ISP;
using Homework3.DIP;

//SRP
Movie movie1 = new Movie("Мастер и Маргарита", 2023);
MovieProfit movieProfit1 = new MovieProfit(movie1, 1200000000, 4926635);
movieProfit1.estimateBoxOffice();
Console.WriteLine();

//OCP
MovieTeam movieTeam = new MovieTeam(movie1);
movieTeam.getTeam(new Actors());
movieTeam.getTeam(new Makers());
Console.WriteLine();

//LSP
List<IActor> actors = [new MainActor("Евгений Цыганов", "Мастер"),
    new MainActor("Юлия Снигирь", "Маргарита"),
    new CrowdActor("Екатерина Журавлева"),
    new CrowdActor("Михаил Коновалов")];
foreach (IActor actor in actors)
{
    Console.WriteLine(actor.getName() + ", " + actor.getPosition());
}
Console.WriteLine();

//ISP
Director director = new("Михаил Локшин", true);
Operator oper = new("Максим Жуков", true);
Console.WriteLine(director.getName() + ", " + director.getMovieRole() + ", " + director.CreateScript());
Console.WriteLine(oper.getName() + ", " + oper.getMovieRole() );
Console.WriteLine();

//DIP
List<ITypeMovie> movies = [new FilmCinema("Оппенгеймер"), new DigitalCinema("Барби"), new DigitalCinema("Бременские музыканты")];
Cinema cinema = new Cinema(4, movies);
cinema.playMovie();