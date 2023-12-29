using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace calculator
{
    class Program
    {
        // Asks until the input is correctly formatted
        static int InputInt()
        {
            int answer;
            bool res;
            while (true)
            {
                string tmp = Console.ReadLine();
                res = int.TryParse(tmp, out answer);
                if (res)
                    break;
                Console.WriteLine("integer input is not valid, try again");
            }
            return answer;
        }

        // Asks until the input is correctly formatted (accepts x and h too)
        static string InputOperator()
        {
            while (true)
            {
                string tmp = Console.ReadLine();
                string pattern = @"[+\-*\/hx]";
                if(Regex.IsMatch(tmp, pattern) && tmp.Length==1)
                {
                    return tmp; 
                }
                Console.WriteLine("Input is invalid, try again.");
            }
        }


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

            Console.WriteLine("Welcome to the calculator");
            Console.WriteLine("Every time your enter an input (numer or operator), press enter to execute");
            Console.WriteLine("If you want to exit input 'x'");
            Console.WriteLine("If you want to see the history of answers input 'h'");

            // We enter the inputs alternating between number and operator, so we only need two variables for that.
            // The only other variable we need is for storing the answers.
            // We input the first number into the variable 'answer' and use that for the next calculations.

            answer = InputInt();

            while (true)
            {
                input2 = InputOperator();
                // I assume we only make a choice of 'h' or 'x' when we are at the beginning of our calculation, not in the middle of it.
                if (input2.ToLower() == "h")
                {
                    foreach ( int number in history)
                    {
                        Console.Write(number + " ");

                    }
                    Console.WriteLine("");
                    continue;
                }
                if(input2.ToLower() == "x")
                {
                    break;    
                }

                input3 = InputInt();

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
                        if (input3 == 0)
                        {
                            Console.WriteLine("Invalid calculation, cannot divide by zero");
                            break;
                        }
                        answer = answer / input3;
                       
                        break;
                }
                history.Add(answer); 
                Console.WriteLine($"= {answer}" );
            }

        }
    }
}
