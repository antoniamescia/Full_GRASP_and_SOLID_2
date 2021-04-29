using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public static Product FinalProduct { get; set; }

        public static void PrintRecipe()
        {
            Console.WriteLine($"Receta de {FinalProduct.Description}:");
            foreach (Step step in Recipe.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}