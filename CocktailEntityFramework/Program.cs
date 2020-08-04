using CocktailEntityFramework.classes;
using System;
using System.Collections.Generic;
using CocktailEntityFramework.interfaces;

namespace CocktailEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IngredientContext ctx = new IngredientContext())
            {
                List<IIngredient> ingredients = ctx.LoadEverything();
                for (int i = 0; i < ingredients.Count; i++)
                {
                    Console.Write(ingredients[i].IngredientID + "|");
                    Console.Write(ingredients[i].Name + "|");
                    if (ingredients[i] is IAlcholic)
                    {
                        Console.Write(((IAlcholic)ingredients[i]).Percentage + "%");
                    }
                    else
                    {
                        Console.Write("N/A");
                    }
                    Console.WriteLine("|");
                }
            }
            Console.WriteLine("Uploded data to Database");
            Console.ReadKey();
        }

       static void AddDatabaseEntries()
       {
            using (IngredientContext ctx = new IngredientContext())
            {
                ctx.AddIngridientBase(new Liqour("Vodka", 37.5f));
                ctx.AddIngridientBase(new Liqour("Whisky", 40f));
                ctx.AddIngridientBase(new Mixer("Apple Juice"));
                ctx.AddIngridientBase(new Mixer("Mango Juice"));
                ctx.AddIngridientBase(new Mixer("Orange Juice"));
                ctx.AddIngridientBase(new Accessory("Ice cube"));
                ctx.AddIngridientBase(new Accessory("Straw"));
                ctx.AddIngridientBase(new Accessory("Melon"));
                ctx.AddIngridientBase(new Accessory("Olive"));
                ctx.AddIngridientBase(new Liqour("Gin", 40f));
            }
       }
    }
}