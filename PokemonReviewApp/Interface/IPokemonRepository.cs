using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interface
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons(); 
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string id);

        bool PokemonExists(int pokeId);

    }
}
