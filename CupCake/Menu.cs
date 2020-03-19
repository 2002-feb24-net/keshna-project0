
using System;
using System.Collections.Generic;

namespace CupCake
{
    internal class Menu
    { 

 
    // Menu class is responsible for displaying console output and prompting and parsing of the user input.
    
        
        internal static void DisplayMenu()
        {
           
            Console.WriteLine("\n~~~~ Welcome to the CupCake ~~~~\n");
            Console.WriteLine("How can I help you today?\n");
            Console.WriteLine("0 ~ Place order");
            Console.WriteLine("1 ~ Add a new customer");
            Console.WriteLine("2 ~ Search for a customer");
            Console.WriteLine("3 ~ Display details of an order");
            Console.WriteLine("4 ~ Display order history of a location");
            Console.WriteLine("5 ~ Display order history of a customer");
            Console.WriteLine("6 ~ Display all locations");
            Console.WriteLine("7 ~ Exit");
            
        }

        
        /// Prompt the user for input for the menu options and parse it into a InputReader.
        
     
        internal static InputReader PromptUser()
        {
           
            string input = Console.ReadLine();
     
            return (InputReader)Int32.Parse(input);
        }
    }
    }