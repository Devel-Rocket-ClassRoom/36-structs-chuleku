using System;
using System.Collections.Generic;
using System.Text;

struct RecipeCard
{
    public string Name;
    public int Servings;
    public Ingredient[] Ingredients;

    public RecipeCard(string name, int servings, Ingredient[] Ingredient)
    {
        Name = name;
        Servings = servings;
        Ingredients = Ingredient;
    }
    public void PrintRecipe()
    {
        Console.WriteLine($"[{Name}] ({Servings}인분)");
        Console.WriteLine("재료:");
        for (int i = 0; i < Ingredients.Length; i++)
        {
            Console.WriteLine($"-{Ingredients[i].Name}: {Ingredients[i].Amount}{Ingredients[i].Unit}");
        }
    }
    public RecipeCard ScaleRecipe(int newServings)
    {

        for (int i = 0; i < Ingredients.Length; i++)
        {
            Ingredients[i].Amount *= (newServings - Servings);
        }
        Servings = newServings;
        return this;
    }

}