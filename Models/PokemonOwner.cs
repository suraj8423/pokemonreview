using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonReviewApp.Models {
    public class PokemonOwner {
        public int PokemonId { get; set; }
        public int OwnerId { get; set; }
        public Pokemon Pokemon { get; set; }
         public Owner Owner { get; set; }
    }
}