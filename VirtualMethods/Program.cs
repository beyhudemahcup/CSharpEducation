
namespace VirtualMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sql sql = new Sql();
            MySql mySql= new MySql();
            
            sql.Add();//overrided add method
            mySql.Add();//default add method

            Console.ReadLine();
        }
    }

    class Database
    {
        //virtual means that can be overrided from another class.
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }
    class Sql : Database {
        public override void Add() {
            Console.WriteLine("Added by Sql");
        }
    }
    class MySql : Database { }
}