using System.Text;

namespace Strings
{
    class Pogam
    {
        static void Main()
        {
            
            /*Comparar as strings 
            var price = 10.2;
            var texto = "O Preço do produto é " + price;
            var texto = string.Format("O preço do produto é {0} apenas", price);
            var texto = $"O preço do produto é {price}";

            var texto = " estou testando";
            Console.WriteLine(texto.CompareTo("Testando"));
            Console.WriteLine(String.Compare(texto, "Testando", StringComparison.Ordinal));
            
            Console.WriteLine(texto.Contains("testando"));
            Console.WriteLine(texto.Contains("Testando"));
            Console.WriteLine(texto.Contains("Testando", StringComparison.OrdinalIgnoreCase));
            
            Stars e Ends
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.StartsWith("Este"));
            
            Console.WriteLine(texto.EndsWith("teste"));
           
           
           Equals 
           var texto = "Este texto é um teste";
           Console.WriteLine(texto.Equals("Este texto é um teste"));
           
           Índice e métodos adicionais
           
           var texto = "Este texto é um teste";
           Console.WriteLine(texto.IndexOf("é", StringComparison.Ordinal));
           Console.WriteLine(texto.LastIndexOf("s"));
           Console.WriteLine(texto.Insert(5, "Aqui"));
           Console.WriteLine(texto.Remove(5, 5));
           Console.WriteLine(texto.Replace("Este", "Isto"));
           var divisao = texto.Split(" ");
           Console.WriteLine(divisao[0]);

           //var resultao = texto.Substring(5, 5);
           var resultao = texto.Substring(5, texto.LastIndexOf("o"));
           Console.WriteLine(resultao);
           
           Console.WriteLine(texto.Trim()); // remove espaços inúteis*/

            var texto = new StringBuilder();
            texto.Append("Este texto é um teste");
            Console.WriteLine(texto);


        }
    }
}

