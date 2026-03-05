using System;
Ingredient[] pasta = new Ingredient[4];
pasta[0] = new Ingredient("스파게티면",200,"g");
pasta[1] = new Ingredient("토마토소스",150, "ml");
pasta[2] = new Ingredient("양파", 1, "개");
pasta[3] = new Ingredient("마늘", 3, "쪽");

RecipeCard tomatopasta = new RecipeCard("토마토파스타",2,pasta);
Console.WriteLine("=== 원본 레시피 ===");
tomatopasta.PrintRecipe();
Console.WriteLine();
Console.WriteLine("=== 4인분으로 변환 ===");
tomatopasta.ScaleRecipe(4);
tomatopasta.PrintRecipe();

