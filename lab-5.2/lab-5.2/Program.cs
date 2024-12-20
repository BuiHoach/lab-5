using System.Text;

namespace lab_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Khai báo và khởi tạo mảng 2 chiều 4x4
            int[,] matrix = {
            { 10, 7, 12, 4 },
            { 9, 14, 21, 6 },
            { 8, 2, 18, 5 },
            { 1, 3, 16, 11 }
        };

            Console.WriteLine("Mảng ban đầu:");
            PrintMatrix(matrix);

            // Tính tổng các phần tử mà chỉ số hàng bằng chỉ số cột
            int diagonalSum = CalculateDiagonalSum(matrix);
            Console.WriteLine($"\nTổng các phần tử trên đường chéo chính: {diagonalSum}");

            // In ra các phần tử nhỏ nhất trên từng cột
            Console.WriteLine("\nPhần tử nhỏ nhất trên từng cột:");
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int minInColumn = FindMinInColumn(matrix, col);
                Console.WriteLine($"Cột {col + 1}: {minInColumn}");
            }

            // Liệt kê các phần tử chia hết cho 7
            Console.WriteLine("\nCác phần tử chia hết cho 7:");
            foreach (var number in matrix)
            {
                if (number % 7 == 0)
                    Console.Write(number + " ");
            }
            Console.WriteLine();

            // Tính tổng các phần tử nằm trên đường viền của mảng
            int borderSum = CalculateBorderSum(matrix);
            Console.WriteLine($"\nTổng các phần tử nằm trên đường viền của mảng: {borderSum}");

            // Chuyển thành mảng 1 chiều rồi sắp xếp tăng dần
            int[] flattenedArray = FlattenAndSortMatrix(matrix);
            Console.WriteLine("\nMảng 1 chiều sau khi chuyển đổi và sắp xếp tăng dần:");
            Console.WriteLine(string.Join(", ", flattenedArray));
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int CalculateDiagonalSum(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }
            return sum;
        }

        static int FindMinInColumn(int[,] matrix, int col)
        {
            int min = int.MaxValue;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, col] < min)
                    min = matrix[row, col];
            }
            return min;
        }

        static int CalculateBorderSum(int[,] matrix)
        {
            int sum = 0;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Cộng các phần tử trên các đường viền
            for (int col = 0; col < cols; col++)
            {
                sum += matrix[0, col]; // Hàng đầu tiên
                sum += matrix[rows - 1, col]; // Hàng cuối cùng
            }
            for (int row = 1; row < rows - 1; row++)
            {
                sum += matrix[row, 0]; // Cột đầu tiên
                sum += matrix[row, cols - 1]; // Cột cuối cùng
            }

            return sum;
        }

        static int[] FlattenAndSortMatrix(int[,] matrix)
        {
            int[] flattenedArray = matrix.Cast<int>().ToArray();
            Array.Sort(flattenedArray);
            return flattenedArray;
        }
    }
}
