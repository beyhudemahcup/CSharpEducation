using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Threading;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //first method
            //TryCatchExample();

            //we make the same try catch block in the main class to show to the customer 
            //what is the system's problem 
            //TryCatchDemo();

            //in order to write all the catch blocks, we can use delegates for easy reading, manipulating.
            //ActionInstanceDemo();

            Console.WriteLine(Plus(3, 4));

            //Func can return some value but actions can't
            //this is the basic difference between func and actions

            Func<int, int, int> result = Plus;
            Console.WriteLine(result(3, 4));

            Func<int> getRandomNumber = delegate()
            {
                Random random= new Random();
                return random.Next(1,100);
            };

            Console.WriteLine(getRandomNumber());

            //can take another random number by waiting
            Thread.Sleep(10);

            //we can also write func like this
            Func<int> getRandomNumber2 = () => new Random().Next(1,100);

            Console.WriteLine(getRandomNumber2());

            Console.ReadLine();
        }

        static int Plus(int x, int y)
        {
            return x + y;
        }

        private static void ActionInstanceDemo()
        {
            HandleException(() =>
            {
                RecordException();
            });
        }

        private static void TryCatchDemo()
        {
            try
            {
                RecordException();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void RecordException()
        {
            List<string> students = new List<string> { "student 1", "student 2", "student 3" };

            if (students.Contains("student 4"))
            {
                Console.WriteLine("student 4 is available");
            }
            else
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
        }

        private static void TryCatchExample()
        {
            try
            {
                string[] customers = new string[2] { "customer 1", "customer 2" };
                //I accidently wrote 2 as a index of array
                Console.WriteLine(customers[2]);
            }
            catch (Exception e)
            {
                //gives detailed exception messages
                Console.WriteLine(e.InnerException);

                Console.WriteLine(e.Message);
                Console.WriteLine("Exception has throwed");
                Console.ReadLine();
            }
        }
    }
}
