namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void printNumbers1000()
        
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        public static void upbyThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
              Console.WriteLine(i);  
            }  
        }
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        public static void TwonumbersSame(int numOne, int numTwo)
        {
            if (numOne == numTwo)
            {
                Console.WriteLine($"{numOne} and {numTwo} are the same");
            }
            else
            {
                  Console.WriteLine($"{numOne} and {numTwo} are not the same");
            }
        }
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.

        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"Even");
            }
            else
            {
                Console.WriteLine($"Odd");
            }
        }
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.

        public static void isPositive(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (number == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.

        public static void CanVote()
        {
            Console.WriteLine("Please enter your age");
            var canParse = int.TryParse(Console.ReadLine(), out int userAge);
            while (canParse == false)
            {
                Console.WriteLine("Please enter a valid age");
                canParse = int.TryParse(Console.ReadLine(), out int userage);
            }

            if (userAge >= 18)
            {
                Console.WriteLine($"Congrats, {userAge} is old enough to vote!");
            }
            else
            {
                Console.WriteLine($"Sorry, {userAge} is not old enough to vote!");
            }
        }
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        public static void TenRange()
        {
            Console.WriteLine("Please give me a number");
            var canParse = int.TryParse(Console.ReadLine(), out int usernumber);

            while (!canParse)
            {
                Console.WriteLine("Please give a valid number");
                canParse = int.TryParse(Console.ReadLine(), out usernumber);
            }
            {
                Console.WriteLine("Please give me a valid number");
                canParse = int.TryParse(Console.ReadLine(), out int userNumber);
            }
            if (usernumber <= 10 && usernumber >= -10)
            {
                Console.WriteLine($"{usernumber} is in the ten range in the ten range!");
            }
            else
            {
                Console.WriteLine($"{usernumber} is not in the ten range in the ten range!");
            }
        }
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        public static void MultiplyThroughTwelve(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {number} = {number * i}");
            }
        }
        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            //printNumbers1000();
            //upbyThree();
            //TwonumbersSame(1, 2);
            //EvenOrOdd(2);
            //isPositive(2);
            //CanVote();
            //TenRange();
            MultiplyThroughTwelve(12);
        }
    }
}
