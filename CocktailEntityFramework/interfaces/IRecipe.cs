using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailEntityFramework.interfaces
{
    interface IRecipe
    {
        string Name { get; }

        List<IIngredientContent> IngredientContents { get; }


        bool AddIngredientContent(IIngredientContent ingredientContent);

        bool AddIngredientContent(IIngredientContent[] ingredientContents);

        bool HaveAlcoholContent();
    }
}
