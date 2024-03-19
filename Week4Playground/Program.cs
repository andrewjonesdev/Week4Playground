using Microsoft.Extensions.Logging;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Week4Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> testDictionary = new Dictionary<string, string>();
            testDictionary.Add("Luffy", "Straw Hat Pirates");
            testDictionary.Add("Shanks", "Red Haired Pirates");
            testDictionary.Add("Blackbeard", "Black Beard Pirates");
            testDictionary.Add("Big Mom", "Big Mom Pirates");

            Console.WriteLine(testDictionary["Luffy"]);

            Func<int, int, int> addition = (x, y) => (x + y);
            Func<int, int, int> subtraction = (x, y) => (x - y);
            Func<int, int, int> multiplication = (x, y) => (x * y);
            Func<int, int, int> division = (x, y) => (x / y);
            Func<int, int, int> modulus = (x, y) => (x % y);

            Console.WriteLine(addition(1, 2));
            Dictionary<string, Func<int, int, int>> math = new Dictionary<string, Func<int, int, int>>();
            math.Add("Addition", addition);
            math.Add("Subtraction", subtraction);
            math.Add("Multiplication", multiplication);
            math.Add("Division", division);
            math.Add("modulus", modulus);
            Console.WriteLine(math["Multiplication"](5, 7));

            int x = 100;
            int y = 0;
            int z = 0;
            try
            {
                z = x / y;
                Console.WriteLine(z);
                if (y == 0)
                {
                    Console.WriteLine("This line will never run.");
                }
                else
                {
                    Console.WriteLine("This line will run.");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can’t divide by zero.");
            }
            finally
            {
                Console.WriteLine("This line will always run!");
            }

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Random rnd = new Random();
            int randNum = 0;
            for (int i = 0; i < 15; i++)
            {
                try
                {
                    randNum = rnd.Next(-5, 10);
                    Console.WriteLine(randNum);
                    Console.WriteLine(list[randNum]);
                }
                catch (ArgumentOutOfRangeException ex) when (randNum < 0)
                {
                    Console.WriteLine("The number was less than 0!");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("The number was greater than the range of the array!");
                }
                finally
                {
                    Console.WriteLine("The function will continue.");
                }
            }
            Dictionary<string, long> pirateBounties = new Dictionary<string, long>();
            pirateBounties.Add("Zoro", 111000000);
            pirateBounties.Add("Sanji", 1032000000);
            pirateBounties.Add("Mihawk", 3590000000);
            pirateBounties.Add("Shanks", 4048900000);

           
            try
            {

                int a = 100;
                int b = 0;
                int c = 0;
                if (pirateBounties["Zoro"] > pirateBounties["Sanji"])
                {
                    c = a / b;
                }
                else if (pirateBounties["Mihawk"] < pirateBounties["Shanks"])
                {
                    List<int> newList = new List<int>();
                    newList.Add(1);
                    Console.WriteLine(newList[1]);
                }
            }
            catch (DivideByZeroException divideByZeroException)
            {
                Console.WriteLine("LogError(divideByZeroException)");
            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                Console.WriteLine("LogError(argumentOutOfRangeException)");
            }





        }

        public class Node
        {
            public int value { get; set; }
            public Node address { get; set; }
        }
        public class LinkedList
        {
            public Node head { get; set; }
        }
    }
}
