namespace PosterFilms.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string MovieTitle { get; set; }
        public decimal TicketPrice { get; set; }

        public Movie(int id, string title, string director, int year, string description, DateTime date, TimeSpan time, string movieTitle, decimal ticketPrice)
        {
            Id = id;
            Title = title;
            Director = director;
            Year = year;
            Description = description;
            Date = date;
            Time = time;
            MovieTitle = movieTitle;
            TicketPrice = ticketPrice;
        }
    }
}
