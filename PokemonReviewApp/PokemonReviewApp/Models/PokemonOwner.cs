namespace PokemonReviewApp.Models
{
    public class PokemonOwner
    {
        public int PokemonId { set; get; }
        public int OwnerId { set; get; }
        public Pokemon Pokemon { set; get; }
        public Owner Owner { set; get; }


    }
}
