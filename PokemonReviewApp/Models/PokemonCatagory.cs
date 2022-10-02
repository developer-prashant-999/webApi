namespace PokemonReviewApp.Models
{
    public class PokemonCatagory
    {
        public int PokemonId { get; set; } 
        public int CatagoryId { get; set; }
        public Pokemon Pokemon { get; set; }
        public Category category { get; set; }    
    }
}
