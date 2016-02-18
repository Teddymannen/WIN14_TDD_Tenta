namespace TentaTest
{
    internal class Inv
    {
        internal double CalcInvPerÅr(double slutÅr)
        {
            double startÅr = 2015;
            double invånare = 26000;
            double inflyttade = 300;
            double utflyttade = 325;
            double födda = 0.007 * invånare;
            double döda = 0.006 * invånare;
            var y = slutÅr - startÅr;

            if(y > 0)
            {
                for (int i = 0; i < y; i++)
                {
                    invånare = invånare + inflyttade - utflyttade + födda - döda;
                }
                return invånare;
            }
            else
            {
                return invånare;
            }
            
        }
    }
}