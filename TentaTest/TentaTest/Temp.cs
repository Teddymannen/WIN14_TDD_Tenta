using System;

namespace TentaTest
{
    internal class Temp
    {
        internal string CalcTemp(double c)
        {
            if (c >= 18 && c <= 25)
            {
                return "lagom";
            }
            else
            {
                if (c > 25)
                {
                    return "för varmt";
                }
                else
                {
                    return "för kallt";
                }
            }
        }
    }
}