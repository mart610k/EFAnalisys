using CocktailEntityFramework.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailEntityFramework.interfaces
{
    interface IRecipe
    {
        int RecipeID { get; }
        string Name { get; }

        List<IngredientContent> IngredientContents { get; }

        bool AddIngredientContent(IngredientContent ingredientContent);

        bool AddIngredientContent(IngredientContent[] ingredientContents);

        bool HaveAlcoholContent();
    }
}
