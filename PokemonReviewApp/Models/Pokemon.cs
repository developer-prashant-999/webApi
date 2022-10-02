﻿namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

        public ICollection<Review> Review { get; set; }

        public ICollection<PokemonOwner> pokemonOwners{ get; set; }
        public ICollection<PokemonCatagory> PokemonCatagories{ get; set; }


    }
}
