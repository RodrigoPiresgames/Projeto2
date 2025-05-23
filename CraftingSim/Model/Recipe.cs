using System;
using System.Collections.Generic;


namespace CraftingSim.Model
{
    /// <summary>
    /// Represents a Recipe with required materials and quantities to 
    /// craft an item.
    /// Recipes are ordered alphabetically by name. 
    /// </summary>
    public interface Recipe : IRecipe
    {
        public string Name { get; }
        public IReadOnlyDictionary<IMaterial, int> RequiredMaterials { get; }
        public double SuccessRate { get; }

    }
}