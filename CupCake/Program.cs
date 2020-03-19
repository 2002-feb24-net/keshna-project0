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
                    Menu.DisplayMenu();
                    InputReader req = Menu.PromptUser();
                    ShowMenu.HandleRequest(req);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\n");
                   
                }
            }
        }
    }
      
    }


