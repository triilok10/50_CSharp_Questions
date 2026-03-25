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
    }
}