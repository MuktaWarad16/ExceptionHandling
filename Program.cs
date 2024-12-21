using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithExc();
            ArrayIndexOutOfBound();
            
        }

        public static void ArithExc()
        {
            
            try
            {
                int num = 0;

                Console.WriteLine(10 / num);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        public static void ArrayIndexOutOfBound()
        {
            try
            {
                int[] nums = { 1, 2, 3, 4, 5 };
                Console.WriteLine(nums[6]);
            }
            catch (Exception e)
            {
                Console.WriteLine( e.Message);
            }
            finally
            {
                Console.WriteLine("always gets executed irrespective of exception occurs or not");
            }
        }

    }
}
