using CocktailEntityFramework.enums;
using CocktailEntityFramework.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailEntityFramework.classes
{
    class IngredientContent : IIngredientContent
    {
        [Key]
        public int IgredientContentID { get; set; }

        public IIngredient Ingredient { get; set; }

        public UnitType UnitType { get; set; }

        public int UnitAmount { get; set; }

        public IngredientContent()
        {

        }
        public IngredientContent(IIngredient ingredient,UnitType unitType, int unitAmount)
        {
            Ingredient = ingredient;
            UnitType = unitType;
            UnitAmount = unitAmount;
        }
    }
}
