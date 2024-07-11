namespace PosterFilms.Model
{
    public class Info
    {
        public List<Movie> Movies { get; }
        public Info()
        {
            Movies = new List<Movie>
            {
                new Movie(1, "Матрица", "Director 1", 2020, "Description 1", new DateTime(2023, 7, 10), new TimeSpan(18, 0, 0), "описание", 10.99m),
                new Movie(2, "Film 2", "Director 2", 2019, "Description 2", new DateTime(2023, 7, 11), new TimeSpan(20, 0, 0), "Film 2 Title", 12.99m),
                new Movie(3, "Film 3", "Director 3", 2021, "Description 3", new DateTime(2023, 7, 12), new TimeSpan(17, 0, 0), "Film 3 Title", 8.99m)
            };
        }

        public Movie GetMovieById(int id)
        {
            return Movies.FirstOrDefault(movie => movie.Id == id);
        }
    }

}
