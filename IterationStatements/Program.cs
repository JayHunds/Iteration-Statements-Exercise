namespace IterationStatements
{
    public class Program
    { 
        static void PrintNumbersFrom1000ToNegative1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // Method to print numbers from 3 to 999 by 3 each time
        static void PrintNumbersFrom3To999By3()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        // Method to check if two numbers are equal
        static void CheckEquality(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("Numbers are equal.");
            }
            else
            {
                Console.WriteLine("Numbers are not equal.");
            }
        }

        // Method to check if a number is even or odd
        static void CheckEvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even.");
            }
            else
            {
                Console.WriteLine("Number is odd.");
            }
        }

        // Method to check if a number is positive or negative
        static void CheckPositiveOrNegative(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("Number is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine("Number is negative.");
            }
            else
            {
                Console.WriteLine("Number is zero.");
            }
        }

        // Method to check voting eligibility based on age
        static void CheckVotingEligibility(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("Candidate can vote.");
            }
            else
            {
            }
            Console.WriteLine("Candidate cannot vote.");

            // Method to check if an interger is in the range -10 to 10
            static void CheckRange(int number)
            {
                if (number >= -10 && number <= 10)
                {
                    Console.WriteLine($"The number {number} is in the range -10 to 10.");
                }
                else
                {
                    Console.WriteLine($"The number {number} is not in the range -10 to 10.");
                }
            }

            // Method to display the multiplication table of a given integer
            static void DisplayMultiplicationTable(int number)
            {
                Console.WriteLine($"Multiplication table of {number}:");
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}");
                }



                //Call the methods to test them in the Main method below
                static void Main(string[] args)
                {
                    PrintNumbersFrom1000ToNegative1000();

                    PrintNumbersFrom3To999By3();

                    CheckEquality(5, 5);

                    CheckEvenOrOdd(10);

                    CheckPositiveOrNegative(-5);

                    CheckVotingEligibility(18);

                    CheckRange(-5);

                    DisplayMultiplicationTable(7);
                }
            }
        }
    }
}
       