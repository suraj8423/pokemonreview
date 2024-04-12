using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonReviewApp.Models {
    public class Category {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}