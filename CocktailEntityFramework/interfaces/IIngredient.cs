using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailEntityFramework.interfaces
{
    interface IIngredient
    {
        [Key]
        int IngredientID { get; set; }
        string Name { get; set; }
    }
}
