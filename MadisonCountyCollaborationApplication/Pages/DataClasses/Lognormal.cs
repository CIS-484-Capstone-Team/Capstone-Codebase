﻿using MadisonCountyCollaborationApplication.Pages.DataClasses;
using System.Reflection.Metadata;

namespace MadisonCountyCollaborationApplication.Pages.DataClasses
{
    public class Lognormal : Distribution
    {
        public Random rand;
        public double mean;
        public double variance;
        public Lognormal(Random rand, double mu, double sigma) : base(rand)
        {
            mean = mu;
            variance = sigma;
            this.rand = rand;
        }
        //log tranformation of Box-Muller transform
        public double GenerateRandom()
        {
            double u1 = 1 - rand.NextDouble();
            double u2 = 1 - rand.NextDouble();
            double randStdNormal = Math.Sqrt(-2 * Math.Log(u1)) * Math.Sin(2 * Math.PI * u2);
            return Math.Pow(Math.E, mean + Math.Sqrt(variance) * randStdNormal);
        }
    }
}
