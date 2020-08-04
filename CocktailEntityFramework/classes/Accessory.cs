using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailEntityFramework.classes
{
    [Table("Accessory")]
    class Accessory : IngredientBase
    {
        public Accessory(string name) : base(name)
        {

        }
        public Accessory()
        {

        }
    }
}
