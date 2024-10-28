namespace IterationStatements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintNumbers();
             PrintEveryThirdNumber();
            Console.WriteLine("Enter the 1st number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number: ");
            int num2 = int.Parse(Console.ReadLine());
            bool result = AreNumbersEqual(num1, num2);
            Console.WriteLine(result);
            if (result)
            {
                Console.WriteLine("The numbers are equal.");
            }
            else
            {
                Console.WriteLine("The numbers are not equal.");
            }

            Console.WriteLine("Enter any number to find whether it is Even or Odd");
            int number1 = int.Parse(Console.ReadLine());

            if (IsEven(number1))
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }

            Console.WriteLine("Enter any number to find whether it is IsPositive or IsNegative");
            var numb = int.Parse(Console.ReadLine());
            if (IsPositive(numb))
            {
                Console.WriteLine("Is positive number");
            }
            else
            {
                Console.WriteLine("Is negative number");
            }
            
            Console.WriteLine("Enter the age to check Eligibility ");
            int age = int.Parse(Console.ReadLine());
            if(CanVote(age))
            {
                Console.WriteLine("You are Eligible to Vote");
            }
            else
            {
                Console.WriteLine("You are not Eligible to Vote");
            } 
            Console.WriteLine("Enter any number to find whether the number is within the range -10 to 10");
            int num = int.Parse(Console.ReadLine());
            if (IsInRange(num))
            {
                Console.WriteLine("The number is within the range -10 to 10");
            }
            else
            {
                Console.WriteLine("The number is not within the range -10 to 10");
            }
        
            Console.WriteLine("Enter the integer for the multiplication table:");
            int number = int.Parse(Console.ReadLine());

            DisplayMultiplicationTable(number);
            }
       public static void PrintNumbers()
        {
            Console.WriteLine("Prints all numbers from 1000 down to -1000 to the console");
           for (int i = 1000; i >= -1000; i--)
           {
               Console.WriteLine(i);
           }
        }

    public static void PrintEveryThirdNumber()
        {
            Console.WriteLine("Prints every third number from 3 to 999 to the console");

           for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }
       public static bool AreNumbersEqual(int num1, int num2)
       {
           return num1 == num2;
       }

   public static bool IsEven(int number1)
       {
           return number1 % 2 == 0;
       }
    // 5. Write a method that checks if a given number is positive or negative.
       public static bool IsPositive(int numb)
       {
           return numb > 0;
       }
      static bool CanVote(int age)
       {
           return age >= 18;
       }
      // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.

        static bool IsInRange(int num)
        {
            return num >= -10 && num <= 10;
        }
       

        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
      
        static void DisplayMultiplicationTable(int number)
        {
            number = Math.Abs(number); // Ensure number is positive

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
    }

