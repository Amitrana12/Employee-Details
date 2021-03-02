using System;

namespace Employee_Details
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee is present=" + empCheck);
            else
                Console.WriteLine("Employee is absent=" + empCheck);
            Console.ReadKey();
        }
    }
}
