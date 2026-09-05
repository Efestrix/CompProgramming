using System.Text;

namespace CSES_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -1, 0, 3, 5, 9, 12 };
            int target = 2;

            Console.WriteLine(binarySearch(arr, target));
        }

        static int binarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}
