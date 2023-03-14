namespace Edu
{
    public class Methods
    {
        static void Main(string[] args)
        {
            var result = AddTwoNumbers(10);
            //uses the method that has not any ref keyword
            Console.WriteLine(result);

            var number1 = 20;
            AddTwoNumbers(ref number1);
            //uses the ref method. We can also use out keyword for this

            int number2;
            AddTwoNumbersOut(out number2);
            //the difference between ref and out keyword is ref is used with parameters that has values while out is not.
            //we should set the value of variable in the method if the method has parameters with out keyword..

            Add(1, 4, 5, 11);
            //we can easily add more than 2 numbers using only one method with this params implementation
        }

        public static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
        public static int AddTwoNumbers(int number1, int number2 = 20)
        {
            //we can all see the method has its own specified value for number2 variable as 20
            //that is why we can send just one value for sum.
            return number1 + number2;
        }
        public static int AddTwoNumbers(ref int number1, int number2 = 20)
        {
            number1 = 40;
            return number1 + number2;
        }
        public static int AddTwoNumbersOut(out int number1, int number2 = 50)
        {
            number1 = 40;
            return number1 + number2;
        }

        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }


}
