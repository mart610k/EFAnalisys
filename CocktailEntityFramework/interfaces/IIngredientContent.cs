using CocktailEntityFramework.classes;
using CocktailEntityFramework.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailEntityFramework.interfaces
{
    interface IIngredientContent
    {

        IngredientBase Ingredient { get; }
        
        UnitType UnitType { get; }

        int UnitAmount { get; }
    }
}
