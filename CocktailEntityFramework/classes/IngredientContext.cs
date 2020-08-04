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

        public DbSet<Mixer> Mixer { get; set; }
        
        public DbSet<Liqour> Liqour { get; set; }

        public DbSet<Accessory> Accessory { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<IngredientContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        public bool AddMixer(Mixer mixerToAdd)
        {
            try
            {
                Mixer.Add(mixerToAdd);
                SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                
            }
        }
        public List<IIngredient> LoadMixer()
        {
            List<IIngredient> mixers;
            mixers = new List<IIngredient>(from b in Mixer select b);
            return mixers;
        }

        

    }

}
