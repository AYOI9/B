
        int n = 5;
        int m = 6;
        int[,] matrix = new int[n, m];
        Random rand = new Random();
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = rand.Next(-10, 10);
                if (matrix[i, j] >= -2 && matrix[i, j] <= 3)
                {
                    sum += matrix[i, j];
                }
            }
        }

        Console.WriteLine("Сумма элементов в интервале [-2; 3]: " + sum);
    
