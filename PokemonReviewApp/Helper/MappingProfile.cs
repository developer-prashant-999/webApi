using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helper
{
    public class MappingProfileL:Profile
    {
        public MappingProfileL()
        {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}
