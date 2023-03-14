
namespace RecapDemo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DatabaseLogger();//db Logger
            //we can use logger prop to take inheritation from different classes!
            customerManager.Logger = new FileLogger();//file Logger
        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; }
        
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer added!");
        }
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine(" Logged to database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine(" Logged to File");
        }
    }
    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to sms");
        }
    }

    interface ILogger
    {
        public void Log();
    }
}