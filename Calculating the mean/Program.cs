using System;

namespace Calculating_the_mean
{
    class Program
    {
        static void Main(string[] args)
        {
            //------> Представление программы.
            Console.WriteLine("Это программа вычесляет среднее значение чисел!");
            Console.WriteLine("Вы можете ввести максимально 10 чисел");
            Console.WriteLine("Чтобы остановить введение чисел введите \"0\"");
            Console.WriteLine("***ВАЖНО, вводите каждое число через enter***");
            int[] nums = new int[10];
            //------> Цикл получение чисел.
            nums = GetUserNumbers(nums);
            //------> Вычесление среднего значения чисел.
            int meanNum = CalculatingMean(nums);

            Console.WriteLine(meanNum);

        }
        /* ===============================================
         *          Получить Числа Пользователя
         * ===============================================
         * GetUserNumbers
         * 
         * В цикле запрашивает у пользователя 10 чисел, 
         *  в случае введения 0. цикл прерывается.
         *  
         *  Использует переменные:
         *          nums - пустой массив.
        */
        static int[] GetUserNumbers(int [] nums)
        {
            for (int i = 0; i < 10; i++)
            {
                //-----> Запрашивает строку числа, затем конвертирует строку в int.
                nums[i] = int.Parse(Console.ReadLine());
                if (nums[i] == 0) break;
            }
            return nums;
        }
        /* ===============================================
        *          Вычислить среднее число
        * ===============================================
        * CalculatingMean
        * 
        * Вычисляет среднее значение чисел, по формуле ДЗ
        *   (сумма всех чисел суммируется, затем делится на 3).
        *  
        *  Использует переменные:
        *          nums - массив чисел, введенные пользователем.
       */
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
