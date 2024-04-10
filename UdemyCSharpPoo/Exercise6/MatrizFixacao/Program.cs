namespace MatrizFixacao
{
    class Program
    {
        static void Main()
        {

            string[] tam = Console.ReadLine().Split(' ');
            int m = int.Parse(tam[0]);
            int n = int.Parse(tam[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split();

                for (int j = 0; j < n ; j++)
                {

                    mat[i, j] = int.Parse(values[j]);

                }
                
            }

            Console.WriteLine("Matriz");
            
            for (int i = 0; i < m; i++) //  pecorre as linhas
            {
                

                for (int j = 0; j < n; j++) //  pecorre as colunas
                {
                    Console.Write(mat[i, j] + " ");

                }

                Console.WriteLine();
                
            }

            Console.WriteLine();

            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");
            
            for (int i = 0; i < m; i++) //  pecorre as linhas
            {
                
                for (int j = 0; j < n; j++) //  pecorre as colunas
                {
                    if (mat[i, j] == num)
                    {
                        Console.WriteLine("Position: " + i +  "," + j);

                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j-1]);
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("Up: " +mat[ i - 1, j]);
                        }

                        if (j < n -1 )
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }

                        if (i < m -1 )
                        {
                            Console.WriteLine("Down: " + mat[i+1, j]);
                        }
                        
                        
                    }

                    Console.WriteLine();

                }

                
                
            }




        }
    }
}

