namespace Week4Practical
{
    class Calculator
    {
        public void PrintWelcome()
        {
            Console.WriteLine("Welcome to the Calculator");
        }

        public int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public int Multiply(int num1, int num2 = 1)
        {
            int product = num1 * num2;
            return product;
        }
    }
}
