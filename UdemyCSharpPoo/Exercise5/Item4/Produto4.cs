using System.Globalization;

namespace Item4
{
    public class Produto4
    {
        private string _nome; // Properties na linha 23
        public double Preco { get; private set; } // auto Properties
        public int Quantidade { get; private set; }

        public Produto4()
        {
            
        }

        public Produto4(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome;}
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
                
            }
        }

        

        

       
        

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade +
                   " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}