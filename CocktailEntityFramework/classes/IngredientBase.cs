using CocktailEntityFramework.interfaces;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailEntityFramework.classes
{
    //[Table("IngredientBase")]
    abstract class IngredientBase :/* Entity,*/ IIngredient
    {

        [Key]
        public string Name { get; private set; }

        protected IngredientBase(string name)
        {
            Name = name;
        }
        protected IngredientBase()
        {

        }
    }
}
