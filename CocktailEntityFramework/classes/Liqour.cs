using CocktailEntityFramework.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailEntityFramework.classes
{
    class Liqour : IngredientBase, IAlcholic
    {
        public float Percentage { get; private set; }

        public Liqour(string name, float alcPercentage) : base(name)
        {
            Percentage = alcPercentage;
        }
    }
}
