using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayProject();
            //1.arraylist
            //ArrayListProject();
            //2.List
            //ListProject();
            //3.Dictionary
            //DictionaryProject();
            Console.Read();
        }

        private static void DictionaryProject()
        {
            Dictionary<string, string> turkishEnglishDictionary = new Dictionary<string, string>();
            turkishEnglishDictionary.Add("kitap", "book");
            turkishEnglishDictionary.Add("yatak", "bed");
            turkishEnglishDictionary.Add("bilgisayar", "computer");

            //we can see the value of the key that we give in the square brackets
            Console.WriteLine(turkishEnglishDictionary["yatak"]);

            foreach (var word in turkishEnglishDictionary)
            {
                Console.WriteLine(word.Value);
            }

            foreach (var word in turkishEnglishDictionary)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine(turkishEnglishDictionary.ContainsKey("yatak"));//returns true
            Console.WriteLine(turkishEnglishDictionary.ContainsValue("terlik"));//returns false

        }

        private static void ListProject()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Adiyaman");
            cities.Add("Ardahan");

            //we can only add the decided data type once we created the list
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            //we can use different classes as a type
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Customer1" });
            customers.Add(new Customer { Id = 2, FirstName = "Customer2" });

            var count = customers.Count();
            var customer3 = new Customer
            {
                Id = 3,
                FirstName = "Customer3"
            };
            //we can add new customer3 to customers's list
            customers.Add(customer3);
            customers.AddRange(new Customer[2]
            {
                new Customer {Id = 4, FirstName = "Customer4" },
                new Customer {Id = 5, FirstName = "Customer5" }}
            );
            //looking for start and remove just the first data we want to remove
            customers.Remove(customer3);
            //inserting the same data that we removed
            customers.Insert(2, customer3);

            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer name: {customer.FirstName}");
            }

        }

        private static void ArrayProject()
        {
            string[] cities = new string[2] { "izmir", "istanbul" };
            //if I need to add  another city in my cities array, I need to define this array again
            cities = new string[3];
            //now all my data have gone.. Instead of using array we have better options.
        }

        private static void ArrayListProject()
        {   //1. ArrayList 
            ArrayList cities2 = new ArrayList();
            cities2.Add("Ankara");
            cities2.Add("Istanbul");
            cities2.Add("Izmir");
            cities2.Add(1);
            cities2.Add('C');

            foreach (var city in cities2)
            {
                Console.WriteLine(city);
            }
            //we should use foreach to get all the data from arraylist.
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
