//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        public static ArrayList steps = new ArrayList();

        public void AddStep(Step step)
        {
            steps.Add(step);
        }
        public void RemoveStep(Step step)
        {
            steps.Remove(step);
        }
    }
}