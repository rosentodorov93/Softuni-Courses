using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    public class Dough
    {
        private const double defaultCaloriesPerGram = 2;
        private string flourType;
        private string bakingTechnique;
        private double grams;

        public Dough(string flourType, string bakingTechnique, double grams)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Grams = grams;
        }
        public double CaloriesPerGram => GetCaloriesPerGram();
        public string FlourType
        {
            get => flourType;
            private set
            {
                if (value == "white" || value == "wholegrain")
                {
                    flourType = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        public string BakingTechnique
        {
            get => bakingTechnique;
            private set
            {
                if (value == "crispy" || value == "chewy" || value == "homemade")
                {
                    bakingTechnique = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        public double Grams
        {
            get => grams;
            private set
            {
                if (value > 0 && value <= 200)
                {
                    grams = value;
                }
                else
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
            }
        }
        private double GetCaloriesPerGram()
        {                               
            return (defaultCaloriesPerGram * Grams) * TypeModifier() * BaikingModifier();
            
        }
        public double TypeModifier()
        {
            double typeModifier = 0;
            if (FlourType == "white")
            {
                typeModifier = 1.5;
            }
            else if (FlourType == "wholegrain")
            {
                typeModifier = 1.0;
            }
            return typeModifier;
        }
        public double BaikingModifier()
        {
            double baikinModifier = 0;
            if (BakingTechnique == "crispy")
            {
                baikinModifier = 0.9;
            }
            else if (BakingTechnique == "chewy")
            {
                baikinModifier = 1.1;
            }
            else if (BakingTechnique == "homemade")
            {
                baikinModifier = 1.0;
            }
            return baikinModifier;
        }
    }
}
