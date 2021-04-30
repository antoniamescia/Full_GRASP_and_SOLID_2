using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        
        public static void PrintRecipe(Recipe recipe)
        {
           Console.WriteLine(recipe);
        }
    }
}

/*
Utilizamos el principio SRP en primera instancia. La clase Recipe no debería tener la responsabilidad de imprimirse a si misma: Recipe simplemente debe armar la lista de pasos que la identifican. 
Se crea ConsolePrinter para imprimir el nombre de la receta y la lista de pasos a seguir. 
*/