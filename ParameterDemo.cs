namespace Week4Practical
{
    class ParameterDemo
    {
        public void Increase(ref int number)
        {
            number = number + 10;
        }

        public void GetFullName(out string fullname)
        {
            fullname = "Nelson Mandela";
        }

        public int SumAll(params int[] numbers)
        {
            int sum = 0;

            foreach (int num in numbers)
            {
                sum = sum + num;
            }

            return sum;
        }
    }
}
