
namespace PokemonReviewApp.Models
{
    public class Reviewer
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public ICollection<Review> Reviews { set; get; }
    }
}
