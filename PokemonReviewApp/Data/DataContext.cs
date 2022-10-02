using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }
        public DbSet<Category>categories { get; set; }
        public DbSet<Owner> owners{ get; set; }
        public DbSet<Country> countries{ get; set; }
        public DbSet<Pokemon> Pokemons{ get; set; }
        public DbSet<PokemonOwner> pokemonOwners{ get; set; }
        public DbSet<PokemonCatagory> pokemonCatagories{ get; set; }
        public DbSet<Review> reviews{ get; set; }
        public DbSet<Reviewer> reviewers{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<PokemonCatagory>()
                .HasKey(pc => new { pc.CatagoryId, pc.PokemonId });
            modelBuilder.Entity<PokemonCatagory>()
                .HasOne(p => p.Pokemon)
                .WithMany(pc => pc.PokemonCatagories)
                .HasForeignKey(p => p.PokemonId);
            modelBuilder.Entity<PokemonCatagory>()
                .HasOne(c => c.category)
                .WithMany(pc => pc.PokemonCatagories)
                .HasForeignKey(c => c.CatagoryId);


            modelBuilder.Entity<PokemonOwner>()
               .HasKey(po => new { po.PokemonId, po.OwnerId });
            modelBuilder.Entity<PokemonOwner>()
                .HasOne(p => p.Pokemon)
                .WithMany(po => po.pokemonOwners)
                .HasForeignKey(p => p.PokemonId);
            modelBuilder.Entity<PokemonOwner>()
                .HasOne(o => o.Owner)
                .WithMany(po => po.pokemonOwners)
                .HasForeignKey(o => o.OwnerId);

        }
    }
}
