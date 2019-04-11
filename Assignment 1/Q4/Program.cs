using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Title:   Q4 - Bank Queue (Assignment 1)
Author:     John Elder
Date:       12/04/2019
Purpose:    Simulate a queue at the local Westpac Bank.  When your program starts you should display a menu of customers for the user to choose from as shown below:
*/


namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList customer = new ArrayList();
            {
                customer.Add(new Customer("1. Tradesman Joe", 5));
                customer.Add(new Customer("2. Dr Windy Pops", 2));
                customer.Add(new Customer("3. Grandpa Bob", 8));
                customer.Add(new Customer("4. Billy the kid", 3));
                customer.Add(new Customer("5. Chris on crutches", 6));
            }


           // System.Threading.Thread.Sleep(Customer.);


        }
    }

    class Customer
    {
        public string Name { get; set; }
        public int Time { get; set; }

        public Customer(string fullName, int waitingTime)
         {
            Name = fullName;
            Time = waitingTime*1000;
         }
                     
    }

          
    class myQueue<T>
    {

        static ArrayList Q1 = new ArrayList();
        static string data = "";


        public static void Enqueue()
        {
            Q1.Add(data);
        }

        public static string Dequeue()
        {
            var x = Q1[0];
            Q1.RemoveAt(0);
            return x.ToString();

        }

    }
}

