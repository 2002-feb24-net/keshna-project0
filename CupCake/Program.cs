using System;
using System.Collections.Generic;

namespace CupCake
{  
        
    // My First Page.
    
    internal class Program
    {

       
        // Entry point to the console application.
       
        private static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("\n~~~~ Welcome to the CupCake ~~~~\n");
                    Console.WriteLine("Are you a customer (c) or manager (m)?\n");
                    string level = Console.ReadLine();
                    if (level == "c")
                    {
                        Menu.DisplayCMenu();
                        InputReader req = Menu.PromptUser();
                        ShowMenu.HandleRequest(req);
                    }
                    else if(level == "m")
                    {

                        Menu.DisplayMMenu();
                        InputReader req = Menu.PromptUser();
                        ShowMenu.HandleRequest(req);
                    }

                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\n");
                   
                }
            }
        }
    }
      
    }


