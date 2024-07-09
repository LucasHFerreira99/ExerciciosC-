namespace ExMatriz
{
    class Program
    {
        public static void Main(string[] args)
        {
            int m, n;

            string[] tamanho = Console.ReadLine().Split(' ');
            m = int.Parse(tamanho[0]);
            n = int.Parse(tamanho[1]);

            int[,] matriz = new int[m, n];


            for (int i = 0; i < m; i++)
            {
                string[] linhaMatriz = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(linhaMatriz[j]);
                }
            }
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i,j] == x) {

                        Console.WriteLine($"Position {i},{j}:");
                        if(j>0)
                        {
                            Console.WriteLine("Left: " + matriz[i,j-1]);
                        }
                        if(j < n-1)
                        {
                            Console.WriteLine("Right: " + matriz[i,j+1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i-1,j]);
                        }
                        if(i < n-1)
                        {
                            Console.WriteLine("Down: " + matriz[i+1,j]);
                        }
                    }
                }
            }


        }
    }
}