using System.Dynamic;

namespace NactiData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool rerun = true;

            while (rerun)
            {
                Console.WriteLine("Prosím zadejte 3 čísla: ");
                int[] nums = new int[3];

                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write($"Zadejte {i + 1} číslo: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out nums[i])) { }
                    else
                    {
                        Console.WriteLine("Musíte zadat číslo!");
                        i--;
                    }
                }

                int sumOutput = Sum(nums);
                int multiplyOutput = Multiply(nums);
                double calcOutput = Calculate(nums);

                Console.WriteLine("\nSoučet čísel je: " + sumOutput);
                Console.WriteLine("Součin čísel je : " + multiplyOutput);
                Console.WriteLine("Součet prvních dvou čísel dělený třetím je: " + calcOutput);

                Console.Write("\nChcete program spustit znovu? (a/n) ");
                string restartOutput = Console.ReadLine().ToLower();
                if(restartOutput == "n")
                {
                    rerun = false;
                }
                else { }
            }

        }
        static int Sum(int[] nums)
        {
            int result = 0;
            foreach (int i in nums)
            {
                result += i;
            }
            return result;
        }
        static int Multiply(int[] nums)
        {
            int result = 1;
            foreach (int i in nums)
            {
                result *= i;
            }
            return result;
        }
        static double Calculate(int[] nums)
        {
            if (nums[2] == 0)
            {
                Console.WriteLine("Nelze dělit nulou!");
                return double.NaN;
            }
            else
            {
                return (double)(nums[0] + nums[1]) / nums[2];
            }
        }
    }
}
