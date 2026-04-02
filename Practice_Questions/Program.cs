using System.IO.Pipelines;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;

namespace test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program obj = new Program();
            obj.PrintNumber(100);
            obj.PrintNumberDecending(100);
            obj.DivisibleByTwo(10);
            obj.SumAllCharacter(111);
            obj.ReverseIntNumber(123);
            obj.CountSpecificDigit(123440, 4);
            obj.ReverseAlphanumeric("Trilok");
            obj.ReverseAlphanumeric2("Trilok");
            obj.SumTargetNumber(987690, 15);
            obj.SumAnyTargetNumber(987610, 15);
            obj.DuplicateArray(1232678901);
            obj.BiggestNumber(1232678901);
            obj.NonRepeatingCharacter(1234123567);
            obj.SecondMaxCharacter(1234123798);
            obj.SmallestNumber(1234123798);
            obj.CountEvenOdd(222213579);
            obj.CheckArmStrongNumber(153);
            obj.SumOfEvenDigit(1532468);
            obj.PalindromeNumber(121);
            obj.CountTotalZero(120001);
            obj.ProductOfAllDigit(122421);
            obj.CountVowelsAndConsonants("AEIOUSJDBFJSacdc");
            obj.RemovingSpacesFromString("AE I OU    SJ DBF JSacdc");
            obj.FizzBuzz();
            obj.PrimeNumber(7);
            obj.Fibonacci(100);
            obj.divisorssum(28);
            obj.GCD(6, 8);
            obj.PowerWithoutMath(2, 3);
            obj.DigitalRoot(493);
        }

        // Print Number 1 to N in Asending
        public void PrintNumber(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Print for " + i);
            }
        }

        // Print Number 100 to 1 in descending
        public void PrintNumberDecending(int n)
        {
            for (int i = n; i >= 0; i--)
            {
                Console.WriteLine("Print for " + i);
            }
        }

        // Check that 2 is visible or not
        public void DivisibleByTwo(int a)
        {
            for (int i = 0; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Yes" + i);
                }
                else
                {
                    Console.WriteLine("No ");
                }
            }
        }

        //  Sub All Numbers
        public int SumAllCharacter(int n)
        {
            int y = 0;
            n = Math.Abs(n);

            while (n > 0)
            {
                int lastDigit = n % 10;
                y += lastDigit;
                n = n / 10;
            }

            Console.WriteLine("Total Sum is " + y);
            return y;
        }

        // Reverse A Number
        public void ReverseIntNumber(int n)
        {
            int x = 0;
            n = Math.Abs(n);


            while (n > 0)
            {
                int lastDigit = n % 10;
                x = (x * 10) + lastDigit;
                n = n / 10;
            }

            Console.WriteLine("Reversed Number: " + x);
        }

        // Count Specific Digit
        public void CountSpecificDigit(int n, int y)
        {
            int x = 0;
            n = Math.Abs(n);
            while (n > 0)
            {
                int lastDigit = n % 10;
                n = n / 10;
                if (lastDigit == y)
                {
                    x++;
                }
            }
            Console.WriteLine($"Total Sum is {y} and Reversed Number is {x}");
        }

        // Reverse Alphanumeric String

        public string ReverseAlphanumeric(string n)
        {
            string x = "";

            for (int i = n.Length - 1; i >= 0; i--)
            {
                x += n[i];
            }
            Console.WriteLine("Reverse String " + x);
            return x;
        }

        public string ReverseAlphanumeric2(string n)
        {
            char[] arr = n.ToCharArray();

            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }

            string result = new string(arr);
            Console.WriteLine("Reverse String " + result);
            return result;
        }

        // Find the two numbers that sum to TARGET
        public void SumTargetNumber(int x, int target)
        {
            char[] c = x.ToString().ToCharArray();

            int left = 0;
            int right = c.Length - 1;

            while (left < right)
            {
                int leftVal = c[left] - '0';
                int rightVal = c[right] - '0';

                int sum = leftVal + rightVal;

                if (sum == target)
                {
                    Console.WriteLine($"Pair found: {leftVal} + {rightVal} = {target}");
                    return;
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            Console.WriteLine("No pair found");
        }

        public void SumAnyTargetNumber(int x, int target)
        {
            char[] digits = x.ToString().ToCharArray();
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < digits.Length; i++)
            {
                int num = digits[i] - '0';
                int diff = target - num;

                if (set.Contains(diff))
                {
                    Console.WriteLine($"Pair found: {diff} + {num} = {target}");
                    return;
                }

                set.Add(num);
            }

            Console.WriteLine("No pair found");
        }

        // Find Duplicate in the Array
        public void DuplicateArray(int x)
        {
            char[] c = x.ToString().ToCharArray();
            HashSet<int> set = new HashSet<int>();
            HashSet<int> DuplicateSet = new HashSet<int>();

            for (int i = 0; i < c.Length; i++)
            {
                int num = c[i] - '0';


                if (set.Contains(num))
                {
                    DuplicateSet.Add(num);
                }
                else
                {
                    set.Add(num);
                }
            }

            Console.WriteLine("Non Repatating is: " + string.Join(", ", set));
        }

        // Find the Biggest Number
        public void BiggestNumber(int n)
        {
            char[] c = n.ToString().ToCharArray();
            int biggest = 0;

            for (int i = 0; i < c.Length; i++)
            {
                int digit = c[i] - '0';

                if (digit > biggest)
                {
                    biggest = digit;
                }
            }

            Console.WriteLine($"Biggest Number {biggest}");
        }

        // Check Non Repeating Character

        public void NonRepeatingCharacter(int n)
        {
            char[] c = n.ToString().ToCharArray();

            HashSet<int> seen = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();

            foreach (char ch in c)
            {
                int digit = ch - '0';

                if (!seen.Add(digit))
                {
                    duplicates.Add(digit);
                }
            }


            List<int> result = new List<int>();

            foreach (char ch in c)
            {
                int digit = ch - '0';

                if (!duplicates.Contains(digit))
                {
                    result.Add(digit);
                }
            }

            Console.WriteLine("Non Repeating Characters: " + string.Join(", ", result));
        }

        // Second Max Character
        public void SecondMaxCharacter(int n)
        {
            char[] c = n.ToString().ToCharArray();
            int firstBiggest = -1;
            int secondBiggest = -1;

            foreach (char ch in c)
            {
                int digit = ch - '0';
                if (digit > firstBiggest)
                    firstBiggest = digit;
            }

            foreach (char ch in c)
            {
                int digit = ch - '0';
                if (digit > secondBiggest && digit < firstBiggest)
                    secondBiggest = digit;
            }

            if (secondBiggest == -1)
                Console.WriteLine("No second biggest digit exists.");
            else
                Console.WriteLine($"Second Biggest Digit: {secondBiggest}");
        }

        //  Smallest Digit
        public void SmallestNumber(int n)
        {
            char[] c = n.ToString().ToCharArray();

            int SmallestNumber = 9;

            foreach (char ch in c)
            {
                int digit = ch - '0';

                if (digit < SmallestNumber)
                {
                    SmallestNumber = ch - '0';
                }
            }
            Console.WriteLine("Smallest  digit exists " + SmallestNumber);
        }

        // Count Even and Odd Digit
        public void CountEvenOdd(int n)
        {
            char[] c = n.ToString().ToCharArray();

            int EvenCount = 0;
            int OddCount = 0;

            foreach (char ch in c)
            {
                int digit = ch - '0';
                if (digit % 2 == 0)
                {
                    EvenCount++;
                }
                else
                {
                    OddCount++;
                }
            }

            Console.WriteLine($"Total Odd Count is {OddCount} and Even Count is {EvenCount}");
        }

        // Check Armstrong Number
        public void CheckArmStrongNumber(int n)
        {
            char[] c = n.ToString().ToCharArray();
            int Total = 0;

            if (n > 0)
            {
                foreach (char ch in c)
                {
                    int digit = ch - '0';
                    Total += (int)Math.Pow(digit, c.Length);
                }
            }

            if (Total == n)
            {
                Console.WriteLine($"{n} is the Armstrong Number");
            }
            else
            {
                Console.WriteLine($"{n} is the Not Armstrong Number");
            }
        }

        //Sum of Even Digits Only
        public void SumOfEvenDigit(int n)
        {
            char[] c = n.ToString().ToCharArray();

            int EvenSum = 0;

            foreach (var item in c)
            {
                int digit = item - '0';

                if (digit % 2 == 0)
                {
                    EvenSum += digit;
                }
            }

            Console.WriteLine($"{EvenSum} is the Total Sum of EvenNumber");
        }

        //Palindrome Number 

        public void PalindromeNumber(int n)
        {
            char[] c = n.ToString().ToCharArray();
            List<int> set = new List<int>();

            int right = c.Length - 1;

            while (right >= 0)
            {
                int dight = c[right] - '0';
                set.Add(dight);
                right--;
            }

            int reversed = 0;

            foreach (int digit in set)
            {
                reversed = reversed * 10 + digit;
            }

            if (n == reversed)
            {
                Console.WriteLine($"{n} is Palindrome");
            }
            else
            {
                Console.WriteLine($"{n} is NOT Palindrome");
            }
        }

        // Count Total Number of Zeros
        public void CountTotalZero(int n)
        {
            n = Math.Abs(n); // handle negatives
            int TotalZero = 0;
            int a = 9;

            if (n == 0)
            {
                Console.WriteLine("Total Number of Zeros is 1");
                return;
            }

            while (n > 0)
            {

                a = n % 10;
                n = n / 10;
                if (a == 0)
                {
                    TotalZero++;
                }
            }

            Console.WriteLine($"Total Number of Zero is {TotalZero}");
        }

        // Product of All Digits — Multiply all digits of a number together.

        public void ProductOfAllDigit(int n)
        {
            n = Math.Abs(n);
            int TotalProduct = 1;
            int LastDigit = 1;
            if (n == 0)
            {
                Console.WriteLine("Total Number of All Product is 0");
                return;
            }

            while (n > 0)
            {
                LastDigit = n % 10;
                n = (n / 10);
                if (LastDigit == 0)
                {
                    Console.WriteLine("Total Number of All Product is 0");
                    return;
                }
                else
                {
                    TotalProduct *= LastDigit;
                }


            }
            Console.WriteLine($"Total Number of All Product is {TotalProduct}");
        }


        // Count vowels & consonants
        public void CountVowelsAndConsonants(string input)
        {

            List<char> vowelList = new List<char>();
            List<char> consonantList = new List<char>();

            string vowels = "aeiouAEIOU";

            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    if (vowels.Contains(ch))
                    {
                        vowelList.Add(ch);
                    }
                    else
                    {

                        consonantList.Add(ch);
                    }
                }
            }

            Console.WriteLine($"Vowels ({consonantList.Count()}): {string.Join(", ", vowelList)}");
            Console.WriteLine($"Consonants ({consonantList.Count()}): {string.Join(", ", consonantList)}");
        }


        public void RemovingSpacesFromString(string input)
        {
            List<char> result = new List<char>();
            int whiteSpaces = 0;

            foreach (char ch in input)
            {
                if (ch == ' ')
                {
                    whiteSpaces++;
                }
                else
                {
                    result.Add(ch);
                }
            }

            Console.WriteLine($"Result: {new string(result.ToArray())}");
            Console.WriteLine($"Length After Removing Spaces: {result.Count}");
            Console.WriteLine($"Total Spaces: {whiteSpaces}");
        }



        // FizzBuzz Variant — Print numbers 1–100, but multiples of 3 print "Fizz", multiples of 5 print "Buzz", multiples of both print "FizzBuzz", multiples of 7 print "Whiz"

        public void FizzBuzz()
        {
            int n = 100;
            if (n <= 0)
            {
                Console.WriteLine("Number must be greater then 0");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }


                if (i % 7 == 0)
                {
                    Console.WriteLine("Whiz");
                }


            }
        }

        //Prime Number Check — Check if a number is prime, then print all primes up to N
        public bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        public void PrimeNumber(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Number must be greater than 0");
                return;
            }

            if (IsPrime(n))
                Console.WriteLine($"{n} is a Prime Number");
            else
                Console.WriteLine($"{n} is NOT a Prime Number");
            Console.WriteLine($"{n} is NOT a Prime Number");
            Console.Write($"All primes up to {n}: ");
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                    Console.Write(i + " ");
            }
        }


        // Print Fibonacci Series
        public void Fibonacci(int n)
        {
            List<int> set = new List<int>();
            int a = 0;
            int b = 0;
            if (n <= 0)
            {
                Console.WriteLine("Number must be greater then 0");
                return;
            }

            for (int i = 0; i < n; i++)
            {

                if (i > 1)
                {
                    a = set[i - 1];
                    b = set[i - 2];
                    set.Add(a + b);
                }
                else
                {
                    set.Add(i);
                }
            }
            Console.WriteLine($"Fibonacci Series: {string.Join(", ", set)}");
        }

        //Perfect Number — A number whose divisors sum equals itself (e.g., 28 = 1+2+4+7+14)

        public void divisorssum(int n)
        {
            int sum = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == n)
            {
                Console.WriteLine($"Yes, Perfect Divisor, {n} ");
            }
            else
            {
                Console.WriteLine($"Not a Perfect Divisor, {n} ");
            }
        }


        // GCD  — Find Greatest Common Divisor of two numbers
        public void GCD(int x, int y)
        {
            if (x <= 0 || y <= 0)
            {
                Console.WriteLine("Numbers must be greater than 0");
                return;
            }

            int min;

            if (x < y)
                min = x;
            else
                min = y;

            int gcd = 1;

            for (int i = 1; i <= min; i++)
            {
                if (x % i == 0 && y % i == 0)
                {
                    gcd = i;
                }
            }

            // Lowest Common Factor;
            int LCM = 0;
            LCM = (x * y) / gcd;


            Console.WriteLine($"GCD is: {gcd}");
            Console.WriteLine($"LCM is: {LCM}");
        }

        //Power Without Math.Pow — Implement your own power function using loops
        public void PowerWithoutMath(int n, int p)
        {
            int Pow = 1;
            for (int i = 1; i <= p; i++)
            {
                Pow *= n;
            }

            Console.WriteLine($"Power is {Pow}");
        }

        // Digital Root — Keep summing digits until you get a single digit(e.g., 493 → 16 → 7)
        public int DigitalRoot(int n)
        {
            n = Math.Abs(n);

            while (n >= 10)
            {
                int sum = 0;
                while (n > 0)
                {
                    sum += n % 10; 
                    n /= 10;       
                }
                n = sum;
            }

            return n;
        }
    }
}