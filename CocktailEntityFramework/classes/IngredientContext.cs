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

        public DbSet<IngredientBase> IngredientBase { get; set; }



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

        public List<Mixer> LoadMixers()
        {
            var mixer = Mixer.Where(s => s.IngredientID != -1);
            List<Mixer> list = mixer.ToList<Mixer>();
            return list;
        }

        public List<Liqour> LoadAlcoholics()
        {
            var liquour = Liqour.Where(s => s.IngredientID != -1);
            List<Liqour> list = liquour.ToList<Liqour>();
            return list;
        }
        public List<Accessory> LoadAccessories()
        {
            var accessory = Accessory.Where(s => s.IngredientID != -1);
            List<Accessory> list = accessory.ToList<Accessory>();
            return list;
        }


    }

}
