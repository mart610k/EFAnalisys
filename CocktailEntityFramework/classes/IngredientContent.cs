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
        public int IgredientContentID { get;private set; }

        public IngredientBase Ingredient { get; private set; }

        public UnitType UnitType { get;private set; }

        public int UnitAmount { get;private set; }

        public IngredientContent()
        {

        }

        public IngredientContent(IngredientBase ingredient,UnitType unitType, int unitAmount)
        {
            Ingredient = ingredient;
            UnitType = unitType;
            UnitAmount = unitAmount;
        }
    }
}
