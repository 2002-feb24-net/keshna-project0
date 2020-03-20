
using System;
using System.Collections.Generic;

namespace CupCake
{
    internal class Menu
    { 

 
    // Menu class is responsible for displaying console output and prompting and parsing of the user input.
    
        
        internal static void DisplayCMenu()
        {
           
          
            Console.WriteLine("How can I help you today?\n");
            
            Console.WriteLine("1 ~  Exit");
            Console.WriteLine("2 ~  Display details of an order");
            Console.WriteLine("3 ~  Display order history of a location");
            Console.WriteLine("4 ~  Display order history of a customer");
            Console.WriteLine("5 ~  Display all locations");
            Console.WriteLine("6 ~  New customer");
            Console.WriteLine("7 ~  Existing customer");



        }

        internal static void DisplayMMenu()
        {


            Console.WriteLine("How can I help you today?\n");
           
            Console.WriteLine("0 ~ Search for a customer");
            Console.WriteLine("1 ~ Exit");
            Console.WriteLine("2 ~ Display details of an order");
            Console.WriteLine("3 ~ Display order history of a location");
            Console.WriteLine("4 ~ Display order history of a customer");
            Console.WriteLine("5 ~ Display all locations");
           

        }


        /// Prompt the user for input for the menu options and parse it into a InputReader.


        internal static InputReader PromptUser()
        {
           
            string input = Console.ReadLine();
     
            return (InputReader)Int32.Parse(input);
        }
    }
    }