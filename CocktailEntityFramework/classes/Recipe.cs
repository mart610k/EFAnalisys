using CocktailEntityFramework.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailEntityFramework.classes
{
    class Recipe : IRecipe
    {
        [Key]
        public int RecipeID { get;private set; }
        public string Name { get; private set; }
        public List<IngredientContent> IngredientContents { get; private set; }

        public bool AddIngredientContent(IngredientContent ingredientContent)
        {
            try
            {
                IngredientContents.Add(ingredientContent);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddIngredientContent(IngredientContent[] ingredientContents)
        {
            try
            {
                IngredientContents.AddRange(ingredientContents.ToList());
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool HaveAlcoholContent()
        {
            if (0 == IngredientContents.Where(s => s.Ingredient is IAlcholic).ToList().Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Recipe()
        {
            IngredientContents = new List<IngredientContent>();
        }

        public Recipe(string name)
        {
            Name = name;
            IngredientContents = new List<IngredientContent>();
        }
    }
}
