using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDal customerDal = new CustomerDal();
            Customer customer = new Customer();
            customerDal.Add(customer);
            
            //we can see the affects of the [Obsolete] attribute for the next line
            customerDal.AddCustomer(customer);
            Console.ReadLine();
        }
    }

    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }

    }

    class CustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added",
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

        [Obsolete("Use Add method, please")]
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added",
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    //declares that we can only use this attribute for our properties
    [AttributeUsage(AttributeTargets.Property)]
    class RequiredPropertyAttribute : Attribute 
    {
        
    }

    [AttributeUsage(AttributeTargets.Class)]
    //two different targets we can add
    //[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
    class ToTableAttribute : Attribute 
    {
        string _tableName;

        public ToTableAttribute(string _tableName) 
        {
            this._tableName = _tableName;
        }
    }

}
