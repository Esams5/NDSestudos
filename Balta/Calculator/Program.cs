namespace Calculator
{
    class Progam
    {
        static void Main(string[] args)
        {
            Menu();
            
        }

        static void Menu()
        {
            Console.Clear();
            
            Console.WriteLine("-----------");
            Console.WriteLine("Escolha uma das opções: \n 1-Soma \n 2-Subtração \n 3-Divisão \n 4-Multiplicação \n 5-Sair");
            Console.WriteLine("-----------");

            short op = short.Parse(Console.ReadLine());
           

            switch (op)
            {
                case 1: 
                    Soma();
                break;
                case 2:
                    Subtracao();
                break;
                case 3:
                    Divisao();
                break;
                case 4:
                    Multiplicacao();
                break;
                case 5:
                    System.Environment.Exit(0);
                break;    
                default:
                    Menu();
                break;    
                    
                
            }

            

        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float num2 = float.Parse((Console.ReadLine()));

            float soma = num1 + num2;
            
            Console.WriteLine($"O resultado da Soma é {soma}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o 1 valor: ");
            float num1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o 2 valor: ");
            float num2 = float.Parse(Console.ReadLine());

            float sub = num1 - num2;
            
            Console.WriteLine($"O resultado da Subtração é {sub}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro valor: "); 
            float num1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o 2 valor: ");
            float num2 = float.Parse(Console.ReadLine());

            float divisao = num1 / num2;
            
            Console.WriteLine($"O valor da divisão é {divisao}");
            Console.ReadKey();
            Menu();

        }

        static void Multiplicacao()
        {
            Console.Clear();
            
            Console.WriteLine("Digite o 1 valor: ");
            float num1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o 2 valor: ");
            float num2 = float.Parse(Console.ReadLine());

            float multi = num1 * num2;
            
            Console.WriteLine($"O resultado da Multiplicação é {multi}");
            Console.ReadKey();
            Menu();
        }
    }
}