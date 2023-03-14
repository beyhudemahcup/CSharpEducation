using System;
using System.Collections.Generic;
using System.Security.Permissions;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //we can also create generic methods 
            Utilities utilities = new Utilities();
            List<string> names = utilities.BuildList<string>("name1", "name2");

            List<Customer> customers =
                utilities.BuildList<Customer>(
                    new Customer { IdentityNumber = 1, FirstName = "First1", LastName = "Last1" },
                    new Customer { IdentityNumber = 2, FirstName = "First2", LastName = "Last2" });

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            foreach (var customer in customers)
            {
                //two different attribute I can show. Both give the same results.
                //Console.WriteLine($"Customers : {customer.IdentityNumber}, {customer.FirstName} {customer.LastName}");
                Console.WriteLine("Customers : {0}, {1} {2}", customer.IdentityNumber, customer.FirstName, customer.LastName);
            }
            Console.ReadLine();

        }
    }
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    interface IProductDal : IRepository<Product>
    {
        void BestProductForMonth(Product product);
    }

    class Product
    {
    }
    class Customer
    {
        public int IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public void BestProductForMonth(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new System.NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new System.NotImplementedException();
        }

        public void CustomerOfTheMonth(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Customer GetProduct(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new System.NotImplementedException();
        }
    }
    interface ICustomerDal : IRepository<Customer>
    {
        void CustomerOfTheMonth(Customer customer);
    }

    //I can add a generic constraint at the end of the generic Repository
    interface IRepository<T> where T : class, new()
    {//which means I only use reference types with IRepository 
        List<T> GetAll();
        T GetProduct(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}

