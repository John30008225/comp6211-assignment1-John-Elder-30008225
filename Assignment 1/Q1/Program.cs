using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Title:   Q1 - Palindrome (Assignment 1)
Author:     John Elder
Date:       12/04/2019
Purpose:    application that obtains a word from the user and using at least one stack, appropriate static variables and the static methods listed below, you are to determine whether the word is a palindrome or not.  Then display the appropriate response back to the screen.
*/

namespace Q1
{
    class Program
    {
        static Stack palindrome = new Stack();                               //Stack "Palindrome" created
        static Stack p2 = new Stack();
        static string data = "";

        static void Main(string[] args)
        {
            Console.Write("Enter the word you think is a palindrome: ");
            data = Console.ReadLine().ToUpper().Replace(" ", String.Empty);  //Ignores capitalization and spaces when user enters word
            BuildWordStack(data);
            Stack p2 = (Stack)palindrome.Clone();
                      
            Console.ReadLine();
        }


        public static void BuildWordStack(string data)                      //Method receives the word entered by the user then pushes the characters of that word onto a stack.

        {
            Stack s1 = new Stack();

            char[] stackArr = data.ToCharArray();
            int count = stackArr.Length;
            for (int x = 0; x < count; x++)

                if (stackArr[x] != ' ')
                {
                   s1.Push(stackArr[x]);
                }
        
                ReverseWord(s1, count);
            
        }

        public static void ReverseWord(Stack s1,int count)                  //Method returns the word (the characters from the stack) in reverse.
        {
        
            string reverse = "";

            for (int x = 0; x < count; x++)
            {
                reverse += s1.Pop();
            }

            PalindromeCheck(reverse, data);
       
        }


        public static void PalindromeCheck(string reverse, string data)     //method receives the word entered, and the word in reverse to check whther or not it is a palindrome.
        {
            if (data == reverse)
            { 
                 Console.WriteLine($"The word {data} is a palindrome \n");              
            }
            
            else 
            {
                 Console.WriteLine($"{data} is not a Palindrome \n");       
            }
                
            Console.ReadLine();                 

            
            

        }
    }
}
