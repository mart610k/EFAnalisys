using CocktailEntityFramework.interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailEntityFramework.classes
{
    class IngredientContext : DbContext
    {

        public IngredientContext() : base()
        {
        }

        public DbSet<IngredientContent> IngredientContent { get; set; }

        public DbSet<IngredientBase> IngredientBase { get; set; }

        public DbSet<Recipe> Recipe { get; set; }

        public bool AddIngridientBase(IngredientBase basei)
        {
            try
            {
                IngredientBase.Add(basei);
                SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;

            }
        }

        public List<IIngredient> LoadIngredientBase()
        {
            var mixer = IngredientBase.Where(s => s.Name != null);
            List<IIngredient> list = mixer.ToList<IIngredient>();
            return list;
        }
    }

}
