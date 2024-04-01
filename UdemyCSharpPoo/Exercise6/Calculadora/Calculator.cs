namespace Calculadora
{
    class Calculator
    {
        /*public static void Triple(ref int x)
        {
            x = x * 3;
        }
         usando ref */

        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
        
        
        
    }
}