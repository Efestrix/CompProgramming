using System.Text;
using System.Xml.XPath;

namespace CSES_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 7, 7, 8, 8, 10 };
            int target = 8;

            int[] result = SearchRange(nums, target);

            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
        }

        public static int[] SearchRange(int[] nums, int target)
        {
            int first = FindFirstOccurrence(nums, target);
            if (first == -1)
                return new int[] { -1, -1 };

            int last = FindLastOccurrence(nums, target);
            return new int[] { first, last };
        }
        static int FindFirstOccurrence(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int result = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    result = mid;
                    right = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }
        static int FindLastOccurrence(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int result = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    result = mid;
                    left = mid + 1;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }
    }
}
