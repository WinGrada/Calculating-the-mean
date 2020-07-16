using System;

namespace Calculating_the_mean
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            // цикл получение чисел
            nums = GetUserNumbers(nums);
            int meanNum = CalculatingMean(nums);
            Console.WriteLine(meanNum);

        }

        static int[] GetUserNumbers(int [] nums)
        {
            for (int i = 0; i < 10; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
                if (nums[i] == 0) break;
            }
            return nums;
        }
        static int CalculatingMean(int [] nums )
        {
            int totalNum = 0;
            foreach (int num in nums)
            {
                totalNum += num;
            }
            totalNum /= 3;

            return totalNum;
        }
    }
}
