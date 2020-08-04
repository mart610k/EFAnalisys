using CocktailEntityFramework.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailEntityFramework.classes
{
    abstract class IngredientBase : IIngredient
    {
        public string Name { get; private set; }

        protected IngredientBase(string name)
        {
            Name = name;
        }
    }
}
