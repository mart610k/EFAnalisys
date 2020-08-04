using CocktailEntityFramework.classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using CocktailEntityFramework.interfaces;

namespace CocktailEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
           


            using (IngredientContext ctx = new IngredientContext())
            {
                //IngredientBase ingredient = ;
                //ctx.IngredientBase.Add(ingredient);
                //ctx.SaveChanges();
                //ctx.AddIngridientBase(new Liqour("Vodka", 37.5f));
                List<IIngredient> mixers = ctx.LoadAlcoholics();
                //mixers.AddRange(ctx.LoadMixers());
                for (int i = 0; i < mixers.Count; i++)
                {
                    Console.WriteLine(mixers[i].IngredientID);
                    Console.WriteLine(mixers[i].Name);
                    if (mixers[i] is IAlcholic)
                    {
                        Console.WriteLine(((IAlcholic)mixers[i]).Percentage);
                    }
                }
                //Database.SetInitializer(new MigrateDatabaseToLatestVersion<IngredientContext, EF6Console.Migrations.Configuration>());
                //Liqour ingredient = new Liqour("Vodka",37.5f);
                //ctx.Liqour.Add(ingredient);
                //ctx.SaveChanges();

                //Liqour ingredient = new Liqour("Vodka", 37.5f);
                //ctx.Liqour.Add(ingredient);
                //ctx.SaveChanges();
                //ctx.AddIngridientBase(new Liqour("Gin", 40f));

            }
            Console.WriteLine("Uploded data to Database");
            Console.ReadKey();
        }

       
    }
}
