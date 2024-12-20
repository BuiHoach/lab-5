using System.Text;

namespace lab_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Khởi tạo mảng 1 chiều số nguyên gồm 10 phần tử
            int[] array = { 5, -7, 12, 9, -3, 4, -10, 15, 2, -6 };
            Console.WriteLine("Mảng ban đầu:");
            PrintArray(array);

            // Tìm phần tử nhỏ nhất
            int min = array.Min();
            Console.WriteLine($"\nPhần tử nhỏ nhất: {min}");

            // Đảo ngược mảng
            int[] reversedArray = array.Reverse().ToArray();
            Console.WriteLine("\nMảng sau khi đảo ngược:");
            PrintArray(reversedArray);

            // Sắp xếp mảng tăng dần
            int[] sortedAscending = array.OrderBy(x => x).ToArray();
            Console.WriteLine("\nMảng sau khi sắp xếp tăng dần:");
            PrintArray(sortedAscending);

            // Sắp xếp mảng giảm dần
            int[] sortedDescending = array.OrderByDescending(x => x).ToArray();
            Console.WriteLine("\nMảng sau khi sắp xếp giảm dần:");
            PrintArray(sortedDescending);

            // Tìm phần tử là số nguyên tố
            Console.WriteLine("\nCác phần tử là số nguyên tố:");
            foreach (int number in array)
            {
                if (IsPrime(number))
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();

            // Tìm số lượng các số dương liên tiếp nhiều nhất
            int maxConsecutivePositive = FindMaxConsecutivePositive(array);
            Console.WriteLine($"\nSố lượng các số dương liên tiếp nhiều nhất: {maxConsecutivePositive}");

            // Tính trung bình cộng các phần tử dương
            double averagePositive = array.Where(x => x > 0).Average();
            Console.WriteLine($"\nTrung bình cộng các phần tử dương: {averagePositive:F2}");

            // Kiểm tra xem mảng có phải chứa các phần tử âm dương đan xen không
            bool isAlternating = CheckAlternatingSigns(array);
            Console.WriteLine($"\nMảng có chứa các phần tử âm dương đan xen: {isAlternating}");
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        static int FindMaxConsecutivePositive(int[] array)
        {
            int maxCount = 0, currentCount = 0;
            foreach (int number in array)
            {
                if (number > 0)
                {
                    currentCount++;
                    maxCount = Math.Max(maxCount, currentCount);
                }
                else
                {
                    currentCount = 0;
                }
            }
            return maxCount;
        }

        static bool CheckAlternatingSigns(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] * array[i - 1] > 0) // Cùng dấu
                {
                    return false;
                }
            }
            return true;
        }
    }
}
