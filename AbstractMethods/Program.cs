
namespace AbstractMethods
{
    public class Program
    {
        static void Main(string[] args)
        {

            //we cannot create an instance from abstract classes.
            //Database db = new Database();

            //in order to create an instance, we should use another class except includes abstract classes.
            Database dbSql = new SqlServer();
            dbSql.Delete();
            
            Database dbOr = new Oracle();
            dbOr.Delete();

        }

        abstract class Database
        {
            public void Add()
            {
                Console.WriteLine("Added by default");
            }
            //abstract classes are the combination of virtual classes and interfaces.
            public abstract void Delete();
            //we can not add any method in there.
            //Every class can make its own method while calling this method.
            //we can say that empty virtual class is the same like abstract class.
        }

        class SqlServer : Database
        {
            public override void Delete()
            {
                Console.WriteLine("deleted by sql");
            }
        }

        class Oracle : Database
        {
            public override void Delete()
            {
                Console.WriteLine("deleted by Oracle");
            }
        }
    }
}