using CocktailEntityFramework.interfaces;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailEntityFramework.classes
{
    abstract class IngredientBase : IIngredient
    {
        [Key]
        public int IngredientID { get; set; }

        public string Name { get; set; }

        protected IngredientBase(string name)
        {
            Name = name;
        }
        protected IngredientBase()
        {

        }
    }
}
