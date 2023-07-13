using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Country> Countries { set; get; }
        public DbSet<Owner> Owners { set; get; }
        public DbSet<Pokemon> Pokemon { set; get; }
        public DbSet<PokemonOwner> PokemonOwners { set; get; }
        public DbSet<PokemonCategory> PokemonCategories { get; set; }
        public DbSet<Review> Reviews { set; get; }
        public DbSet<Reviewer> Reviewers { set; get; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonCategory>()
                .HasKey(pc => new { pc.PokemonId, pc.CategoryId });
            modelBuilder.Entity<PokemonCategory>()
                .HasOne(p => p.Pokemon)
                .WithMany(pc => pc.PokemonCategories)
                .HasForeignKey(p => p.PokemonId);
            modelBuilder.Entity<PokemonCategory>()
                 .HasOne(p => p.Category)
                 .WithMany(pc => pc.PokemonCategories)
                 .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<PokemonOwner>()
                .HasKey(po => new { po.PokemonId, po.OwnerId });
            modelBuilder.Entity<PokemonOwner>()
                .HasOne(p => p.Pokemon)
                .WithMany(pc => pc.PokemonOwners)
                .HasForeignKey(p => p.PokemonId);
            modelBuilder.Entity<PokemonOwner>()
                 .HasOne(p => p.Owner)
                 .WithMany(pc => pc.PokemonOwners)
                 .HasForeignKey(c => c.OwnerId);
        }

    }
}
