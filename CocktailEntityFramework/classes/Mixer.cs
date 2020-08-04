using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailEntityFramework.classes
{
    [Table("Mixer")]
    class Mixer : IngredientBase
    {
        public Mixer(string name) : base(name)
        {

        }
        public Mixer() : base()
        {

        }
    }
}
