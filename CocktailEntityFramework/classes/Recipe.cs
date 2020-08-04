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
        public int RecipeID { get; set; }
        public string Name { get; set; }
        public List<IIngredientContent> IngredientContents { get; set; }

        public bool AddIngredientContent(IIngredientContent ingredientContent)
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

        public bool AddIngredientContent(IIngredientContent[] ingredientContents)
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
            bool haveAlcohol = false;
            for (int i = 0; i < IngredientContents.Count; i++)
            {
                if(IngredientContents[i] is IAlcholic)
                {
                    haveAlcohol = true;
                }
            }
            return haveAlcohol;
        }
        public Recipe()
        {
            IngredientContents = new List<IIngredientContent>();
        }

        public Recipe(string name)
        {
            Name = name;
            IngredientContents = new List<IIngredientContent>();
        }
    }
}
