using System;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            //we can call methods with creating a delegate 
            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.SendMessage;
            //myDelegate.Invoke();
            myDelegate();

            Console.WriteLine("----------------------");

            //delegates has a limitation which is if you send a parameter with delegate, 
            //delegate will be use the same parameter at the different methods
            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            myDelegate2("This message comes from delegate2");
            Console.WriteLine("----------------------");

            Math math = new Math();
            MyDelegate3 myDelegate3 = math.Plus;
            myDelegate3 += math.Multiply;
            
            var resultFromSum = myDelegate3(4, 3);
            var resultFromMultiply = myDelegate3(4, 3);
            Console.WriteLine(resultFromSum);//I expect 7 as a result
            //but I see 12 (4*3) because delegates return the last method's result,
            //if there is have plenty of methods
            Console.WriteLine(resultFromMultiply);//I expect 12 as a result

            Console.ReadLine();
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hi,there!!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!!");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    public class Math
    {
        public int Plus(int number1, int number2)
        {
            return number1 + number2;
        }
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
