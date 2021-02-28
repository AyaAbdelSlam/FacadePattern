using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating the Facade

            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer

            Customer customer = new Customer("Aya AbdulSlam");
            bool eligible = mortgage.IsEligible(customer, 1000000);

            Console.WriteLine("\n" + customer.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));

            // Wait for user

            Console.ReadKey();
        }
    }
}
