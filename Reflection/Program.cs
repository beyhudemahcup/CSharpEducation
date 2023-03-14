using System;
using System.Collections.Generic;
using System.Reflection;

namespace Reflection
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = TakeTwoNumbers();

            ////I can invoke the method from another class
            var type = typeof(FourOperationsInMath);

            //var instance = Activator.CreateInstance(type, numbers[0], numbers[1]);

            //MethodInfo methodInfo = instance.GetType().GetMethod("Plus");

            //Console.WriteLine("Sum of two number are " + methodInfo.Invoke(instance, null));

            //OperationsWithoutReflections(number1,number2);

            //I can reach the methods,parameters and attributes from another class
            var methods = type.GetMethods();

            foreach (var info in methods)
            {
                Console.WriteLine("Method Name : {0}", info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parameter : {0}",parameterInfo.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}", attribute.GetType().Name);
                }
            }
            Console.ReadLine();
        }

        private static List<int> TakeTwoNumbers()
        {
            Console.WriteLine("Give me the int number for basic math operations");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me the another int number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            List<int> numbers = new List<int>();
            numbers.Add(number1);
            numbers.Add(number2);

            return numbers;
        }

        private static void OperationsWithoutReflections(int number1,int number2)
        {
            FourOperationsInMath fourOperationsInMath =
                new FourOperationsInMath(number1, number2);

            Console.WriteLine("Operations according to the numbers:");
            Console.WriteLine("Plus: " + fourOperationsInMath.Plus());
            Console.WriteLine("Minus: " + fourOperationsInMath.Minus());
            Console.WriteLine("Divided: " + fourOperationsInMath.DividedBy());
            Console.WriteLine("Multiply: " + fourOperationsInMath.Multiply());
        }
    }

    public class FourOperationsInMath
    {
        int _number1;
        int _number2;

        public FourOperationsInMath(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        public int Plus()
        {
            return _number1 + _number2;
        }

        public int Minus()
        {
            int result = _number1 - _number2;
            if (result <= 0 )
            {
                return result * -1;
            }
            else
            return _number1 - _number2;
        }

        public int Multiply()
        {
            return _number1 * _number2;
        }

        //we can have an attribute that attached with DividedBy method
        [MethodName("Dividing")]
        public int DividedBy()
        {
            int result = _number1 / _number2;
            if (result < 1)
            {
                return _number2 / _number1;
            }
            else
            return result;
        }
    }

    public class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string name)
        {
        }
    }
}
