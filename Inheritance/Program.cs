
namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer cus = new Customer();
            cus.FirstName();
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public void FirstName(){}
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        //do nothing but inherit
        
    }
}