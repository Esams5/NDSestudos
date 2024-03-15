using System.Globalization;

namespace Proposto2
{
    public class Empregado
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = (SalarioBruto * (porcentagem / 100)) + SalarioBruto;
        }

        public override string ToString()
        {
            return Nome + ", " + "$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}