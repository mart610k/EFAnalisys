using CocktailEntityFramework.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailEntityFramework.classes
{
    [Table("Liquor")]
    class Liqour : IngredientBase, IAlcholic
    {
        public float Percentage { get; set; }

        public Liqour(string name, float alcPercentage) : base(name)
        {
            Percentage = alcPercentage;
        }
        public Liqour()
        {

        }
    }
}
