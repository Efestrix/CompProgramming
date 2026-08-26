using System.Text;

namespace CSES_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };
            int[] nums1 = { 0, 1, 1 };
            int[] nums2 = { 0, 0, 0 };

            foreach (var i in ThreeSum(nums))
            {
                foreach (var number in i)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();
            }
        }
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> result = new();

            Array.Sort(nums);


            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                int left = i + 1;
                int right = nums.Length - 1;
                
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (sum < 0)
                        left++;
                    else if (sum > 0)
                        right--;
                    else
                    {
                        result.Add(new List<int>
                        {
                            nums[i],
                            nums[left],
                            nums[right]
                        });

                        left++;
                        right--;

                        while (left < right && nums[left] == nums[left - 1])
                            left++;

                        while (left < right && nums[right] == nums[right + 1])
                            right--;
                    }
                }
            }
            return result;
        }
    }
}
