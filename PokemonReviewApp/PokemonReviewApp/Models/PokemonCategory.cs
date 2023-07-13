namespace PokemonReviewApp.Models
{
    public class PokemonCategory
    {
        public int PokemonId { set; get; }
        public int CategoryId { set; get; }
        public Pokemon Pokemon { set; get; }
        public Category Category { set; get; }

    }
}
