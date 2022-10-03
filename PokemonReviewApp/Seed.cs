using PokemonReviewApp.Data;
using PokemonReviewApp.Models;

namespace PokemonReviewApp
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }

        public void SeedDataContext() {
            if (!dataContext.pokemonOwners.Any()) {
                var pokemonOwner = new List<PokemonOwner>() {
                new PokemonOwner() {
                    Pokemon = new Pokemon() { 
                    Name="Pikachu",
                    Birthdate=new DateTime(1903,1,1),
                    PokemonCatagories=new List<PokemonCatagory>() { 
                    new PokemonCatagory() { 
                    category= new Category() { 
                        Name="Electric",

                    }
                    }
                    },
                    Review = new List<Review>() {
                    new Review { Title="Pikachu",Text = "Pickahu is the best pokemon, because it is electric", 
                                reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Pikachu", Text = "Pickachu is the best a killing rocks",
                                reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Pikachu",Text = "Pickchu, pickachu, pikachu", 
                                reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                    }
                    },
                    Owner=new Owner() { 
                    Name ="Harry potter",
                    Gym="Misty's gym",
                    country =new Country() { 
                    Name="safaron city"
                    }
                    }
                },
                new PokemonOwner() {
                    Pokemon = new Pokemon() {
                    Name="Squartile",
                    Birthdate=new DateTime(1903,1,2),
                    PokemonCatagories=new List<PokemonCatagory>() {
                    new PokemonCatagory() {
                    category= new Category() {
                        Name="Water",

                    }
                    }
                    },
                    Review = new List<Review>() {
                    new Review { Title="Pikachu",Text = "Squartile is the best pokemon, because it is water type",
                                reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Pikachu", Text = "Squartile is the best a killing rocks",
                                reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Pikachu",Text = "Squartile, Squartile, Squartile",
                                reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                    }
                    },
                    Owner=new Owner() {
                    Name ="Ram",
                    Gym="Brock's gym",
                    country =new Country() {
                    Name="kanto city"
                    }
                    }
                },

                new PokemonOwner() {
                    Pokemon = new Pokemon() {
                    Name="Raichu",
                    Birthdate=new DateTime(1903,1,1),
                    PokemonCatagories=new List<PokemonCatagory>() {
                    new PokemonCatagory() {
                    category= new Category() {
                        Name="Electric",

                    }
                    }
                    },
                    Review = new List<Review>() {
                    new Review { Title="Raichu",Text = "Raichu is the best pokemon, because it is electric",
                                reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Pikachu", Text = "Raichu is the best a killing rocks",
                                reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Pikachu",Text = "Raichu, pickachu, pikachu",
                                reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                    }
                    },
                     Owner=new Owner() {
                    Name ="Lt. Surge",
                    Gym="Electric gym",
                    country =new Country() {
                    Name="Vermilion city"
                    }
                    }
                },

                };
                dataContext.pokemonOwners.AddRange(pokemonOwner);
                dataContext.SaveChanges();

            };

        
        }
    }
}
