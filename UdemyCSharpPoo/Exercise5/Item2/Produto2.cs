using System.Globalization;

namespace Item2
{
    public class Produto2
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto2()
        {
            
        }

        public Produto2(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto2(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; // Não precisa dessa linha, já inicia com 0 na declaração de cima
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade +
                   " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}