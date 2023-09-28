using LeetCode.Functions;
using System;

namespace Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Hello type the problem code!");
                int code = Int32.Parse(Console.ReadLine());

                switch (code)
                {
                    case 1689:
                        Console.WriteLine("Partitioning Into Minimum Number Of Deci - Binary Numbers");
                        Console.WriteLine("Type the initial value:");
                    
                        string input1689 = Console.ReadLine();
                        Console.WriteLine("Result: " + new StringProblems().MinPartitions(input1689));

                        break;
                    case 1108:
                        Console.WriteLine("Defanging an IP Address");
                        Console.WriteLine("Type the initial address:");

                        string address1108 = Console.ReadLine();
                        Console.WriteLine("Result: " + new StringProblems().DefangIPaddr(address1108));

                        break;
                    case 2011:
                        Console.WriteLine("Final Value of Variable After Performing Operations");
                        Console.WriteLine("Type the initial array serating the values by spaces:");

                        string input2011 = Console.ReadLine();
                        string[] array2011 = input2011.Split(' ');
                        Console.WriteLine("Result: " + new StringProblems().FinalValueAfterOperations(array2011));

                        break;
                    case 771:
                        Console.WriteLine("Jewels and Stones");
                        Console.WriteLine("Type the Jewels values:");
                        string jewels = Console.ReadLine();

                        Console.WriteLine("Type the Stones values:");
                        string stones = Console.ReadLine();

                        Console.WriteLine("Result: " + new StringProblems().NumJewelsInStones(jewels, stones));

                        break;
                }
            }while(true);
        }
    }
}
