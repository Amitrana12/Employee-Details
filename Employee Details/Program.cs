using System;

namespace Employee_Details
{
    class Program
    {
       
        static void Main(String[] args)
        {

            Empwage google = new Empwage("Google", 20, 2, 10);
            Empwage vipro = new Empwage("Vipro", 10, 4, 20);
            google.computeEmpWage();
            vipro.computeEmpWage();
            Console.WriteLine(google.toString());
            Console.WriteLine(vipro.toString());
        }
    }
}
