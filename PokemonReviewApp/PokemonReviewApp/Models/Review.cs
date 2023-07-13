namespace PokemonReviewApp.Models
{
    public class Review
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Text { set; get; }
        public int Rating { get; set; }
        public Reviewer Reviewer { set; get; }
        public Pokemon Pokemon { set; get; }
    }
}
