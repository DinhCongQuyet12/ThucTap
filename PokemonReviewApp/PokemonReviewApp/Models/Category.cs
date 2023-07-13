namespace PokemonReviewApp.Models
{
    public class Category
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; }

    }
}
