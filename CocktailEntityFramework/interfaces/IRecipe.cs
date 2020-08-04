using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailEntityFramework.interfaces
{
    interface IRecipe
    {
        int RecipeID { get; set; }
        string Name { get; set; }

        List<IIngredientContent> IngredientContents { get; set;}


        bool AddIngredientContent(IIngredientContent ingredientContent);

        bool AddIngredientContent(IIngredientContent[] ingredientContents);

        bool HaveAlcoholContent();
    }
}
