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
                
                a = n%10;
                n = n / 10;
                if (a == 0)
                {
                    TotalZero++;
                }
            }

            Console.WriteLine($"Total Number of Zero is {TotalZero}");
        }
    }
}