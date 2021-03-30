using System;

namespace Module_3_Task_5_Vasylchenko
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HomeWork homeWork = new HomeWork();
            Console.WriteLine(homeWork.HomeWorkAsync().GetAwaiter().GetResult());
        }
    }
}
