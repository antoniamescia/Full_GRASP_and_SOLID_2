//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        public static ArrayList steps = new ArrayList();

        public static Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            steps.Add(step);
        }
        public void RemoveStep(Step step)
        {
            steps.Remove(step);
        }

        public StringBuilder RecipeDescription()
        {
            StringBuilder recipe = new StringBuilder();

            recipe.Append($"Receta de {FinalProduct.Description}:");
            foreach (Step step in Recipe.steps)
            {
                recipe.Append(step.StepDescription());
            }
            return recipe;
        }
    }
}