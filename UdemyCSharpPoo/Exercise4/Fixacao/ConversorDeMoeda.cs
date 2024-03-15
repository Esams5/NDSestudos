namespace Fixacao
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double DolarParaReal(double quant, double cotacao)
        {
            double total = quant * cotacao;
            return total + total * Iof / 100;
        }
    }
}