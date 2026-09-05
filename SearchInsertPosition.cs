using System.Text;

namespace CSES_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 7;

            Console.WriteLine(SearchInsert(nums, target));
        }

        static int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    return i;
                else if (nums[i] > target)
                    return i;
                else if (nums[i] < target && i == nums.Length - 1)
                    return i + 1;
            }
            return -1;
        }
    }
}
