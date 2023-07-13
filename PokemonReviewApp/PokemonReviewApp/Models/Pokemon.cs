namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public DateTime BirthDate { set; get; }
        public ICollection<Review> Reviews { set; get; }
        public ICollection<PokemonOwner> PokemonOwners { set; get; }
        public ICollection<PokemonCategory> PokemonCategories { set; get; }
        
    }
}
