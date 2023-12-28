using System;
using System.Collections.Generic;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Välkomnande meddelande
            // En lista för att spara historik för räkningar
            // Användaren matar in tal och matematiska operation
            // OBS! Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet!
            // Ifall användaren skulle dela med 0 visa Ogiltig inmatning!
            // Lägga resultat till listan
            // Visa resultat
            // Fråga användaren om den vill visa tidigare resultat.
            // Visa tidigare resultat
            // Fråga användaren om den vill avsluta eller fortsätta

        
            string input2= "";
            int input3;
            int answer = 0;
            List<int> history = new List<int>();

            Console.WriteLine("Every time your enter an input, press enter to execute");
            Console.WriteLine("When you want to see the result press =");
            Console.WriteLine("If you want to exit in any moment, press x");
            Console.WriteLine("If you want the history press h");
            
            answer = Int32.Parse (Console.ReadLine());
                        
            while(true)
            {
                input2 = Console.ReadLine();
                if (input2.ToLower() == "h")
                {
                   foreach( int number in history)
                    {
                        Console.Write(number + " ");
                         
                    }
                  
                }
                if(input2.ToLower() == "x")
                {
                    break;    
                }

                input3 = Int32.Parse(Console.ReadLine());

                switch(input2) 
                {
                    case "*":
                        answer = answer * input3;
                        break;

                    case "+":
                        answer = answer + input3;
                        break;

                    case "-":
                        answer = answer - input3;
                        break;

                    case "/":
                        answer = answer / input3;

                        break;
                }
                history.Add(answer); 
                Console.WriteLine($"= {answer}" );
            }


            Console.ReadLine();
        }
    }
}
