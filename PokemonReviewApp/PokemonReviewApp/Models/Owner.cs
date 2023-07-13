namespace PokemonReviewApp.Models
{
    public class Owner
    {
        public int Id { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gym { set; get; }
        public Country Country { set; get; }
        public ICollection<PokemonOwner> PokemonOwners { set; get; }


    }
}
