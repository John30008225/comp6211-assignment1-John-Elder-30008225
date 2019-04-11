using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Title:   Q3 - Queue Implementation (Assignment 1)
Author:     John Elder
Date:       12/04/2019
Purpose:   Write a C# Console application containing a generic class (“MyQueue”) that will have Enqueue & Dequeue methods to simulate those of a Queue collection using Array Lists:
*/



namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            myQueue<object>.Enqueue();              

            myQueue<object>.Dequeue();
          
        }
     

    }

    class myQueue<T>                                 //Class “MyQueue” created with generic type parameter <T> which by default all of the members inside of the class that are able to be generic, now have the ability to use the parameter..
    {

        static ArrayList Q1 = new ArrayList();       //ArrayList created.
        static string data = "";


         public static void Enqueue()
         {
            Q1.Add(data);                           //Adds an object to the end of the Queue
        }
         
         public static string Dequeue()             //Removes and returns the object at the beginning of the Queue
         {
            var x = Q1[0];
            Q1.RemoveAt(0);
            return x.ToString(); 

         }

    }

}
