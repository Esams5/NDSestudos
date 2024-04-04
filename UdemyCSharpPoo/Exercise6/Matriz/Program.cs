namespace Matriz
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) //  pecorre as linhas
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) //  pecorre as colunas
                {
                    mat[i, j] = int.Parse(values[j]);

                }
                
            }

            Console.WriteLine("Main diagonal");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");
                
            }

            Console.WriteLine();

            int count = 0;
            
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] < 0 )
                    {
                        count += 1;
                    }
                }
                
            }

            Console.WriteLine("Negative numbers:\n" + count);



        }
    }
}

/*double[,] mat = new double[2, 3];
           Console.WriteLine(mat.Length);
           Console.WriteLine(mat.Rank);
           Console.WriteLine(mat.GetLength(0));
           Console.WriteLine(mat.GetLength(1));
           */