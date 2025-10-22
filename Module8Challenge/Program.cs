namespace VideoGames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // List of different videogames

            List<VideoGame> games = new List<VideoGame>();
            games.Add(new VideoGame { Name = "Super Mario Bros.", Genre = "Platform", Rating = 4.5 });
            games.Add(new VideoGame { Name = "Yoshi's Story", Genre = "Platform", Rating = 4.7 });
            games.Add(new VideoGame { Name = "Luigi's Mansion", Genre = "Platform", Rating = 4.3 });
            games.Add(new VideoGame { Name = "Top Heroes", Genre = "Mobile", Rating = 4.0 });
            games.Add(new VideoGame { Name = "CandyCrush", Genre = "Mobile", Rating = 3.8 });

            //create a LINQ to determin the top rated games
            var topRatedGames = (from game in games
                                 where game.Rating >= 4
                                 select game).ToList();

            //create a LINQ to sort the list of video games
            var sortedGames = (from game in topRatedGames
                               orderby game.Name
                               select game).ToList();

            // run the sort LINQ to sort the list
            foreach (var game in sortedGames)
            {
                // write to console the sorted game name
                Console.WriteLine(game.Name);
            }

        }
    }
}