using System;

namespace Lab11_LinearEquation
{
    public class Class1
    {
        struct LinearEquation
        {
            public double factorK, factorB, variableX;

            public LinearEquation(double factorB = 3, double factorK = 5, double variableX = 0)
            {
                this.factorB = factorB;
                this.factorK = factorK;
                this.variableX = variableX;
            }

        }
        public double Root()
        {
            variableX = -factorB / factorK;

        }
    }
}
}
