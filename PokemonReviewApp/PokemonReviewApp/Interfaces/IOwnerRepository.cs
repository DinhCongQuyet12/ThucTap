﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();
        Owner GetOwner(int ownerId);
        ICollection<Owner> GetOwnerOfAPokemon(int pokeId);
        ICollection<Pokemon> GetPokemonByOwner(int ownerId);
        bool OwnerExists(int ownerId);
        bool UpdateOwner(Owner owner);
        bool CreateOwner(Owner owner);
        bool DeleteOwner(Owner owner);
        bool Save();
    }
}
