using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonReviewApp.Models {
    public class Reviewer {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}