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
            //IRecipe recipe = new Recipe("Mix Test");
            //recipe.AddIngredientContent(new Ingre)



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

        static void AddIngredients()
       {
            using (IngredientContext ctx = new IngredientContext())
            {
                
                ctx.AddIngridientBase(new Liqour("Vodka", 37.5f));
                ctx.AddIngridientBase(new Liqour("Whisky", 40f));
                ctx.AddIngridientBase(new Mixer("Apple Juice"));
                ctx.AddIngridientBase(new Mixer("Mango Juice"));
                ctx.AddIngridientBase(new Mixer("Orange Juice"));
                ctx.AddIngridientBase(new Mixer("Grapefruit Juice"));
                ctx.AddIngridientBase(new Accessory("Straw"));
                ctx.AddIngridientBase(new Accessory("Melon"));
                ctx.AddIngridientBase(new Accessory("Olive"));
                ctx.AddIngridientBase(new Liqour("Gin", 40f));
                ctx.AddIngridientBase(new Mixer("Cranberry Juice"));
                ctx.AddIngridientBase(new Mixer("Sprite"));
                ctx.AddIngridientBase(new Mixer("Lime Juice"));
                ctx.AddIngridientBase(new Mixer("Cranberry Juice"));
                ctx.AddIngridientBase(new Accessory("Ice"));
                ctx.AddIngridientBase(new Accessory("Lime"));


            }
        }
        static void AddDrinks()
        {
            using (IngredientContext ctx = new IngredientContext())
            {

                IngredientBase vodka = ctx.IngredientBase.Where(s => s.Name == "Vodka").FirstOrDefault();
                IngredientBase cranberryJuice = ctx.IngredientBase.Where(s => s.Name == "Cranberry Juice").FirstOrDefault();
                IngredientBase grapefruitJuice = ctx.IngredientBase.Where(s => s.Name == "Grapefruit Juice").FirstOrDefault();
                IngredientBase ice = ctx.IngredientBase.Where(s => s.Name == "Ice").FirstOrDefault();
                IngredientBase lime = ctx.IngredientBase.Where(s => s.Name == "Lime").FirstOrDefault();

                Recipe seaBreeze = new Recipe("Sea Breeze");

                seaBreeze.AddIngredientContent(new IngredientContent(grapefruitJuice, enums.UnitType.ml, 50));
                seaBreeze.AddIngredientContent(new IngredientContent(cranberryJuice, enums.UnitType.ml, 120));
                seaBreeze.AddIngredientContent(new IngredientContent(vodka, enums.UnitType.ml, 40));
                seaBreeze.AddIngredientContent(new IngredientContent(ice, enums.UnitType.piece, 1));
                seaBreeze.AddIngredientContent(new IngredientContent(lime, enums.UnitType.slice, 1));

                Recipe vodkaDrink = new Recipe("VODKA");
                vodkaDrink.AddIngredientContent(new IngredientContent(vodka, enums.UnitType.ml, 100));

                ctx.Recipe.Add(seaBreeze);
                ctx.Recipe.Add(vodkaDrink);
                ctx.SaveChanges();
            }
       }
    }
}