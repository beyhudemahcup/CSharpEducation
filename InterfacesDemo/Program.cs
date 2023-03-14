namespace InterfacesDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    //in this example, we have three different worker type as a manager, worker, and robots.
    //now, let's create interface and classes for every department.

    //if one interface is not enough our needs, we should create another!

    interface IWorker 
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    //one class can implements more than one interfaces.
    class Manager : IWorker, ISalary, IEat
    {
        public void Eat()
        {
        }

        public void GetSalary()
        {
        }

        public void Work()
        {
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
        }

        public void GetSalary()
        {
        }

        public void Work()
        {
        }
    }

    class Robots : IWorker
    {
        public void Work()
        {
        }
    }

}
